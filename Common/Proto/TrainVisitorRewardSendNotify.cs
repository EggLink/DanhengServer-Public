// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainVisitorRewardSendNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainVisitorRewardSendNotify.proto</summary>
  public static partial class TrainVisitorRewardSendNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainVisitorRewardSendNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainVisitorRewardSendNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJUcmFpblZpc2l0b3JSZXdhcmRTZW5kTm90aWZ5LnByb3RvGhFISEdQRUhF",
            "REtNRy5wcm90bxoOSXRlbUxpc3QucHJvdG8iagocVHJhaW5WaXNpdG9yUmV3",
            "YXJkU2VuZE5vdGlmeRITCgtNQ0lORE9JQ0VMQhgIIAEoDRIaCgR0eXBlGA0g",
            "ASgOMgwuSEhHUEVIRURLTUcSGQoGcmV3YXJkGA4gASgLMgkuSXRlbUxpc3RC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HHGPEHEDKMGReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotify), global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotify.Parser, new[]{ "MCINDOICELB", "Type", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainVisitorRewardSendNotify : pb::IMessage<TrainVisitorRewardSendNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainVisitorRewardSendNotify> _parser = new pb::MessageParser<TrainVisitorRewardSendNotify>(() => new TrainVisitorRewardSendNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainVisitorRewardSendNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify(TrainVisitorRewardSendNotify other) : this() {
      mCINDOICELB_ = other.mCINDOICELB_;
      type_ = other.type_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify Clone() {
      return new TrainVisitorRewardSendNotify(this);
    }

    /// <summary>Field number for the "MCINDOICELB" field.</summary>
    public const int MCINDOICELBFieldNumber = 8;
    private uint mCINDOICELB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MCINDOICELB {
      get { return mCINDOICELB_; }
      set {
        mCINDOICELB_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.HHGPEHEDKMG type_ = global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHGPEHEDKMG Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainVisitorRewardSendNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainVisitorRewardSendNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MCINDOICELB != other.MCINDOICELB) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MCINDOICELB != 0) hash ^= MCINDOICELB.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone) hash ^= Type.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      if (MCINDOICELB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MCINDOICELB);
      }
      if (Type != global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
      }
      if (reward_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Reward);
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
      if (MCINDOICELB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MCINDOICELB);
      }
      if (Type != global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Type);
      }
      if (reward_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Reward);
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
      if (MCINDOICELB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MCINDOICELB);
      }
      if (Type != global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainVisitorRewardSendNotify other) {
      if (other == null) {
        return;
      }
      if (other.MCINDOICELB != 0) {
        MCINDOICELB = other.MCINDOICELB;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.HHGPEHEDKMG.TrainVisitorRewardSendNone) {
        Type = other.Type;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
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
          case 64: {
            MCINDOICELB = input.ReadUInt32();
            break;
          }
          case 104: {
            Type = (global::EggLink.DanhengServer.Proto.HHGPEHEDKMG) input.ReadEnum();
            break;
          }
          case 114: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
          case 64: {
            MCINDOICELB = input.ReadUInt32();
            break;
          }
          case 104: {
            Type = (global::EggLink.DanhengServer.Proto.HHGPEHEDKMG) input.ReadEnum();
            break;
          }
          case 114: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
