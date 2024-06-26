// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MazeGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MazeGroup.proto</summary>
  public static partial class MazeGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for MazeGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MazeGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9NYXplR3JvdXAucHJvdG8iXAoJTWF6ZUdyb3VwEhMKC21vZGlmeV90aW1l",
            "GA4gASgDEhAKCGdyb3VwX2lkGAggASgNEhMKC05EQ0RDQU1BREJIGAUgASgI",
            "EhMKC0lMQkpFQkdBTkROGA8gAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MazeGroup), global::EggLink.DanhengServer.Proto.MazeGroup.Parser, new[]{ "ModifyTime", "GroupId", "NDCDCAMADBH", "ILBJEBGANDN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MazeGroup : pb::IMessage<MazeGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MazeGroup> _parser = new pb::MessageParser<MazeGroup>(() => new MazeGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MazeGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MazeGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeGroup(MazeGroup other) : this() {
      modifyTime_ = other.modifyTime_;
      groupId_ = other.groupId_;
      nDCDCAMADBH_ = other.nDCDCAMADBH_;
      iLBJEBGANDN_ = other.iLBJEBGANDN_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeGroup Clone() {
      return new MazeGroup(this);
    }

    /// <summary>Field number for the "modify_time" field.</summary>
    public const int ModifyTimeFieldNumber = 14;
    private long modifyTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ModifyTime {
      get { return modifyTime_; }
      set {
        modifyTime_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 8;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "NDCDCAMADBH" field.</summary>
    public const int NDCDCAMADBHFieldNumber = 5;
    private bool nDCDCAMADBH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NDCDCAMADBH {
      get { return nDCDCAMADBH_; }
      set {
        nDCDCAMADBH_ = value;
      }
    }

    /// <summary>Field number for the "ILBJEBGANDN" field.</summary>
    public const int ILBJEBGANDNFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_iLBJEBGANDN_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> iLBJEBGANDN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ILBJEBGANDN {
      get { return iLBJEBGANDN_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MazeGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MazeGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifyTime != other.ModifyTime) return false;
      if (GroupId != other.GroupId) return false;
      if (NDCDCAMADBH != other.NDCDCAMADBH) return false;
      if(!iLBJEBGANDN_.Equals(other.iLBJEBGANDN_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModifyTime != 0L) hash ^= ModifyTime.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (NDCDCAMADBH != false) hash ^= NDCDCAMADBH.GetHashCode();
      hash ^= iLBJEBGANDN_.GetHashCode();
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
      if (NDCDCAMADBH != false) {
        output.WriteRawTag(40);
        output.WriteBool(NDCDCAMADBH);
      }
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (ModifyTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(ModifyTime);
      }
      iLBJEBGANDN_.WriteTo(output, _repeated_iLBJEBGANDN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (NDCDCAMADBH != false) {
        output.WriteRawTag(40);
        output.WriteBool(NDCDCAMADBH);
      }
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (ModifyTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(ModifyTime);
      }
      iLBJEBGANDN_.WriteTo(ref output, _repeated_iLBJEBGANDN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ModifyTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ModifyTime);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (NDCDCAMADBH != false) {
        size += 1 + 1;
      }
      size += iLBJEBGANDN_.CalculateSize(_repeated_iLBJEBGANDN_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MazeGroup other) {
      if (other == null) {
        return;
      }
      if (other.ModifyTime != 0L) {
        ModifyTime = other.ModifyTime;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.NDCDCAMADBH != false) {
        NDCDCAMADBH = other.NDCDCAMADBH;
      }
      iLBJEBGANDN_.Add(other.iLBJEBGANDN_);
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
          case 40: {
            NDCDCAMADBH = input.ReadBool();
            break;
          }
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 112: {
            ModifyTime = input.ReadInt64();
            break;
          }
          case 122:
          case 120: {
            iLBJEBGANDN_.AddEntriesFrom(input, _repeated_iLBJEBGANDN_codec);
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
          case 40: {
            NDCDCAMADBH = input.ReadBool();
            break;
          }
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 112: {
            ModifyTime = input.ReadInt64();
            break;
          }
          case 122:
          case 120: {
            iLBJEBGANDN_.AddEntriesFrom(ref input, _repeated_iLBJEBGANDN_codec);
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
