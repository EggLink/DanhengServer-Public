﻿using EggLink.DanhengServer.Internationalization.Message;
using EggLink.DanhengServer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Internationalization
{
    public static class I18nManager
    {
        public static Logger Logger = new("I18nManager");

        public static object Language { get; set; } = new LanguageEN();

        public static void LoadLanguage()
        {
            var languageStr = "EggLink.DanhengServer.Internationalization.Message.Language" + ConfigManager.Config.ServerOption.Language;
            var languageType = Type.GetType(languageStr);
            if (languageType == null)
            {
                throw new Exception("Language not found");
            }
            var language = Activator.CreateInstance(languageType) ?? throw new Exception("Language not found");
            Language = language;

            Logger.Info("Language loaded");
        }

        public static string Translate(string key, params string[] args)
        {
            var value = GetNestedPropertyValue(Language, key);

            foreach (var arg in args)
            {
                value = value.Replace("{" + args.ToList().IndexOf(arg) + "}", arg);
            }
            return value;
        }


        public static string GetNestedPropertyValue(object? obj, string propertyName)
        {
            foreach (string part in propertyName.Split('.'))
            {
                if (obj == null) return propertyName;

                Type type = obj.GetType();
                PropertyInfo? property = type.GetProperty(part);
                if (property == null) return propertyName;

                obj = property.GetValue(obj, null);
            }

            return (string)(obj ?? propertyName);
        }
    }
}
