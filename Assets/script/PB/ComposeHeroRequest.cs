//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ComposeHeroRequest.proto
// Note: requires additional types generated from: ApiRequest.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ComposeHeroRequest")]
  public partial class ComposeHeroRequest : global::ProtoBuf.IExtensible
  {
    public ComposeHeroRequest() {}
    
    private ApiRequest _api = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"api", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiRequest api
    {
      get { return _api; }
      set { _api = value; }
    }
    private int _heroId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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