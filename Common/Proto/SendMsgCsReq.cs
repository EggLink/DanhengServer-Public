// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SendMsgCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SendMsgCsReq.proto</summary>
  public static partial class SendMsgCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SendMsgCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendMsgCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTZW5kTXNnQ3NSZXEucHJvdG8aDkNoYXRUeXBlLnByb3RvGhFCSUVORUJD",
            "RUlPRi5wcm90bxoNTXNnVHlwZS5wcm90byKsAQoMU2VuZE1zZ0NzUmVxEiEK",
            "C09CRktJRE9JSkJDGA4gASgLMgwuQklFTkVCQ0VJT0YSEAoIZXh0cmFfaWQY",
            "CyABKA0SEwoLdGFyZ2V0X2xpc3QYDyADKA0SFAoMbWVzc2FnZV90ZXh0GAIg",
            "ASgJEh4KDG1lc3NhZ2VfdHlwZRgHIAEoDjIILk1zZ1R5cGUSHAoJY2hhdF90",
            "eXBlGAwgASgOMgkuQ2hhdFR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChatTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.BIENEBCEIOFReflection.Descriptor, global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SendMsgCsReq), global::EggLink.DanhengServer.Proto.SendMsgCsReq.Parser, new[]{ "OBFKIDOIJBC", "ExtraId", "TargetList", "MessageText", "MessageType", "ChatType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SendMsgCsReq : pb::IMessage<SendMsgCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendMsgCsReq> _parser = new pb::MessageParser<SendMsgCsReq>(() => new SendMsgCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendMsgCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SendMsgCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq(SendMsgCsReq other) : this() {
      oBFKIDOIJBC_ = other.oBFKIDOIJBC_ != null ? other.oBFKIDOIJBC_.Clone() : null;
      extraId_ = other.extraId_;
      targetList_ = other.targetList_.Clone();
      messageText_ = other.messageText_;
      messageType_ = other.messageType_;
      chatType_ = other.chatType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq Clone() {
      return new SendMsgCsReq(this);
    }

    /// <summary>Field number for the "OBFKIDOIJBC" field.</summary>
    public const int OBFKIDOIJBCFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.BIENEBCEIOF oBFKIDOIJBC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BIENEBCEIOF OBFKIDOIJBC {
      get { return oBFKIDOIJBC_; }
      set {
        oBFKIDOIJBC_ = value;
      }
    }

    /// <summary>Field number for the "extra_id" field.</summary>
    public const int ExtraIdFieldNumber = 11;
    private uint extraId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraId {
      get { return extraId_; }
      set {
        extraId_ = value;
      }
    }

    /// <summary>Field number for the "target_list" field.</summary>
    public const int TargetListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_targetList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> targetList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetList {
      get { return targetList_; }
    }

    /// <summary>Field number for the "message_text" field.</summary>
    public const int MessageTextFieldNumber = 2;
    private string messageText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageText {
      get { return messageText_; }
      set {
        messageText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.MsgType messageType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "chat_type" field.</summary>
    public const int ChatTypeFieldNumber = 12;
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
      return Equals(other as SendMsgCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendMsgCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OBFKIDOIJBC, other.OBFKIDOIJBC)) return false;
      if (ExtraId != other.ExtraId) return false;
      if(!targetList_.Equals(other.targetList_)) return false;
      if (MessageText != other.MessageText) return false;
      if (MessageType != other.MessageType) return false;
      if (ChatType != other.ChatType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (oBFKIDOIJBC_ != null) hash ^= OBFKIDOIJBC.GetHashCode();
      if (ExtraId != 0) hash ^= ExtraId.GetHashCode();
      hash ^= targetList_.GetHashCode();
      if (MessageText.Length != 0) hash ^= MessageText.GetHashCode();
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MessageType.GetHashCode();
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
      if (MessageText.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageText);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) MessageType);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ExtraId);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ChatType);
      }
      if (oBFKIDOIJBC_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OBFKIDOIJBC);
      }
      targetList_.WriteTo(output, _repeated_targetList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MessageText.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MessageText);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) MessageType);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ExtraId);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ChatType);
      }
      if (oBFKIDOIJBC_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OBFKIDOIJBC);
      }
      targetList_.WriteTo(ref output, _repeated_targetList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (oBFKIDOIJBC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OBFKIDOIJBC);
      }
      if (ExtraId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraId);
      }
      size += targetList_.CalculateSize(_repeated_targetList_codec);
      if (MessageText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageText);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
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
    public void MergeFrom(SendMsgCsReq other) {
      if (other == null) {
        return;
      }
      if (other.oBFKIDOIJBC_ != null) {
        if (oBFKIDOIJBC_ == null) {
          OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
        }
        OBFKIDOIJBC.MergeFrom(other.OBFKIDOIJBC);
      }
      if (other.ExtraId != 0) {
        ExtraId = other.ExtraId;
      }
      targetList_.Add(other.targetList_);
      if (other.MessageText.Length != 0) {
        MessageText = other.MessageText;
      }
      if (other.MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MessageType = other.MessageType;
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
          case 18: {
            MessageText = input.ReadString();
            break;
          }
          case 56: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 88: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 96: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 114: {
            if (oBFKIDOIJBC_ == null) {
              OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
            }
            input.ReadMessage(OBFKIDOIJBC);
            break;
          }
          case 122:
          case 120: {
            targetList_.AddEntriesFrom(input, _repeated_targetList_codec);
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
            MessageText = input.ReadString();
            break;
          }
          case 56: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 88: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 96: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 114: {
            if (oBFKIDOIJBC_ == null) {
              OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
            }
            input.ReadMessage(OBFKIDOIJBC);
            break;
          }
          case 122:
          case 120: {
            targetList_.AddEntriesFrom(ref input, _repeated_targetList_codec);
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
