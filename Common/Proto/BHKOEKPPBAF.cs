// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BHKOEKPPBAF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BHKOEKPPBAF.proto</summary>
  public static partial class BHKOEKPPBAFReflection {

    #region Descriptor
    /// <summary>File descriptor for BHKOEKPPBAF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BHKOEKPPBAFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCSEtPRUtQUEJBRi5wcm90bxoRSEdCRUxGSlBDTEEucHJvdG8aGkRpc3Bs",
            "YXlDaGFsbGVuZ2VJbmZvLnByb3RvGhFGQkFOT01PTkVBRS5wcm90byK/AQoL",
            "QkhLT0VLUFBCQUYSEwoLSU1CT0pCSk5JR1AYDSABKA0SEwoLQVBJTlBETElJ",
            "S0oYBSABKA0SKwoMZGlzcGxheV90eXBlGAcgASgOMhUuRGlzcGxheUNoYWxs",
            "ZW5nZUluZm8SIQoLS0lNRUVHTlBIT0QYASABKAsyDC5IR0JFTEZKUENMQRIT",
            "CgtEQklDUEVGQ01MTxgIIAEoDRIhCgtGR0tDUEVFQU5NQRgMIAEoCzIMLkZC",
            "QU5PTU9ORUFFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HGBELFJPCLAReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayChallengeInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.FBANOMONEAEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BHKOEKPPBAF), global::EggLink.DanhengServer.Proto.BHKOEKPPBAF.Parser, new[]{ "IMBOJBJNIGP", "APINPDLIIKJ", "DisplayType", "KIMEEGNPHOD", "DBICPEFCMLO", "FGKCPEEANMA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BHKOEKPPBAF : pb::IMessage<BHKOEKPPBAF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BHKOEKPPBAF> _parser = new pb::MessageParser<BHKOEKPPBAF>(() => new BHKOEKPPBAF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BHKOEKPPBAF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BHKOEKPPBAFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BHKOEKPPBAF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BHKOEKPPBAF(BHKOEKPPBAF other) : this() {
      iMBOJBJNIGP_ = other.iMBOJBJNIGP_;
      aPINPDLIIKJ_ = other.aPINPDLIIKJ_;
      displayType_ = other.displayType_;
      kIMEEGNPHOD_ = other.kIMEEGNPHOD_ != null ? other.kIMEEGNPHOD_.Clone() : null;
      dBICPEFCMLO_ = other.dBICPEFCMLO_;
      fGKCPEEANMA_ = other.fGKCPEEANMA_ != null ? other.fGKCPEEANMA_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BHKOEKPPBAF Clone() {
      return new BHKOEKPPBAF(this);
    }

    /// <summary>Field number for the "IMBOJBJNIGP" field.</summary>
    public const int IMBOJBJNIGPFieldNumber = 13;
    private uint iMBOJBJNIGP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IMBOJBJNIGP {
      get { return iMBOJBJNIGP_; }
      set {
        iMBOJBJNIGP_ = value;
      }
    }

    /// <summary>Field number for the "APINPDLIIKJ" field.</summary>
    public const int APINPDLIIKJFieldNumber = 5;
    private uint aPINPDLIIKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint APINPDLIIKJ {
      get { return aPINPDLIIKJ_; }
      set {
        aPINPDLIIKJ_ = value;
      }
    }

    /// <summary>Field number for the "display_type" field.</summary>
    public const int DisplayTypeFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.DisplayChallengeInfo displayType_ = global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayChallengeInfo DisplayType {
      get { return displayType_; }
      set {
        displayType_ = value;
      }
    }

    /// <summary>Field number for the "KIMEEGNPHOD" field.</summary>
    public const int KIMEEGNPHODFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.HGBELFJPCLA kIMEEGNPHOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HGBELFJPCLA KIMEEGNPHOD {
      get { return kIMEEGNPHOD_; }
      set {
        kIMEEGNPHOD_ = value;
      }
    }

    /// <summary>Field number for the "DBICPEFCMLO" field.</summary>
    public const int DBICPEFCMLOFieldNumber = 8;
    private uint dBICPEFCMLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DBICPEFCMLO {
      get { return dBICPEFCMLO_; }
      set {
        dBICPEFCMLO_ = value;
      }
    }

    /// <summary>Field number for the "FGKCPEEANMA" field.</summary>
    public const int FGKCPEEANMAFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.FBANOMONEAE fGKCPEEANMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FBANOMONEAE FGKCPEEANMA {
      get { return fGKCPEEANMA_; }
      set {
        fGKCPEEANMA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BHKOEKPPBAF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BHKOEKPPBAF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IMBOJBJNIGP != other.IMBOJBJNIGP) return false;
      if (APINPDLIIKJ != other.APINPDLIIKJ) return false;
      if (DisplayType != other.DisplayType) return false;
      if (!object.Equals(KIMEEGNPHOD, other.KIMEEGNPHOD)) return false;
      if (DBICPEFCMLO != other.DBICPEFCMLO) return false;
      if (!object.Equals(FGKCPEEANMA, other.FGKCPEEANMA)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IMBOJBJNIGP != 0) hash ^= IMBOJBJNIGP.GetHashCode();
      if (APINPDLIIKJ != 0) hash ^= APINPDLIIKJ.GetHashCode();
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) hash ^= DisplayType.GetHashCode();
      if (kIMEEGNPHOD_ != null) hash ^= KIMEEGNPHOD.GetHashCode();
      if (DBICPEFCMLO != 0) hash ^= DBICPEFCMLO.GetHashCode();
      if (fGKCPEEANMA_ != null) hash ^= FGKCPEEANMA.GetHashCode();
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
      if (kIMEEGNPHOD_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(KIMEEGNPHOD);
      }
      if (APINPDLIIKJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(APINPDLIIKJ);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DisplayType);
      }
      if (DBICPEFCMLO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DBICPEFCMLO);
      }
      if (fGKCPEEANMA_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FGKCPEEANMA);
      }
      if (IMBOJBJNIGP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IMBOJBJNIGP);
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
      if (kIMEEGNPHOD_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(KIMEEGNPHOD);
      }
      if (APINPDLIIKJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(APINPDLIIKJ);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DisplayType);
      }
      if (DBICPEFCMLO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DBICPEFCMLO);
      }
      if (fGKCPEEANMA_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FGKCPEEANMA);
      }
      if (IMBOJBJNIGP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IMBOJBJNIGP);
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
      if (IMBOJBJNIGP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IMBOJBJNIGP);
      }
      if (APINPDLIIKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(APINPDLIIKJ);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DisplayType);
      }
      if (kIMEEGNPHOD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KIMEEGNPHOD);
      }
      if (DBICPEFCMLO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DBICPEFCMLO);
      }
      if (fGKCPEEANMA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FGKCPEEANMA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BHKOEKPPBAF other) {
      if (other == null) {
        return;
      }
      if (other.IMBOJBJNIGP != 0) {
        IMBOJBJNIGP = other.IMBOJBJNIGP;
      }
      if (other.APINPDLIIKJ != 0) {
        APINPDLIIKJ = other.APINPDLIIKJ;
      }
      if (other.DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        DisplayType = other.DisplayType;
      }
      if (other.kIMEEGNPHOD_ != null) {
        if (kIMEEGNPHOD_ == null) {
          KIMEEGNPHOD = new global::EggLink.DanhengServer.Proto.HGBELFJPCLA();
        }
        KIMEEGNPHOD.MergeFrom(other.KIMEEGNPHOD);
      }
      if (other.DBICPEFCMLO != 0) {
        DBICPEFCMLO = other.DBICPEFCMLO;
      }
      if (other.fGKCPEEANMA_ != null) {
        if (fGKCPEEANMA_ == null) {
          FGKCPEEANMA = new global::EggLink.DanhengServer.Proto.FBANOMONEAE();
        }
        FGKCPEEANMA.MergeFrom(other.FGKCPEEANMA);
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
          case 10: {
            if (kIMEEGNPHOD_ == null) {
              KIMEEGNPHOD = new global::EggLink.DanhengServer.Proto.HGBELFJPCLA();
            }
            input.ReadMessage(KIMEEGNPHOD);
            break;
          }
          case 40: {
            APINPDLIIKJ = input.ReadUInt32();
            break;
          }
          case 56: {
            DisplayType = (global::EggLink.DanhengServer.Proto.DisplayChallengeInfo) input.ReadEnum();
            break;
          }
          case 64: {
            DBICPEFCMLO = input.ReadUInt32();
            break;
          }
          case 98: {
            if (fGKCPEEANMA_ == null) {
              FGKCPEEANMA = new global::EggLink.DanhengServer.Proto.FBANOMONEAE();
            }
            input.ReadMessage(FGKCPEEANMA);
            break;
          }
          case 104: {
            IMBOJBJNIGP = input.ReadUInt32();
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
          case 10: {
            if (kIMEEGNPHOD_ == null) {
              KIMEEGNPHOD = new global::EggLink.DanhengServer.Proto.HGBELFJPCLA();
            }
            input.ReadMessage(KIMEEGNPHOD);
            break;
          }
          case 40: {
            APINPDLIIKJ = input.ReadUInt32();
            break;
          }
          case 56: {
            DisplayType = (global::EggLink.DanhengServer.Proto.DisplayChallengeInfo) input.ReadEnum();
            break;
          }
          case 64: {
            DBICPEFCMLO = input.ReadUInt32();
            break;
          }
          case 98: {
            if (fGKCPEEANMA_ == null) {
              FGKCPEEANMA = new global::EggLink.DanhengServer.Proto.FBANOMONEAE();
            }
            input.ReadMessage(FGKCPEEANMA);
            break;
          }
          case 104: {
            IMBOJBJNIGP = input.ReadUInt32();
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
