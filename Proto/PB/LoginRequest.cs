//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LoginRequest.proto
// Note: requires additional types generated from: ApiRequest.proto
namespace SlgPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginRequest")]
  public partial class LoginRequest : global::ProtoBuf.IExtensible
  {
    public LoginRequest() {}
    
    private ApiRequest _api = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"api", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ApiRequest api
    {
      get { return _api; }
      set { _api = value; }
    }
    private string _userName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"userName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string userName
    {
      get { return _userName; }
      set { _userName = value; }
    }
    private int _headPicId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"headPicId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int headPicId
    {
      get { return _headPicId; }
      set { _headPicId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}