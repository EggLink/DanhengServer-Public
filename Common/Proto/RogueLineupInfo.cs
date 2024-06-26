// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueLineupInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueLineupInfo.proto</summary>
  public static partial class RogueLineupInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueLineupInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueLineupInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZUxpbmV1cEluZm8ucHJvdG8aFVJvZ3VlUmV2aXZlSW5mby5wcm90",
            "byJ/Cg9Sb2d1ZUxpbmV1cEluZm8SEwoLRUhJRkNMT1BISEIYCSADKA0SGwoT",
            "YmFzZV9hdmF0YXJfaWRfbGlzdBgHIAMoDRITCgtQUE1QR09HT0xJRhgMIAMo",
            "DRIlCgtyZXZpdmVfaW5mbxgNIAEoCzIQLlJvZ3VlUmV2aXZlSW5mb0IeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueReviveInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueLineupInfo), global::EggLink.DanhengServer.Proto.RogueLineupInfo.Parser, new[]{ "EHIFCLOPHHB", "BaseAvatarIdList", "PPMPGOGOLIF", "ReviveInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueLineupInfo : pb::IMessage<RogueLineupInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueLineupInfo> _parser = new pb::MessageParser<RogueLineupInfo>(() => new RogueLineupInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueLineupInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueLineupInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueLineupInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueLineupInfo(RogueLineupInfo other) : this() {
      eHIFCLOPHHB_ = other.eHIFCLOPHHB_.Clone();
      baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
      pPMPGOGOLIF_ = other.pPMPGOGOLIF_.Clone();
      reviveInfo_ = other.reviveInfo_ != null ? other.reviveInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueLineupInfo Clone() {
      return new RogueLineupInfo(this);
    }

    /// <summary>Field number for the "EHIFCLOPHHB" field.</summary>
    public const int EHIFCLOPHHBFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_eHIFCLOPHHB_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> eHIFCLOPHHB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EHIFCLOPHHB {
      get { return eHIFCLOPHHB_; }
    }

    /// <summary>Field number for the "base_avatar_id_list" field.</summary>
    public const int BaseAvatarIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_baseAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> baseAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BaseAvatarIdList {
      get { return baseAvatarIdList_; }
    }

    /// <summary>Field number for the "PPMPGOGOLIF" field.</summary>
    public const int PPMPGOGOLIFFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_pPMPGOGOLIF_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> pPMPGOGOLIF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PPMPGOGOLIF {
      get { return pPMPGOGOLIF_; }
    }

    /// <summary>Field number for the "revive_info" field.</summary>
    public const int ReviveInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueReviveInfo reviveInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueReviveInfo ReviveInfo {
      get { return reviveInfo_; }
      set {
        reviveInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueLineupInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueLineupInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!eHIFCLOPHHB_.Equals(other.eHIFCLOPHHB_)) return false;
      if(!baseAvatarIdList_.Equals(other.baseAvatarIdList_)) return false;
      if(!pPMPGOGOLIF_.Equals(other.pPMPGOGOLIF_)) return false;
      if (!object.Equals(ReviveInfo, other.ReviveInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= eHIFCLOPHHB_.GetHashCode();
      hash ^= baseAvatarIdList_.GetHashCode();
      hash ^= pPMPGOGOLIF_.GetHashCode();
      if (reviveInfo_ != null) hash ^= ReviveInfo.GetHashCode();
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
      baseAvatarIdList_.WriteTo(output, _repeated_baseAvatarIdList_codec);
      eHIFCLOPHHB_.WriteTo(output, _repeated_eHIFCLOPHHB_codec);
      pPMPGOGOLIF_.WriteTo(output, _repeated_pPMPGOGOLIF_codec);
      if (reviveInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReviveInfo);
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
      baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
      eHIFCLOPHHB_.WriteTo(ref output, _repeated_eHIFCLOPHHB_codec);
      pPMPGOGOLIF_.WriteTo(ref output, _repeated_pPMPGOGOLIF_codec);
      if (reviveInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReviveInfo);
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
      size += eHIFCLOPHHB_.CalculateSize(_repeated_eHIFCLOPHHB_codec);
      size += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
      size += pPMPGOGOLIF_.CalculateSize(_repeated_pPMPGOGOLIF_codec);
      if (reviveInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReviveInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueLineupInfo other) {
      if (other == null) {
        return;
      }
      eHIFCLOPHHB_.Add(other.eHIFCLOPHHB_);
      baseAvatarIdList_.Add(other.baseAvatarIdList_);
      pPMPGOGOLIF_.Add(other.pPMPGOGOLIF_);
      if (other.reviveInfo_ != null) {
        if (reviveInfo_ == null) {
          ReviveInfo = new global::EggLink.DanhengServer.Proto.RogueReviveInfo();
        }
        ReviveInfo.MergeFrom(other.ReviveInfo);
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
          case 58:
          case 56: {
            baseAvatarIdList_.AddEntriesFrom(input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 74:
          case 72: {
            eHIFCLOPHHB_.AddEntriesFrom(input, _repeated_eHIFCLOPHHB_codec);
            break;
          }
          case 98:
          case 96: {
            pPMPGOGOLIF_.AddEntriesFrom(input, _repeated_pPMPGOGOLIF_codec);
            break;
          }
          case 106: {
            if (reviveInfo_ == null) {
              ReviveInfo = new global::EggLink.DanhengServer.Proto.RogueReviveInfo();
            }
            input.ReadMessage(ReviveInfo);
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
          case 58:
          case 56: {
            baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 74:
          case 72: {
            eHIFCLOPHHB_.AddEntriesFrom(ref input, _repeated_eHIFCLOPHHB_codec);
            break;
          }
          case 98:
          case 96: {
            pPMPGOGOLIF_.AddEntriesFrom(ref input, _repeated_pPMPGOGOLIF_codec);
            break;
          }
          case 106: {
            if (reviveInfo_ == null) {
              ReviveInfo = new global::EggLink.DanhengServer.Proto.RogueReviveInfo();
            }
            input.ReadMessage(ReviveInfo);
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
