//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OrganizationPropertiesToUpdate.proto
// Note: requires additional types generated from: Address.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StringValue")]
  public partial class StringValue : global::ProtoBuf.IExtensible
  {
    public StringValue() {}
    

    private string _Value = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Value
    {
      get { return _Value; }
      set { _Value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrganizationPropertiesToUpdate")]
  public partial class OrganizationPropertiesToUpdate : global::ProtoBuf.IExtensible
  {
    public OrganizationPropertiesToUpdate() {}
    
    private string _OrgId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"OrgId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OrgId
    {
      get { return _OrgId; }
      set { _OrgId = value; }
    }

    private Diadoc.Api.Proto.StringValue _Ogrn = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Ogrn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.StringValue Ogrn
    {
      get { return _Ogrn; }
      set { _Ogrn = value; }
    }

    private Diadoc.Api.Proto.StringValue _IfnsCode = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IfnsCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.StringValue IfnsCode
    {
      get { return _IfnsCode; }
      set { _IfnsCode = value; }
    }

    private Diadoc.Api.Proto.Address _Address = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Address Address
    {
      get { return _Address; }
      set { _Address = value; }
    }

    private Diadoc.Api.Proto.HeadOrganizationPropertiesToUpdate _HeadOrganizationProperties = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"HeadOrganizationProperties", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.HeadOrganizationPropertiesToUpdate HeadOrganizationProperties
    {
      get { return _HeadOrganizationProperties; }
      set { _HeadOrganizationProperties = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeadOrganizationPropertiesToUpdate")]
  public partial class HeadOrganizationPropertiesToUpdate : global::ProtoBuf.IExtensible
  {
    public HeadOrganizationPropertiesToUpdate() {}
    

    private Diadoc.Api.Proto.StringValue _Kpp = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.StringValue Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }

    private Diadoc.Api.Proto.StringValue _FullName = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"FullName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.StringValue FullName
    {
      get { return _FullName; }
      set { _FullName = value; }
    }

    private Diadoc.Api.Proto.Address _Address = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Address Address
    {
      get { return _Address; }
      set { _Address = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}