// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChessRogueNousStoryInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChessRogueNousStoryInfoScRsp.proto</summary>
  public static partial class GetChessRogueNousStoryInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChessRogueNousStoryInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChessRogueNousStoryInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVHZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb1NjUnNwLnByb3RvGiBDaGVz",
            "c1JvZ3VlTm91c1N1YlN0b3J5SW5mby5wcm90bxohQ2hlc3NSb2d1ZU5vdXNN",
            "YWluU3RvcnlJbmZvLnByb3RvIrYBCh9HZXRDaGVzc1JvZ3VlTm91c1N0b3J5",
            "SW5mb1NjUnNwEj8KGmNoZXNzX3JvZ3VlX3N1Yl9zdG9yeV9pbmZvGA4gAygL",
            "MhsuQ2hlc3NSb2d1ZU5vdXNTdWJTdG9yeUluZm8SQQobY2hlc3Nfcm9ndWVf",
            "bWFpbl9zdG9yeV9pbmZvGA8gAygLMhwuQ2hlc3NSb2d1ZU5vdXNNYWluU3Rv",
            "cnlJbmZvEg8KB3JldGNvZGUYCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRsp), global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRsp.Parser, new[]{ "ChessRogueSubStoryInfo", "ChessRogueMainStoryInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChessRogueNousStoryInfoScRsp : pb::IMessage<GetChessRogueNousStoryInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChessRogueNousStoryInfoScRsp> _parser = new pb::MessageParser<GetChessRogueNousStoryInfoScRsp>(() => new GetChessRogueNousStoryInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChessRogueNousStoryInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChessRogueNousStoryInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp(GetChessRogueNousStoryInfoScRsp other) : this() {
      chessRogueSubStoryInfo_ = other.chessRogueSubStoryInfo_.Clone();
      chessRogueMainStoryInfo_ = other.chessRogueMainStoryInfo_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChessRogueNousStoryInfoScRsp Clone() {
      return new GetChessRogueNousStoryInfoScRsp(this);
    }

    /// <summary>Field number for the "chess_rogue_sub_story_info" field.</summary>
    public const int ChessRogueSubStoryInfoFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfo> _repeated_chessRogueSubStoryInfo_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfo> chessRogueSubStoryInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousSubStoryInfo> ChessRogueSubStoryInfo {
      get { return chessRogueSubStoryInfo_; }
    }

    /// <summary>Field number for the "chess_rogue_main_story_info" field.</summary>
    public const int ChessRogueMainStoryInfoFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfo> _repeated_chessRogueMainStoryInfo_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfo> chessRogueMainStoryInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousMainStoryInfo> ChessRogueMainStoryInfo {
      get { return chessRogueMainStoryInfo_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChessRogueNousStoryInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChessRogueNousStoryInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chessRogueSubStoryInfo_.Equals(other.chessRogueSubStoryInfo_)) return false;
      if(!chessRogueMainStoryInfo_.Equals(other.chessRogueMainStoryInfo_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chessRogueSubStoryInfo_.GetHashCode();
      hash ^= chessRogueMainStoryInfo_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      chessRogueSubStoryInfo_.WriteTo(output, _repeated_chessRogueSubStoryInfo_codec);
      chessRogueMainStoryInfo_.WriteTo(output, _repeated_chessRogueMainStoryInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      chessRogueSubStoryInfo_.WriteTo(ref output, _repeated_chessRogueSubStoryInfo_codec);
      chessRogueMainStoryInfo_.WriteTo(ref output, _repeated_chessRogueMainStoryInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += chessRogueSubStoryInfo_.CalculateSize(_repeated_chessRogueSubStoryInfo_codec);
      size += chessRogueMainStoryInfo_.CalculateSize(_repeated_chessRogueMainStoryInfo_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChessRogueNousStoryInfoScRsp other) {
      if (other == null) {
        return;
      }
      chessRogueSubStoryInfo_.Add(other.chessRogueSubStoryInfo_);
      chessRogueMainStoryInfo_.Add(other.chessRogueMainStoryInfo_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            chessRogueSubStoryInfo_.AddEntriesFrom(input, _repeated_chessRogueSubStoryInfo_codec);
            break;
          }
          case 122: {
            chessRogueMainStoryInfo_.AddEntriesFrom(input, _repeated_chessRogueMainStoryInfo_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            chessRogueSubStoryInfo_.AddEntriesFrom(ref input, _repeated_chessRogueSubStoryInfo_codec);
            break;
          }
          case 122: {
            chessRogueMainStoryInfo_.AddEntriesFrom(ref input, _repeated_chessRogueMainStoryInfo_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
