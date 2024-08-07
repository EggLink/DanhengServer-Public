﻿using System.Globalization;
using EggLink.DanhengServer.Command.Command;
using EggLink.DanhengServer.Configuration;
using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.GameServer.Command;
using EggLink.DanhengServer.GameServer.Plugin;
using EggLink.DanhengServer.GameServer.Server;
using EggLink.DanhengServer.GameServer.Server.Packet;
using EggLink.DanhengServer.Internationalization;
using EggLink.DanhengServer.Kcp;
using EggLink.DanhengServer.Program.Handbook;
using EggLink.DanhengServer.Util;
using EggLink.DanhengServer.WebServer;
using EggLink.DanhengServer.WebServer.Server;

namespace EggLink.DanhengServer.Program.Program;

public class EntryPoint
{
    private static readonly Logger Logger = new("Program");
    public static readonly DatabaseHelper DatabaseHelper = new();
    public static readonly Listener Listener = new();
    public static readonly CommandManager CommandManager = new();

    public static void Main(string[] args)
    {
        AppDomain.CurrentDomain.ProcessExit += (sender, eventArgs) =>
        {
            Logger.Info(I18nManager.Translate("Server.ServerInfo.Shutdown"));
            PerformCleanup();
        };
        Console.CancelKeyPress += (sender, eventArgs) =>
        {
            Logger.Info(I18nManager.Translate("Server.ServerInfo.CancelKeyPressed"));
            eventArgs.Cancel = true;
            Environment.Exit(0);
        };
        var time = DateTime.Now;
        // Initialize the logfile
        var counter = 0;
        FileInfo file;
        while (true)
        {
            file = new FileInfo(GetConfig().Path.LogPath + $"/{DateTime.Now:yyyy-MM-dd}-{++counter}.log");
            if (!file.Exists && file.Directory != null)
            {
                file.Directory.Create();
                break;
            }
        }

        Logger.SetLogFile(file);
        // Starting the server
        Logger.Info(I18nManager.Translate("Server.ServerInfo.StartingServer"));

        // Load the config
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.Config")));
        try
        {
            ConfigManager.LoadConfig();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToLoadItem", I18nManager.Translate("Word.Config")), e);
            Console.ReadLine();
            return;
        }

        // Load the language
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.Language")));
        try
        {
            I18nManager.LoadLanguage();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToLoadItem", I18nManager.Translate("Word.Language")), e);
            Console.ReadLine();
            return;
        }

        // Load the game data
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.GameData")));
        try
        {
            ResourceManager.LoadGameData();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToLoadItem", I18nManager.Translate("Word.GameData")), e);
            Console.ReadLine();
            return;
        }

        // Initialize the database
        try
        {
            DatabaseHelper.Initialize();

            if (args.Contains("--upgrade-database")) DatabaseHelper.UpgradeDatabase();

            if (args.Contains("--move")) DatabaseHelper.MoveFromSqlite();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToLoadItem", I18nManager.Translate("Word.Database")), e);
            Console.ReadLine();
            return;
        }

        // Register the command handlers
        try
        {
            CommandManager.RegisterCommand();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToInitializeItem",
                    I18nManager.Translate("Word.Command")), e);
            Console.ReadLine();
            return;
        }

        // Load the plugins
        Logger.Info(I18nManager.Translate("Server.ServerInfo.LoadingItem", I18nManager.Translate("Word.Plugin")));
        try
        {
            PluginManager.LoadPlugins();
        }
        catch (Exception e)
        {
            Logger.Error(
                I18nManager.Translate("Server.ServerInfo.FailedToLoadItem", I18nManager.Translate("Word.Plugin")), e);
            Console.ReadLine();
            return;
        }

        CommandExecutor.OnRunCommand += (sender, e) => { CommandManager.HandleCommand(e, sender); };

        MuipManager.OnExecuteCommand += CommandManager.HandleCommand;
        MuipManager.OnGetServerInformation += x =>
        {
            foreach (var con in DanhengListener.Connections.Values)
                if ((con as Connection)?.Player != null)
                    x.Add((con as Connection)!.Player!.Uid, (con as Connection)!.Player!.Data);
        };
        MuipManager.OnGetPlayerStatus += (int uid, out PlayerStatusEnum status, out PlayerSubStatusEnum subStatus) =>
        {
            subStatus = PlayerSubStatusEnum.None;
            foreach (var con in DanhengListener.Connections.Values)
                if ((con as Connection)!.Player != null && (con as Connection)!.Player!.Uid == uid)
                {
                    if ((con as Connection)!.Player!.RogueManager?.GetRogueInstance() != null)
                    {
                        status = PlayerStatusEnum.Rogue;
                        if ((con as Connection)!.Player!.ChessRogueManager?.RogueInstance?.AreaExcel.RogueVersionId ==
                            202)
                            status = PlayerStatusEnum.ChessRogueNous;
                        else if ((con as Connection)!.Player!.ChessRogueManager?.RogueInstance?.AreaExcel
                                 .RogueVersionId == 201)
                            status = PlayerStatusEnum.ChessRogue;
                    }
                    else if ((con as Connection)!.Player!.ChallengeManager?.ChallengeInstance != null)
                    {
                        status = PlayerStatusEnum.Challenge;
                        if ((con as Connection)!.Player?.ChallengeManager?.ChallengeInstance?.Excel.StoryExcel != null)
                            status = PlayerStatusEnum.ChallengeStory;
                        else if ((con as Connection)!.Player?.ChallengeManager?.ChallengeInstance?.Excel.BossExcel !=
                                 null)
                            status = PlayerStatusEnum.ChallengeBoss;
                    }
                    else if ((con as Connection)!.Player!.RaidManager?.RaidData.CurRaidId != 0)
                    {
                        status = PlayerStatusEnum.Raid;
                    }
                    else if ((con as Connection)!.Player!.StoryLineManager?.StoryLineData.CurStoryLineId != 0)
                    {
                        status = PlayerStatusEnum.StoryLine;
                    }
                    else
                    {
                        status = PlayerStatusEnum.Explore;
                    }

                    if ((con as Connection)!.Player!.BattleInstance != null) subStatus = PlayerSubStatusEnum.Battle;

                    return;
                }

            status = PlayerStatusEnum.Offline;
        };

        // generate the handbook
        HandbookGenerator.Generate();

        HandlerManager.Init();

        WebProgram.Main([], GetConfig().HttpServer.PublicPort, GetConfig().HttpServer.GetDisplayAddress());
        Logger.Info(I18nManager.Translate("Server.ServerInfo.ServerRunning", I18nManager.Translate("Word.Dispatch"),
            GetConfig().HttpServer.GetDisplayAddress()));

        DanhengListener.BaseConnection = typeof(Connection);
        DanhengListener.StartListener();

        var elapsed = DateTime.Now - time;
        Logger.Info(I18nManager.Translate("Server.ServerInfo.ServerStarted",
            elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture)[..4]));

        GenerateLogMap();

        if (GetConfig().ServerOption.EnableMission)
            Logger.Warn(I18nManager.Translate("Server.ServerInfo.MissionEnabled"));
        CommandManager.Start();
    }

    public static ConfigContainer GetConfig()
    {
        return ConfigManager.Config;
    }

    private static void PerformCleanup()
    {
        PluginManager.UnloadPlugins();
        DanhengListener.Connections.Values.ToList().ForEach(x => x.Stop());

        DatabaseHelper.SaveThread?.Interrupt();
        DatabaseHelper.SaveDatabase();
    }

    private static void GenerateLogMap()
    {
        // get opcode from CmdIds
        var opcodes = typeof(CmdIds).GetFields().Where(x => x.FieldType == typeof(int)).ToList();
        foreach (var opcode in opcodes)
        {
            var name = opcode.Name;
            var value = (int)opcode.GetValue(null)!;
            DanhengConnection.LogMap.Add(value.ToString(), name);
        }
    }
}