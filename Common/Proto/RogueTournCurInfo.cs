// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournCurInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournCurInfo.proto</summary>
  public static partial class RogueTournCurInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournCurInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournCurInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSb2d1ZVRvdXJuQ3VySW5mby5wcm90bxobUm9ndWVUb3VybkN1ckdhbWVJ",
            "bmZvLnByb3RvGhtSb2d1ZVRvdXJuQ3VyQXJlYUluZm8ucHJvdG8iigEKEVJv",
            "Z3VlVG91cm5DdXJJbmZvEjkKGXJvZ3VlX3RvdXJuX2N1cl9hcmVhX2luZm8Y",
            "AiABKAsyFi5Sb2d1ZVRvdXJuQ3VyQXJlYUluZm8SOgoZcm9ndWVfdG91cm5f",
            "Y3VyX2dhbWVfaW5mbxjlAyABKAsyFi5Sb2d1ZVRvdXJuQ3VyR2FtZUluZm9C",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTournCurGameInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournCurInfo), global::EggLink.DanhengServer.Proto.RogueTournCurInfo.Parser, new[]{ "RogueTournCurAreaInfo", "RogueTournCurGameInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournCurInfo : pb::IMessage<RogueTournCurInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournCurInfo> _parser = new pb::MessageParser<RogueTournCurInfo>(() => new RogueTournCurInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournCurInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournCurInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurInfo(RogueTournCurInfo other) : this() {
      rogueTournCurAreaInfo_ = other.rogueTournCurAreaInfo_ != null ? other.rogueTournCurAreaInfo_.Clone() : null;
      rogueTournCurGameInfo_ = other.rogueTournCurGameInfo_ != null ? other.rogueTournCurGameInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurInfo Clone() {
      return new RogueTournCurInfo(this);
    }

    /// <summary>Field number for the "rogue_tourn_cur_area_info" field.</summary>
    public const int RogueTournCurAreaInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo rogueTournCurAreaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo RogueTournCurAreaInfo {
      get { return rogueTournCurAreaInfo_; }
      set {
        rogueTournCurAreaInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_cur_game_info" field.</summary>
    public const int RogueTournCurGameInfoFieldNumber = 485;
    private global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo rogueTournCurGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo RogueTournCurGameInfo {
      get { return rogueTournCurGameInfo_; }
      set {
        rogueTournCurGameInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournCurInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournCurInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueTournCurAreaInfo, other.RogueTournCurAreaInfo)) return false;
      if (!object.Equals(RogueTournCurGameInfo, other.RogueTournCurGameInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueTournCurAreaInfo_ != null) hash ^= RogueTournCurAreaInfo.GetHashCode();
      if (rogueTournCurGameInfo_ != null) hash ^= RogueTournCurGameInfo.GetHashCode();
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
      if (rogueTournCurAreaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournCurAreaInfo);
      }
      if (rogueTournCurGameInfo_ != null) {
        output.WriteRawTag(170, 30);
        output.WriteMessage(RogueTournCurGameInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (rogueTournCurAreaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournCurAreaInfo);
      }
      if (rogueTournCurGameInfo_ != null) {
        output.WriteRawTag(170, 30);
        output.WriteMessage(RogueTournCurGameInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (rogueTournCurAreaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurAreaInfo);
      }
      if (rogueTournCurGameInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurGameInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournCurInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueTournCurAreaInfo_ != null) {
        if (rogueTournCurAreaInfo_ == null) {
          RogueTournCurAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo();
        }
        RogueTournCurAreaInfo.MergeFrom(other.RogueTournCurAreaInfo);
      }
      if (other.rogueTournCurGameInfo_ != null) {
        if (rogueTournCurGameInfo_ == null) {
          RogueTournCurGameInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo();
        }
        RogueTournCurGameInfo.MergeFrom(other.RogueTournCurGameInfo);
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
          case 18: {
            if (rogueTournCurAreaInfo_ == null) {
              RogueTournCurAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo();
            }
            input.ReadMessage(RogueTournCurAreaInfo);
            break;
          }
          case 3882: {
            if (rogueTournCurGameInfo_ == null) {
              RogueTournCurGameInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo();
            }
            input.ReadMessage(RogueTournCurGameInfo);
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
          case 18: {
            if (rogueTournCurAreaInfo_ == null) {
              RogueTournCurAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurAreaInfo();
            }
            input.ReadMessage(RogueTournCurAreaInfo);
            break;
          }
          case 3882: {
            if (rogueTournCurGameInfo_ == null) {
              RogueTournCurGameInfo = new global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo();
            }
            input.ReadMessage(RogueTournCurGameInfo);
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