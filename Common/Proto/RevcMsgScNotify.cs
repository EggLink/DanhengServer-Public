// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RevcMsgScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RevcMsgScNotify.proto</summary>
  public static partial class RevcMsgScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RevcMsgScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RevcMsgScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSZXZjTXNnU2NOb3RpZnkucHJvdG8aDkNoYXRUeXBlLnByb3RvGg1Nc2dU",
            "eXBlLnByb3RvIp8BCg9SZXZjTXNnU2NOb3RpZnkSEgoKdGFyZ2V0X3VpZBgD",
            "IAEoDRIQCghleHRyYV9pZBgCIAEoDRIeCgxtZXNzYWdlX3R5cGUYDyABKA4y",
            "CC5Nc2dUeXBlEhIKCnNvdXJjZV91aWQYCyABKA0SFAoMbWVzc2FnZV90ZXh0",
            "GAkgASgJEhwKCWNoYXRfdHlwZRgGIAEoDjIJLkNoYXRUeXBlQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChatTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RevcMsgScNotify), global::EggLink.DanhengServer.Proto.RevcMsgScNotify.Parser, new[]{ "TargetUid", "ExtraId", "MessageType", "SourceUid", "MessageText", "ChatType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RevcMsgScNotify : pb::IMessage<RevcMsgScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RevcMsgScNotify> _parser = new pb::MessageParser<RevcMsgScNotify>(() => new RevcMsgScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RevcMsgScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RevcMsgScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify(RevcMsgScNotify other) : this() {
      targetUid_ = other.targetUid_;
      extraId_ = other.extraId_;
      messageType_ = other.messageType_;
      sourceUid_ = other.sourceUid_;
      messageText_ = other.messageText_;
      chatType_ = other.chatType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify Clone() {
      return new RevcMsgScNotify(this);
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 3;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "extra_id" field.</summary>
    public const int ExtraIdFieldNumber = 2;
    private uint extraId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraId {
      get { return extraId_; }
      set {
        extraId_ = value;
      }
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MsgType messageType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "source_uid" field.</summary>
    public const int SourceUidFieldNumber = 11;
    private uint sourceUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceUid {
      get { return sourceUid_; }
      set {
        sourceUid_ = value;
      }
    }

    /// <summary>Field number for the "message_text" field.</summary>
    public const int MessageTextFieldNumber = 9;
    private string messageText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageText {
      get { return messageText_; }
      set {
        messageText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chat_type" field.</summary>
    public const int ChatTypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ChatType chatType_ = global::EggLink.DanhengServer.Proto.ChatType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChatType ChatType {
      get { return chatType_; }
      set {
        chatType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RevcMsgScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RevcMsgScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetUid != other.TargetUid) return false;
      if (ExtraId != other.ExtraId) return false;
      if (MessageType != other.MessageType) return false;
      if (SourceUid != other.SourceUid) return false;
      if (MessageText != other.MessageText) return false;
      if (ChatType != other.ChatType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (ExtraId != 0) hash ^= ExtraId.GetHashCode();
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MessageType.GetHashCode();
      if (SourceUid != 0) hash ^= SourceUid.GetHashCode();
      if (MessageText.Length != 0) hash ^= MessageText.GetHashCode();
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) hash ^= ChatType.GetHashCode();
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
      if (ExtraId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ExtraId);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetUid);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ChatType);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(MessageText);
      }
      if (SourceUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SourceUid);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MessageType);
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
      if (ExtraId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ExtraId);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetUid);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ChatType);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(MessageText);
      }
      if (SourceUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SourceUid);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MessageType);
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
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (ExtraId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraId);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
      }
      if (SourceUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceUid);
      }
      if (MessageText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageText);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RevcMsgScNotify other) {
      if (other == null) {
        return;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.ExtraId != 0) {
        ExtraId = other.ExtraId;
      }
      if (other.MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MessageType = other.MessageType;
      }
      if (other.SourceUid != 0) {
        SourceUid = other.SourceUid;
      }
      if (other.MessageText.Length != 0) {
        MessageText = other.MessageText;
      }
      if (other.ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        ChatType = other.ChatType;
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
          case 16: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 48: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 74: {
            MessageText = input.ReadString();
            break;
          }
          case 88: {
            SourceUid = input.ReadUInt32();
            break;
          }
          case 120: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
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
          case 16: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 48: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 74: {
            MessageText = input.ReadString();
            break;
          }
          case 88: {
            SourceUid = input.ReadUInt32();
            break;
          }
          case 120: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
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
