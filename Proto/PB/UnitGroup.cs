//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: UnitGroup.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UnitGroup")]
  public partial class UnitGroup : global::ProtoBuf.IExtensible
  {
    public UnitGroup() {}
    
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
    private int _posId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"posId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int posId
    {
      get { return _posId; }
      set { _posId = value; }
    }
    private int _teamId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"teamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int teamId
    {
      get { return _teamId; }
      set { _teamId = value; }
    }
    private int _heroId = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"heroId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int heroId
    {
      get { return _heroId; }
      set { _heroId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}