// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FANDGHKMBNL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FANDGHKMBNL.proto</summary>
  public static partial class FANDGHKMBNLReflection {

    #region Descriptor
    /// <summary>File descriptor for FANDGHKMBNL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FANDGHKMBNLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGQU5ER0hLTUJOTC5wcm90bxoRQ0xESk1IREVMSE4ucHJvdG8aHlB1bmtM",
            "b3JkQmF0dGxlUmVjb3JkTGlzdC5wcm90bxocUHVua0xvcmRBdHRhY2tlclN0",
            "YXR1cy5wcm90byKiAQoLRkFOREdIS01CTkwSEwoLRVBQSEhDUEZMTkMYBiAB",
            "KA0SLgoLTUROTE1NQU1FSkQYCCABKAsyGS5QdW5rTG9yZEJhdHRsZVJlY29y",
            "ZExpc3QSIAoKYmFzaWNfaW5mbxgMIAEoCzIMLkNMREpNSERFTEhOEiwKC05C",
            "RUpFTUlPT05JGAEgASgOMhcuUHVua0xvcmRBdHRhY2tlclN0YXR1c0IeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CLDJMHDELHNReflection.Descriptor, global::EggLink.DanhengServer.Proto.PunkLordBattleRecordListReflection.Descriptor, global::EggLink.DanhengServer.Proto.PunkLordAttackerStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FANDGHKMBNL), global::EggLink.DanhengServer.Proto.FANDGHKMBNL.Parser, new[]{ "EPPHHCPFLNC", "MDNLMMAMEJD", "BasicInfo", "NBEJEMIOONI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FANDGHKMBNL : pb::IMessage<FANDGHKMBNL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FANDGHKMBNL> _parser = new pb::MessageParser<FANDGHKMBNL>(() => new FANDGHKMBNL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FANDGHKMBNL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FANDGHKMBNLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FANDGHKMBNL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FANDGHKMBNL(FANDGHKMBNL other) : this() {
      ePPHHCPFLNC_ = other.ePPHHCPFLNC_;
      mDNLMMAMEJD_ = other.mDNLMMAMEJD_ != null ? other.mDNLMMAMEJD_.Clone() : null;
      basicInfo_ = other.basicInfo_ != null ? other.basicInfo_.Clone() : null;
      nBEJEMIOONI_ = other.nBEJEMIOONI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FANDGHKMBNL Clone() {
      return new FANDGHKMBNL(this);
    }

    /// <summary>Field number for the "EPPHHCPFLNC" field.</summary>
    public const int EPPHHCPFLNCFieldNumber = 6;
    private uint ePPHHCPFLNC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EPPHHCPFLNC {
      get { return ePPHHCPFLNC_; }
      set {
        ePPHHCPFLNC_ = value;
      }
    }

    /// <summary>Field number for the "MDNLMMAMEJD" field.</summary>
    public const int MDNLMMAMEJDFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.PunkLordBattleRecordList mDNLMMAMEJD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordBattleRecordList MDNLMMAMEJD {
      get { return mDNLMMAMEJD_; }
      set {
        mDNLMMAMEJD_ = value;
      }
    }

    /// <summary>Field number for the "basic_info" field.</summary>
    public const int BasicInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.CLDJMHDELHN basicInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CLDJMHDELHN BasicInfo {
      get { return basicInfo_; }
      set {
        basicInfo_ = value;
      }
    }

    /// <summary>Field number for the "NBEJEMIOONI" field.</summary>
    public const int NBEJEMIOONIFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus nBEJEMIOONI_ = global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus NBEJEMIOONI {
      get { return nBEJEMIOONI_; }
      set {
        nBEJEMIOONI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FANDGHKMBNL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FANDGHKMBNL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EPPHHCPFLNC != other.EPPHHCPFLNC) return false;
      if (!object.Equals(MDNLMMAMEJD, other.MDNLMMAMEJD)) return false;
      if (!object.Equals(BasicInfo, other.BasicInfo)) return false;
      if (NBEJEMIOONI != other.NBEJEMIOONI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EPPHHCPFLNC != 0) hash ^= EPPHHCPFLNC.GetHashCode();
      if (mDNLMMAMEJD_ != null) hash ^= MDNLMMAMEJD.GetHashCode();
      if (basicInfo_ != null) hash ^= BasicInfo.GetHashCode();
      if (NBEJEMIOONI != global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None) hash ^= NBEJEMIOONI.GetHashCode();
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
      if (NBEJEMIOONI != global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NBEJEMIOONI);
      }
      if (EPPHHCPFLNC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EPPHHCPFLNC);
      }
      if (mDNLMMAMEJD_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MDNLMMAMEJD);
      }
      if (basicInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BasicInfo);
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
      if (NBEJEMIOONI != global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NBEJEMIOONI);
      }
      if (EPPHHCPFLNC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EPPHHCPFLNC);
      }
      if (mDNLMMAMEJD_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MDNLMMAMEJD);
      }
      if (basicInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(BasicInfo);
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
      if (EPPHHCPFLNC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EPPHHCPFLNC);
      }
      if (mDNLMMAMEJD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MDNLMMAMEJD);
      }
      if (basicInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BasicInfo);
      }
      if (NBEJEMIOONI != global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NBEJEMIOONI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FANDGHKMBNL other) {
      if (other == null) {
        return;
      }
      if (other.EPPHHCPFLNC != 0) {
        EPPHHCPFLNC = other.EPPHHCPFLNC;
      }
      if (other.mDNLMMAMEJD_ != null) {
        if (mDNLMMAMEJD_ == null) {
          MDNLMMAMEJD = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecordList();
        }
        MDNLMMAMEJD.MergeFrom(other.MDNLMMAMEJD);
      }
      if (other.basicInfo_ != null) {
        if (basicInfo_ == null) {
          BasicInfo = new global::EggLink.DanhengServer.Proto.CLDJMHDELHN();
        }
        BasicInfo.MergeFrom(other.BasicInfo);
      }
      if (other.NBEJEMIOONI != global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus.None) {
        NBEJEMIOONI = other.NBEJEMIOONI;
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
            NBEJEMIOONI = (global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus) input.ReadEnum();
            break;
          }
          case 48: {
            EPPHHCPFLNC = input.ReadUInt32();
            break;
          }
          case 66: {
            if (mDNLMMAMEJD_ == null) {
              MDNLMMAMEJD = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecordList();
            }
            input.ReadMessage(MDNLMMAMEJD);
            break;
          }
          case 98: {
            if (basicInfo_ == null) {
              BasicInfo = new global::EggLink.DanhengServer.Proto.CLDJMHDELHN();
            }
            input.ReadMessage(BasicInfo);
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
            NBEJEMIOONI = (global::EggLink.DanhengServer.Proto.PunkLordAttackerStatus) input.ReadEnum();
            break;
          }
          case 48: {
            EPPHHCPFLNC = input.ReadUInt32();
            break;
          }
          case 66: {
            if (mDNLMMAMEJD_ == null) {
              MDNLMMAMEJD = new global::EggLink.DanhengServer.Proto.PunkLordBattleRecordList();
            }
            input.ReadMessage(MDNLMMAMEJD);
            break;
          }
          case 98: {
            if (basicInfo_ == null) {
              BasicInfo = new global::EggLink.DanhengServer.Proto.CLDJMHDELHN();
            }
            input.ReadMessage(BasicInfo);
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
