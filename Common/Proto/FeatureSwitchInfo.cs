// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FeatureSwitchInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FeatureSwitchInfo.proto</summary>
  public static partial class FeatureSwitchInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FeatureSwitchInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureSwitchInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdGZWF0dXJlU3dpdGNoSW5mby5wcm90bxoXRmVhdHVyZVN3aXRjaFR5cGUu",
            "cHJvdG8aGEZlYXR1cmVTd2l0Y2hQYXJhbS5wcm90byKUAQoRRmVhdHVyZVN3",
            "aXRjaEluZm8SKwoPVHlwZUZpZWxkTnVtYmVyGAEgASgOMhIuRmVhdHVyZVN3",
            "aXRjaFR5cGUSMgoVU3dpdGNoTGlzdEZpZWxkTnVtYmVyGAIgAygLMhMuRmVh",
            "dHVyZVN3aXRjaFBhcmFtEh4KFklzQWxsQ2xvc2VkRmllbGROdW1iZXIYAyAB",
            "KAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FeatureSwitchTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.FeatureSwitchParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FeatureSwitchInfo), global::EggLink.DanhengServer.Proto.FeatureSwitchInfo.Parser, new[]{ "TypeFieldNumber", "SwitchListFieldNumber", "IsAllClosedFieldNumber" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeatureSwitchInfo : pb::IMessage<FeatureSwitchInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureSwitchInfo> _parser = new pb::MessageParser<FeatureSwitchInfo>(() => new FeatureSwitchInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureSwitchInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FeatureSwitchInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchInfo(FeatureSwitchInfo other) : this() {
      typeFieldNumber_ = other.typeFieldNumber_;
      switchListFieldNumber_ = other.switchListFieldNumber_.Clone();
      isAllClosedFieldNumber_ = other.isAllClosedFieldNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureSwitchInfo Clone() {
      return new FeatureSwitchInfo(this);
    }

    /// <summary>Field number for the "TypeFieldNumber" field.</summary>
    public const int TypeFieldNumberFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.FeatureSwitchType typeFieldNumber_ = global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FeatureSwitchType TypeFieldNumber {
      get { return typeFieldNumber_; }
      set {
        typeFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "SwitchListFieldNumber" field.</summary>
    public const int SwitchListFieldNumberFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FeatureSwitchParam> _repeated_switchListFieldNumber_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.FeatureSwitchParam.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FeatureSwitchParam> switchListFieldNumber_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FeatureSwitchParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FeatureSwitchParam> SwitchListFieldNumber {
      get { return switchListFieldNumber_; }
    }

    /// <summary>Field number for the "IsAllClosedFieldNumber" field.</summary>
    public const int IsAllClosedFieldNumberFieldNumber = 3;
    private bool isAllClosedFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllClosedFieldNumber {
      get { return isAllClosedFieldNumber_; }
      set {
        isAllClosedFieldNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureSwitchInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureSwitchInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TypeFieldNumber != other.TypeFieldNumber) return false;
      if(!switchListFieldNumber_.Equals(other.switchListFieldNumber_)) return false;
      if (IsAllClosedFieldNumber != other.IsAllClosedFieldNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TypeFieldNumber != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) hash ^= TypeFieldNumber.GetHashCode();
      hash ^= switchListFieldNumber_.GetHashCode();
      if (IsAllClosedFieldNumber != false) hash ^= IsAllClosedFieldNumber.GetHashCode();
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
      if (TypeFieldNumber != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TypeFieldNumber);
      }
      switchListFieldNumber_.WriteTo(output, _repeated_switchListFieldNumber_codec);
      if (IsAllClosedFieldNumber != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAllClosedFieldNumber);
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
      if (TypeFieldNumber != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TypeFieldNumber);
      }
      switchListFieldNumber_.WriteTo(ref output, _repeated_switchListFieldNumber_codec);
      if (IsAllClosedFieldNumber != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAllClosedFieldNumber);
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
      if (TypeFieldNumber != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TypeFieldNumber);
      }
      size += switchListFieldNumber_.CalculateSize(_repeated_switchListFieldNumber_codec);
      if (IsAllClosedFieldNumber != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureSwitchInfo other) {
      if (other == null) {
        return;
      }
      if (other.TypeFieldNumber != global::EggLink.DanhengServer.Proto.FeatureSwitchType.FeatureSwitchNone) {
        TypeFieldNumber = other.TypeFieldNumber;
      }
      switchListFieldNumber_.Add(other.switchListFieldNumber_);
      if (other.IsAllClosedFieldNumber != false) {
        IsAllClosedFieldNumber = other.IsAllClosedFieldNumber;
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
          case 8: {
            TypeFieldNumber = (global::EggLink.DanhengServer.Proto.FeatureSwitchType) input.ReadEnum();
            break;
          }
          case 18: {
            switchListFieldNumber_.AddEntriesFrom(input, _repeated_switchListFieldNumber_codec);
            break;
          }
          case 24: {
            IsAllClosedFieldNumber = input.ReadBool();
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
          case 8: {
            TypeFieldNumber = (global::EggLink.DanhengServer.Proto.FeatureSwitchType) input.ReadEnum();
            break;
          }
          case 18: {
            switchListFieldNumber_.AddEntriesFrom(ref input, _repeated_switchListFieldNumber_codec);
            break;
          }
          case 24: {
            IsAllClosedFieldNumber = input.ReadBool();
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
