//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ***************************************************************************
// * 作者: jjr
// * 创建时间: 2017-08-24
// * 用途: 果园
// ***************************************************************************/

// Generated from: farmHandler.proto
// Note: requires additional types generated from: farm.proto
namespace pomelo.farm
{
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 我的果园信息
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MyFarmInfoRequest")]
  public partial class MyFarmInfoRequest : global::ProtoBuf.IExtensible
  {
    public MyFarmInfoRequest() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MyFarmInfoResponse")]
  public partial class MyFarmInfoResponse : global::ProtoBuf.IExtensible
  {
    public MyFarmInfoResponse() {}
    
    
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
    
    private pomelo.farm.PlayerInfo _playerInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playerInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public pomelo.farm.PlayerInfo playerInfo
    {
      get { return _playerInfo; }
      set { _playerInfo = value; }
    }
    
    private readonly global::System.Collections.Generic.List<pomelo.farm.Seed> _seedLs = new global::System.Collections.Generic.List<pomelo.farm.Seed>();
    /// <summary>
    /// 种子列表
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(4, Name=@"seedLs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.farm.Seed> seedLs
    {
      get { return _seedLs; }
    }
  
    
    private readonly global::System.Collections.Generic.List<pomelo.farm.Product> _productLs = new global::System.Collections.Generic.List<pomelo.farm.Product>();
    /// <summary>
    /// 果实列表
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(5, Name=@"productLs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.farm.Product> productLs
    {
      get { return _productLs; }
    }
  
    
    private int _exp = default(int);
    /// <summary>
    /// 农场经验
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    
    private readonly global::System.Collections.Generic.List<pomelo.farm.RecordInfo> _recordInfoLs = new global::System.Collections.Generic.List<pomelo.farm.RecordInfo>();
    /// <summary>
    /// 果园记录
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(7, Name=@"recordInfoLs", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.farm.RecordInfo> recordInfoLs
    {
      get { return _recordInfoLs; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 好友果园信息
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendFarmInfoRequest")]
  public partial class FriendFarmInfoRequest : global::ProtoBuf.IExtensible
  {
    public FriendFarmInfoRequest() {}
    
    
    private string _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendFarmInfoResponse")]
  public partial class FriendFarmInfoResponse : global::ProtoBuf.IExtensible
  {
    public FriendFarmInfoResponse() {}
    
    
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
    
    private pomelo.farm.PlayerInfo _playerInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playerInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public pomelo.farm.PlayerInfo playerInfo
    {
      get { return _playerInfo; }
      set { _playerInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 好友列表
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendLsRequest")]
  public partial class FriendLsRequest : global::ProtoBuf.IExtensible
  {
    public FriendLsRequest() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendLsResponse")]
  public partial class FriendLsResponse : global::ProtoBuf.IExtensible
  {
    public FriendLsResponse() {}
    
    
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
    
    private readonly global::System.Collections.Generic.List<pomelo.farm.PlayerSummary> _playerSummary = new global::System.Collections.Generic.List<pomelo.farm.PlayerSummary>();
    /// <summary>
    /// 好友摘要列表
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, Name=@"playerSummary", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<pomelo.farm.PlayerSummary> playerSummary
    {
      get { return _playerSummary; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 开垦请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenRequest")]
  public partial class OpenRequest : global::ProtoBuf.IExtensible
  {
    public OpenRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 田块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 开垦返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenResponse")]
  public partial class OpenResponse : global::ProtoBuf.IExtensible
  {
    public OpenResponse() {}
    
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 播种请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SowRequest")]
  public partial class SowRequest : global::ProtoBuf.IExtensible
  {
    public SowRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 地块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    
    private string _seedCode;
    /// <summary>
    /// 作物代码
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"seedCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string seedCode
    {
      get { return _seedCode; }
      set { _seedCode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 播种返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SowResponse")]
  public partial class SowResponse : global::ProtoBuf.IExtensible
  {
    public SowResponse() {}
    
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 培育好友请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CultivateFriendRequest")]
  public partial class CultivateFriendRequest : global::ProtoBuf.IExtensible
  {
    public CultivateFriendRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 地块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    
    private int _cultivateType;
    /// <summary>
    /// 操作种类
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"cultivateType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cultivateType
    {
      get { return _cultivateType; }
      set { _cultivateType = value; }
    }
    
    private string _friendId = "";
    /// <summary>
    /// 好友id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"friendId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string friendId
    {
      get { return _friendId; }
      set { _friendId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 培育好友返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CultivateFriendResponse")]
  public partial class CultivateFriendResponse : global::ProtoBuf.IExtensible
  {
    public CultivateFriendResponse() {}
    
    
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
    
    private int _fate = default(int);
    /// <summary>
    /// 获取的仙缘值
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"fate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int fate
    {
      get { return _fate; }
      set { _fate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 培育自己请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CultivateSelfRequest")]
  public partial class CultivateSelfRequest : global::ProtoBuf.IExtensible
  {
    public CultivateSelfRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 地块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    
    private int _cultivateType;
    /// <summary>
    /// 操作种类
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"cultivateType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cultivateType
    {
      get { return _cultivateType; }
      set { _cultivateType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 培育自己返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CultivateSelfResponse")]
  public partial class CultivateSelfResponse : global::ProtoBuf.IExtensible
  {
    public CultivateSelfResponse() {}
    
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 收获请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HarvestRequest")]
  public partial class HarvestRequest : global::ProtoBuf.IExtensible
  {
    public HarvestRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 地块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 收获返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HarvestResponse")]
  public partial class HarvestResponse : global::ProtoBuf.IExtensible
  {
    public HarvestResponse() {}
    
    
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
    
    private int _exp = default(int);
    /// <summary>
    /// 收获后的果园经验
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    
    private int _lv = default(int);
    /// <summary>
    /// 收获后的果园等级
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }
    
    private pomelo.farm.Block _block = null;
    /// <summary>
    /// 收获后的地块状态
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"block", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public pomelo.farm.Block block
    {
      get { return _block; }
      set { _block = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 好友偷取请求
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StealRequest")]
  public partial class StealRequest : global::ProtoBuf.IExtensible
  {
    public StealRequest() {}
    
    
    private int _blockId;
    /// <summary>
    /// 地块id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"blockId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int blockId
    {
      get { return _blockId; }
      set { _blockId = value; }
    }
    
    private string _friendId;
    /// <summary>
    /// 好友id
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"friendId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string friendId
    {
      get { return _friendId; }
      set { _friendId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 好友偷取返回
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StealResponse")]
  public partial class StealResponse : global::ProtoBuf.IExtensible
  {
    public StealResponse() {}
    
    
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
    
    private string _productCode = "";
    /// <summary>
    /// 作物代码
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"productCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string productCode
    {
      get { return _productCode; }
      set { _productCode = value; }
    }
    
    private int _num = default(int);
    /// <summary>
    /// 偷取到的数量
    /// </summary>
    
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 获取商店信息
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetShopInfoRequest")]
  public partial class GetShopInfoRequest : global::ProtoBuf.IExtensible
  {
    public GetShopInfoRequest() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetShopInfoResponse")]
  public partial class GetShopInfoResponse : global::ProtoBuf.IExtensible
  {
    public GetShopInfoResponse() {}
    
    
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
    
    private pomelo.farm.ShopItemInfo _shopItemInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"shopItemInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public pomelo.farm.ShopItemInfo shopItemInfo
    {
      get { return _shopItemInfo; }
      set { _shopItemInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  /// <summary>
  /// 兑换商店商品
  /// </summary>
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChangeShopItemRequest")]
  public partial class ChangeShopItemRequest : global::ProtoBuf.IExtensible
  {
    public ChangeShopItemRequest() {}
    
    
    private int _itemId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"itemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int itemId
    {
      get { return _itemId; }
      set { _itemId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
  //---------------------------------------------------------------------------------------
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChangeShopItemResponse")]
  public partial class ChangeShopItemResponse : global::ProtoBuf.IExtensible
  {
    public ChangeShopItemResponse() {}
    
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  
}
  