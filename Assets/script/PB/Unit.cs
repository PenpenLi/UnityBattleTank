//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Unit.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Unit")]
  public partial class Unit : global::ProtoBuf.IExtensible
  {
    public Unit() {}
    
    private int _unitId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private int _num = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private int _onProduce = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"onProduce", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int onProduce
    {
      get { return _onProduce; }
      set { _onProduce = value; }
    }
    private int _produceEndTime = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"produceEndTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int produceEndTime
    {
      get { return _produceEndTime; }
      set { _produceEndTime = value; }
    }
    private int _produceTotalTime = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"produceTotalTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int produceTotalTime
    {
      get { return _produceTotalTime; }
      set { _produceTotalTime = value; }
    }
    private int _onRepair = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"onRepair", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int onRepair
    {
      get { return _onRepair; }
      set { _onRepair = value; }
    }
    private int _onDamaged = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"onDamaged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int onDamaged
    {
      get { return _onDamaged; }
      set { _onDamaged = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _unitPartLevel = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(8, Name=@"unitPartLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> unitPartLevel
    {
      get { return _unitPartLevel; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}