//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


// Generated from: gateHandler.proto
namespace pomelo.gate
{
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QueryEntryRequest")]
  public partial class QueryEntryRequest : global::ProtoBuf.IExtensible
  {
    public QueryEntryRequest() {}
    
    
    private string _c2s_uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"c2s_uid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string c2s_uid
    {
      get { return _c2s_uid; }
      set { _c2s_uid = value; }
    }
    
    private string _c2s_sign;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"c2s_sign", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string c2s_sign
    {
      get { return _c2s_sign; }
      set { _c2s_sign = value; }
    }
    
    private string _c2s_time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"c2s_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string c2s_time
    {
      get { return _c2s_time; }
      set { _c2s_time = value; }
    }
    
    private int _c2s_logicServerId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"c2s_logicServerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int c2s_logicServerId
    {
      get { return _c2s_logicServerId; }
      set { _c2s_logicServerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QueryEntryResponse")]
  public partial class QueryEntryResponse : global::ProtoBuf.IExtensible
  {
    public QueryEntryResponse() {}
    
    
    private int _s2c_code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"s2c_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int s2c_code
    {
      get { return _s2c_code; }
      set { _s2c_code = value; }
    }
    
    private string _s2c_msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"s2c_msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string s2c_msg
    {
      get { return _s2c_msg; }
      set { _s2c_msg = value; }
    }
    
    private string _s2c_pubHost = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"s2c_pubHost", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string s2c_pubHost
    {
      get { return _s2c_pubHost; }
      set { _s2c_pubHost = value; }
    }
    
    private int _s2c_port = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"s2c_port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int s2c_port
    {
      get { return _s2c_port; }
      set { _s2c_port = value; }
    }
    
    private string _s2c_token = "";
    /// <summary>
    /// tocken
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"s2c_token", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string s2c_token
    {
      get { return _s2c_token; }
      set { _s2c_token = value; }
    }
    
    private int _s2c_averageTime = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"s2c_averageTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int s2c_averageTime
    {
      get { return _s2c_averageTime; }
      set { _s2c_averageTime = value; }
    }
    
    private int _s2c_pos = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"s2c_pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int s2c_pos
    {
      get { return _s2c_pos; }
      set { _s2c_pos = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
}
  