// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMapRotationDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMapRotationDataScRsp.proto</summary>
  public static partial class GetMapRotationDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMapRotationDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMapRotationDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRNYXBSb3RhdGlvbkRhdGFTY1JzcC5wcm90bxoTUm90YXRlTWFwSW5m",
            "by5wcm90bxoXUm90YXRvckVuZXJneUluZm8ucHJvdG8aEVJvdGF0ZXJEYXRh",
            "LnByb3RvGhFDaGFyZ2VySW5mby5wcm90byL1AQoXR2V0TWFwUm90YXRpb25E",
            "YXRhU2NSc3ASJwoLZW5lcmd5X2luZm8YCyABKAsyEi5Sb3RhdG9yRW5lcmd5",
            "SW5mbxIhCgtMRERCTEJGT0JJTBgCIAMoCzIMLlJvdGF0ZXJEYXRhEiAKCG1h",
            "cF9pbmZvGAMgASgLMg4uUm90YXRlTWFwSW5mbxIQCghyb3RhdGlvbhgBIAEo",
            "BRIRCglpc19yb3RhdGUYBiABKAgSIQoLR0hHRUNDS01GR0sYCCADKAsyDC5D",
            "aGFyZ2VySW5mbxITCgtNTk5IUEpHTE9LTRgJIAEoDRIPCgdyZXRjb2RlGAog",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RotateMapInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotatorEnergyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotaterDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChargerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp), global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp.Parser, new[]{ "EnergyInfo", "LDDBLBFOBIL", "MapInfo", "Rotation", "IsRotate", "GHGECCKMFGK", "MNNHPJGLOKM", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMapRotationDataScRsp : pb::IMessage<GetMapRotationDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMapRotationDataScRsp> _parser = new pb::MessageParser<GetMapRotationDataScRsp>(() => new GetMapRotationDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMapRotationDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMapRotationDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp(GetMapRotationDataScRsp other) : this() {
      energyInfo_ = other.energyInfo_ != null ? other.energyInfo_.Clone() : null;
      lDDBLBFOBIL_ = other.lDDBLBFOBIL_.Clone();
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      rotation_ = other.rotation_;
      isRotate_ = other.isRotate_;
      gHGECCKMFGK_ = other.gHGECCKMFGK_.Clone();
      mNNHPJGLOKM_ = other.mNNHPJGLOKM_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp Clone() {
      return new GetMapRotationDataScRsp(this);
    }

    /// <summary>Field number for the "energy_info" field.</summary>
    public const int EnergyInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RotatorEnergyInfo energyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotatorEnergyInfo EnergyInfo {
      get { return energyInfo_; }
      set {
        energyInfo_ = value;
      }
    }

    /// <summary>Field number for the "LDDBLBFOBIL" field.</summary>
    public const int LDDBLBFOBILFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RotaterData> _repeated_lDDBLBFOBIL_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.RotaterData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> lDDBLBFOBIL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> LDDBLBFOBIL {
      get { return lDDBLBFOBIL_; }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.RotateMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotateMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 1;
    private int rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "is_rotate" field.</summary>
    public const int IsRotateFieldNumber = 6;
    private bool isRotate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRotate {
      get { return isRotate_; }
      set {
        isRotate_ = value;
      }
    }

    /// <summary>Field number for the "GHGECCKMFGK" field.</summary>
    public const int GHGECCKMFGKFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChargerInfo> _repeated_gHGECCKMFGK_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.ChargerInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> gHGECCKMFGK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> GHGECCKMFGK {
      get { return gHGECCKMFGK_; }
    }

    /// <summary>Field number for the "MNNHPJGLOKM" field.</summary>
    public const int MNNHPJGLOKMFieldNumber = 9;
    private uint mNNHPJGLOKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNNHPJGLOKM {
      get { return mNNHPJGLOKM_; }
      set {
        mNNHPJGLOKM_ = value;
      }
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
      return Equals(other as GetMapRotationDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMapRotationDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EnergyInfo, other.EnergyInfo)) return false;
      if(!lDDBLBFOBIL_.Equals(other.lDDBLBFOBIL_)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (Rotation != other.Rotation) return false;
      if (IsRotate != other.IsRotate) return false;
      if(!gHGECCKMFGK_.Equals(other.gHGECCKMFGK_)) return false;
      if (MNNHPJGLOKM != other.MNNHPJGLOKM) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (energyInfo_ != null) hash ^= EnergyInfo.GetHashCode();
      hash ^= lDDBLBFOBIL_.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (Rotation != 0) hash ^= Rotation.GetHashCode();
      if (IsRotate != false) hash ^= IsRotate.GetHashCode();
      hash ^= gHGECCKMFGK_.GetHashCode();
      if (MNNHPJGLOKM != 0) hash ^= MNNHPJGLOKM.GetHashCode();
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
      if (Rotation != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Rotation);
      }
      lDDBLBFOBIL_.WriteTo(output, _repeated_lDDBLBFOBIL_codec);
      if (mapInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MapInfo);
      }
      if (IsRotate != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsRotate);
      }
      gHGECCKMFGK_.WriteTo(output, _repeated_gHGECCKMFGK_codec);
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MNNHPJGLOKM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EnergyInfo);
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
      if (Rotation != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Rotation);
      }
      lDDBLBFOBIL_.WriteTo(ref output, _repeated_lDDBLBFOBIL_codec);
      if (mapInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MapInfo);
      }
      if (IsRotate != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsRotate);
      }
      gHGECCKMFGK_.WriteTo(ref output, _repeated_gHGECCKMFGK_codec);
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MNNHPJGLOKM);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EnergyInfo);
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
      if (energyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnergyInfo);
      }
      size += lDDBLBFOBIL_.CalculateSize(_repeated_lDDBLBFOBIL_codec);
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (Rotation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rotation);
      }
      if (IsRotate != false) {
        size += 1 + 1;
      }
      size += gHGECCKMFGK_.CalculateSize(_repeated_gHGECCKMFGK_codec);
      if (MNNHPJGLOKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNNHPJGLOKM);
      }
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
    public void MergeFrom(GetMapRotationDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.energyInfo_ != null) {
        if (energyInfo_ == null) {
          EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
        }
        EnergyInfo.MergeFrom(other.EnergyInfo);
      }
      lDDBLBFOBIL_.Add(other.lDDBLBFOBIL_);
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.Rotation != 0) {
        Rotation = other.Rotation;
      }
      if (other.IsRotate != false) {
        IsRotate = other.IsRotate;
      }
      gHGECCKMFGK_.Add(other.gHGECCKMFGK_);
      if (other.MNNHPJGLOKM != 0) {
        MNNHPJGLOKM = other.MNNHPJGLOKM;
      }
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
          case 8: {
            Rotation = input.ReadInt32();
            break;
          }
          case 18: {
            lDDBLBFOBIL_.AddEntriesFrom(input, _repeated_lDDBLBFOBIL_codec);
            break;
          }
          case 26: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 48: {
            IsRotate = input.ReadBool();
            break;
          }
          case 66: {
            gHGECCKMFGK_.AddEntriesFrom(input, _repeated_gHGECCKMFGK_codec);
            break;
          }
          case 72: {
            MNNHPJGLOKM = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
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
            Rotation = input.ReadInt32();
            break;
          }
          case 18: {
            lDDBLBFOBIL_.AddEntriesFrom(ref input, _repeated_lDDBLBFOBIL_codec);
            break;
          }
          case 26: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 48: {
            IsRotate = input.ReadBool();
            break;
          }
          case 66: {
            gHGECCKMFGK_.AddEntriesFrom(ref input, _repeated_gHGECCKMFGK_codec);
            break;
          }
          case 72: {
            MNNHPJGLOKM = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
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
