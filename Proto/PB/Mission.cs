//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Mission.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Mission")]
  public partial class Mission : global::ProtoBuf.IExtensible
  {
    public Mission() {}
    
    private int _missonId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"missonId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int missonId
    {
      get { return _missonId; }
      set { _missonId = value; }
    }
    private int _star = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private int _remainFightNum = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"remainFightNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int remainFightNum
    {
      get { return _remainFightNum; }
      set { _remainFightNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}