//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GetShopResponse.proto
// Note: requires additional types generated from: ApiResponse.proto
// Note: requires additional types generated from: ShopItem.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetShopResponse")]
  public partial class GetShopResponse : global::ProtoBuf.IExtensible
  {
    public GetShopResponse() {}
    
    private ApiResponse _response = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiResponse response
    {
      get { return _response; }
      set { _response = value; }
    }
    private readonly global::System.Collections.Generic.List<ShopItem> _shopItems = new global::System.Collections.Generic.List<ShopItem>();
    [global::ProtoBuf.ProtoMember(2, Name=@"shopItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ShopItem> shopItems
    {
      get { return _shopItems; }
    }
  
    private int _refreshPrice = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"refreshPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int refreshPrice
    {
      get { return _refreshPrice; }
      set { _refreshPrice = value; }
    }
    private int _refreshPriceType = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"refreshPriceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int refreshPriceType
    {
      get { return _refreshPriceType; }
      set { _refreshPriceType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}