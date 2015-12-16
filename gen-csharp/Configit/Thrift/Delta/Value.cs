/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Configit.Thrift.Delta
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class @Value : TBase
  {
    private bool _Bool;
    private sbyte _Byte;
    private short _Int16;
    private int _Int32;
    private long _Int64;
    private double _Double;
    private byte[] _Binary;
    private string _String;
    private byte[] _Object;

    public bool Bool
    {
      get
      {
        return _Bool;
      }
      set
      {
        __isset.@Bool = true;
        this._Bool = value;
      }
    }

    public sbyte Byte
    {
      get
      {
        return _Byte;
      }
      set
      {
        __isset.@Byte = true;
        this._Byte = value;
      }
    }

    public short Int16
    {
      get
      {
        return _Int16;
      }
      set
      {
        __isset.Int16 = true;
        this._Int16 = value;
      }
    }

    public int Int32
    {
      get
      {
        return _Int32;
      }
      set
      {
        __isset.Int32 = true;
        this._Int32 = value;
      }
    }

    public long Int64
    {
      get
      {
        return _Int64;
      }
      set
      {
        __isset.Int64 = true;
        this._Int64 = value;
      }
    }

    public double Double
    {
      get
      {
        return _Double;
      }
      set
      {
        __isset.@Double = true;
        this._Double = value;
      }
    }

    public byte[] Binary
    {
      get
      {
        return _Binary;
      }
      set
      {
        __isset.Binary = true;
        this._Binary = value;
      }
    }

    public string String
    {
      get
      {
        return _String;
      }
      set
      {
        __isset.@String = true;
        this._String = value;
      }
    }

    public byte[] Object
    {
      get
      {
        return _Object;
      }
      set
      {
        __isset.@Object = true;
        this._Object = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool @Bool;
      public bool @Byte;
      public bool Int16;
      public bool Int32;
      public bool Int64;
      public bool @Double;
      public bool Binary;
      public bool @String;
      public bool @Object;
    }

    public @Value() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Bool) {
              Bool = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Byte = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Int16 = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Int32 = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              Int64 = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Double) {
              Double = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              Binary = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              String = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              Object = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Value");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.@Bool) {
        field.Name = "Bool";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Bool);
        oprot.WriteFieldEnd();
      }
      if (__isset.@Byte) {
        field.Name = "Byte";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Byte);
        oprot.WriteFieldEnd();
      }
      if (__isset.Int16) {
        field.Name = "Int16";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Int16);
        oprot.WriteFieldEnd();
      }
      if (__isset.Int32) {
        field.Name = "Int32";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Int32);
        oprot.WriteFieldEnd();
      }
      if (__isset.Int64) {
        field.Name = "Int64";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Int64);
        oprot.WriteFieldEnd();
      }
      if (__isset.@Double) {
        field.Name = "Double";
        field.Type = TType.Double;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Double);
        oprot.WriteFieldEnd();
      }
      if (Binary != null && __isset.Binary) {
        field.Name = "Binary";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Binary);
        oprot.WriteFieldEnd();
      }
      if (String != null && __isset.@String) {
        field.Name = "String";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(String);
        oprot.WriteFieldEnd();
      }
      if (Object != null && __isset.@Object) {
        field.Name = "Object";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Object);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Value(");
      bool __first = true;
      if (__isset.@Bool) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Bool: ");
        __sb.Append(Bool);
      }
      if (__isset.@Byte) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Byte: ");
        __sb.Append(Byte);
      }
      if (__isset.Int16) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Int16: ");
        __sb.Append(Int16);
      }
      if (__isset.Int32) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Int32: ");
        __sb.Append(Int32);
      }
      if (__isset.Int64) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Int64: ");
        __sb.Append(Int64);
      }
      if (__isset.@Double) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Double: ");
        __sb.Append(Double);
      }
      if (Binary != null && __isset.Binary) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Binary: ");
        __sb.Append(Binary);
      }
      if (String != null && __isset.@String) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("String: ");
        __sb.Append(String);
      }
      if (Object != null && __isset.@Object) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Object: ");
        __sb.Append(Object);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
