//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Task.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Task")]
  public partial class Task : global::ProtoBuf.IExtensible
  {
    public Task() {}
    
    private int _taskId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"taskId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int taskId
    {
      get { return _taskId; }
      set { _taskId = value; }
    }
    private int _progress = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int progress
    {
      get { return _progress; }
      set { _progress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}