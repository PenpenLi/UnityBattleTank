//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ComposeUnitResponse.proto
// Note: requires additional types generated from: ApiResponse.proto
// Note: requires additional types generated from: Unit.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ComposeUnitResponse")]
  public partial class ComposeUnitResponse : global::ProtoBuf.IExtensible
  {
    public ComposeUnitResponse() {}
    
    private ApiResponse _response = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiResponse response
    {
      get { return _response; }
      set { _response = value; }
    }
    private Unit _unit = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Unit unit
    {
      get { return _unit; }
      set { _unit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}