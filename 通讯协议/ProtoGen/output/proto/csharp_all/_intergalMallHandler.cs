//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ***************************************************************************
// * 用途= 积分商城
// ***************************************************************************

// Generated from: intergalMallHandler.proto
namespace pomelo.area
{
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IntergalMallItem")]
  public partial class IntergalMallItem : global::ProtoBuf.IExtensible
  {
    public IntergalMallItem() {}
    
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    
    private string _code;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    
    private int _lastcount = default(int);
    /// <summary>
    /// 剩余数量: -1:无限制
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"lastcount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lastcount
    {
      get { return _lastcount; }
      set { _lastcount = value; }
    }
    
    private long _countdown = default(long);
    /// <summary>
    /// 倒计时
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"countdown", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long countdown
    {
      get { return _countdown; }
      set { _countdown = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IntergalMallTab")]
  public partial class IntergalMallTab : global::ProtoBuf.IExtensible
  {
    public IntergalMallTab() {}
    
    
    private int _tabId;
    /// <summary>
    /// 商城标签ID
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"tabId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tabId
    {
      get { return _tabId; }
      set { _tabId = value; }
    }
    
    private readonly global::System.Collections.Generic.List<pomelo.area.IntergalMallItem> _items = new global::System.Collections.Generic.List<pomelo.area.IntergalMallItem>();
    /// <summary>
    /// 商城物品
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(2, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.area.IntergalMallItem> items
    {
      get { return _items; }
    }
  
    
    private int _currencyNum = default(int);
    /// <summary>
    /// 货币数量
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"currencyNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int currencyNum
    {
      get { return _currencyNum; }
      set { _currencyNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetIntergalMallListRequest")]
  public partial class GetIntergalMallListRequest : global::ProtoBuf.IExtensible
  {
    public GetIntergalMallListRequest() {}
    
    
    private int _c2s_type = default(int);
    /// <summary>
    /// 商店类型, -1表示全部
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"c2s_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int c2s_type
    {
      get { return _c2s_type; }
      set { _c2s_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetIntergalMallListResponse")]
  public partial class GetIntergalMallListResponse : global::ProtoBuf.IExtensible
  {
    public GetIntergalMallListResponse() {}
    
    
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
    
    private readonly global::System.Collections.Generic.List<pomelo.area.IntergalMallTab> _s2c_tabitems = new global::System.Collections.Generic.List<pomelo.area.IntergalMallTab>();
    [global::ProtoBuf.ProtoMember(3, Name=@"s2c_tabitems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.area.IntergalMallTab> s2c_tabitems
    {
      get { return _s2c_tabitems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyIntergalItemRequest")]
  public partial class BuyIntergalItemRequest : global::ProtoBuf.IExtensible
  {
    public BuyIntergalItemRequest() {}
    
    
    private int _c2s_type = default(int);
    /// <summary>
    /// 商店类型, -1表示全部
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"c2s_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int c2s_type
    {
      get { return _c2s_type; }
      set { _c2s_type = value; }
    }
    
    private int _c2s_itemId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"c2s_itemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int c2s_itemId
    {
      get { return _c2s_itemId; }
      set { _c2s_itemId = value; }
    }
    
    private int _c2s_num = default(int);
    /// <summary>
    /// 购买数量
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"c2s_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int c2s_num
    {
      get { return _c2s_num; }
      set { _c2s_num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyIntergalItemResponse")]
  public partial class BuyIntergalItemResponse : global::ProtoBuf.IExtensible
  {
    public BuyIntergalItemResponse() {}
    
    
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
    
    private int _lastcount = default(int);
    /// <summary>
    /// 限购商品剩余数量 -1无限制
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"lastcount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lastcount
    {
      get { return _lastcount; }
      set { _lastcount = value; }
    }
    
    private int _currencyNum = default(int);
    /// <summary>
    /// 货币数量
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"currencyNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int currencyNum
    {
      get { return _currencyNum; }
      set { _currencyNum = value; }
    }
    
    private int _total_num = default(int);
    /// <summary>
    /// 当前物品总数量
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"total_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int total_num
    {
      get { return _total_num; }
      set { _total_num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
}
  