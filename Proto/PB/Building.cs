//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Building.proto
// Note: requires additional types generated from: Production.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Building")]
  public partial class Building : global::ProtoBuf.IExtensible
  {
    public Building() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private Production _production = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"production", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Production production
    {
      get { return _production; }
      set { _production = value; }
    }
    private int _unlockedNextLevel = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"unlockedNextLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int unlockedNextLevel
    {
      get { return _unlockedNextLevel; }
      set { _unlockedNextLevel = value; }
    }
    private int _upgrading = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"upgrading", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int upgrading
    {
      get { return _upgrading; }
      set { _upgrading = value; }
    }
    private int _endToUpgrade = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"endToUpgrade", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int endToUpgrade
    {
      get { return _endToUpgrade; }
      set { _endToUpgrade = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}