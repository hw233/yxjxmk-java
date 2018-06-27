/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pomelo.DotNetClient;
using pomelo.area;
using pomelo.revelry;
using pomelo.auction;
using pomelo.chat;
using pomelo.daoyou;
using pomelo.connector;
using pomelo.farm;
using pomelo.five2five;
using pomelo.guild;
using pomelo.xianyuan;

namespace Pomelo.DotNetClient
{
	public class GameSocket : PomeloClient
	{
		private AchievementHandler _achievementHandler;
		private ActivityHandler _activityHandler;
		private ActivityFavorHandler _activityFavorHandler;
		private AmuletHandler _amuletHandler;
		private ArenaHandler _arenaHandler;
		private AttendanceHandler _attendanceHandler;
		private BagHandler _bagHandler;
		private BattleHandler _battleHandler;
		private CardHandler _cardHandler;
		private ConsignmentLineHandler _consignmentLineHandler;
		private CrossServerHandler _crossServerHandler;
		private DailyActivityHandler _dailyActivityHandler;
		private DemonTowerHandler _demonTowerHandler;
		private EquipHandler _equipHandler;
		private ExchangeHandler _exchangeHandler;
		private FashionHandler _fashionHandler;
		private FightLevelHandler _fightLevelHandler;
		private FleeHandler _fleeHandler;
		private FriendHandler _friendHandler;
		private FunctionHandler _functionHandler;
		private FunctionOpenHandler _functionOpenHandler;
		private GiftOnlineHandler _giftOnlineHandler;
		private GoddessHandler _goddessHandler;
		private GuildBlessHandler _guildBlessHandler;
		private GuildBossHandler _guildBossHandler;
		private GuildDepotHandler _guildDepotHandler;
		private GuildHandler _guildHandler;
		private GuildShopHandler _guildShopHandler;
		private GuildTechHandler _guildTechHandler;
		private HookSetHandler _hookSetHandler;
		private InteractHandler _interactHandler;
		private IntergalMallHandler _intergalMallHandler;
		private ItemHandler _itemHandler;
		private LeaderBoardHandler _leaderBoardHandler;
		private LimitTimeActivityHandler _limitTimeActivityHandler;
		private MailHandler _mailHandler;
		private MapHandler _mapHandler;
		private MasteryHandler _masteryHandler;
		private MedalHandler _medalHandler;
		private MessageHandler _messageHandler;
		private MountHandler _mountHandler;
		private NpcHandler _npcHandler;
		private OfflineAwardHandler _offlineAwardHandler;
		private OnlineGiftHandler _onlineGiftHandler;
		private PayGiftHandler _payGiftHandler;
		private PetHandler _petHandler;
		private PetNewHandler _petNewHandler;
		private PlayerHandler _playerHandler;
		private PrepaidHandler _prepaidHandler;
		private RankHandler _rankHandler;
		private ResourceDungeonHandler _resourceDungeonHandler;
		private ResourceHandler _resourceHandler;
		private RewardHandler _rewardHandler;
		private SaleHandler _saleHandler;
		private ShopMallHandler _shopMallHandler;
		private SkillHandler _skillHandler;
		private SkillKeysHandler _skillKeysHandler;
		private SoloHandler _soloHandler;
		private StealHandler _stealHandler;
		private SysSetHandler _sysSetHandler;
		private TaskHandler _taskHandler;
		private TeamHandler _teamHandler;
		private TradeHandler _tradeHandler;
		private TreasureHandler _treasureHandler;
		private UpLevelHandler _upLevelHandler;
		private VipHandler _vipHandler;
		private VitalityHandler _vitalityHandler;
		private WingHandler _wingHandler;
		private ActivityRevelryHandler _activityRevelryHandler;
		private AuctionHandler _auctionHandler;
		private ChatHandler _chatHandler;
		private DaoYouHandler _daoYouHandler;
		private EntryHandler _entryHandler;
		private RoleHandler _roleHandler;
		private FarmHandler _farmHandler;
		private Five2FiveHandler _five2FiveHandler;
		private GuildManagerHandler _guildManagerHandler;
		private XianYuanHandler _xianYuanHandler;

		public AchievementHandler achievementHandler
		{
			get { return _achievementHandler;}
			set { _achievementHandler = value; }
		}

		public ActivityHandler activityHandler
		{
			get { return _activityHandler;}
			set { _activityHandler = value; }
		}

		public ActivityFavorHandler activityFavorHandler
		{
			get { return _activityFavorHandler;}
			set { _activityFavorHandler = value; }
		}

		public AmuletHandler amuletHandler
		{
			get { return _amuletHandler;}
			set { _amuletHandler = value; }
		}

		public ArenaHandler arenaHandler
		{
			get { return _arenaHandler;}
			set { _arenaHandler = value; }
		}

		public AttendanceHandler attendanceHandler
		{
			get { return _attendanceHandler;}
			set { _attendanceHandler = value; }
		}

		public BagHandler bagHandler
		{
			get { return _bagHandler;}
			set { _bagHandler = value; }
		}

		public BattleHandler battleHandler
		{
			get { return _battleHandler;}
			set { _battleHandler = value; }
		}

		public CardHandler cardHandler
		{
			get { return _cardHandler;}
			set { _cardHandler = value; }
		}

		public ConsignmentLineHandler consignmentLineHandler
		{
			get { return _consignmentLineHandler;}
			set { _consignmentLineHandler = value; }
		}

		public CrossServerHandler crossServerHandler
		{
			get { return _crossServerHandler;}
			set { _crossServerHandler = value; }
		}

		public DailyActivityHandler dailyActivityHandler
		{
			get { return _dailyActivityHandler;}
			set { _dailyActivityHandler = value; }
		}

		public DemonTowerHandler demonTowerHandler
		{
			get { return _demonTowerHandler;}
			set { _demonTowerHandler = value; }
		}

		public EquipHandler equipHandler
		{
			get { return _equipHandler;}
			set { _equipHandler = value; }
		}

		public ExchangeHandler exchangeHandler
		{
			get { return _exchangeHandler;}
			set { _exchangeHandler = value; }
		}

		public FashionHandler fashionHandler
		{
			get { return _fashionHandler;}
			set { _fashionHandler = value; }
		}

		public FightLevelHandler fightLevelHandler
		{
			get { return _fightLevelHandler;}
			set { _fightLevelHandler = value; }
		}

		public FleeHandler fleeHandler
		{
			get { return _fleeHandler;}
			set { _fleeHandler = value; }
		}

		public FriendHandler friendHandler
		{
			get { return _friendHandler;}
			set { _friendHandler = value; }
		}

		public FunctionHandler functionHandler
		{
			get { return _functionHandler;}
			set { _functionHandler = value; }
		}

		public FunctionOpenHandler functionOpenHandler
		{
			get { return _functionOpenHandler;}
			set { _functionOpenHandler = value; }
		}

		public GiftOnlineHandler giftOnlineHandler
		{
			get { return _giftOnlineHandler;}
			set { _giftOnlineHandler = value; }
		}

		public GoddessHandler goddessHandler
		{
			get { return _goddessHandler;}
			set { _goddessHandler = value; }
		}

		public GuildBlessHandler guildBlessHandler
		{
			get { return _guildBlessHandler;}
			set { _guildBlessHandler = value; }
		}

		public GuildBossHandler guildBossHandler
		{
			get { return _guildBossHandler;}
			set { _guildBossHandler = value; }
		}

		public GuildDepotHandler guildDepotHandler
		{
			get { return _guildDepotHandler;}
			set { _guildDepotHandler = value; }
		}

		public GuildHandler guildHandler
		{
			get { return _guildHandler;}
			set { _guildHandler = value; }
		}

		public GuildShopHandler guildShopHandler
		{
			get { return _guildShopHandler;}
			set { _guildShopHandler = value; }
		}

		public GuildTechHandler guildTechHandler
		{
			get { return _guildTechHandler;}
			set { _guildTechHandler = value; }
		}

		public HookSetHandler hookSetHandler
		{
			get { return _hookSetHandler;}
			set { _hookSetHandler = value; }
		}

		public InteractHandler interactHandler
		{
			get { return _interactHandler;}
			set { _interactHandler = value; }
		}

		public IntergalMallHandler intergalMallHandler
		{
			get { return _intergalMallHandler;}
			set { _intergalMallHandler = value; }
		}

		public ItemHandler itemHandler
		{
			get { return _itemHandler;}
			set { _itemHandler = value; }
		}

		public LeaderBoardHandler leaderBoardHandler
		{
			get { return _leaderBoardHandler;}
			set { _leaderBoardHandler = value; }
		}

		public LimitTimeActivityHandler limitTimeActivityHandler
		{
			get { return _limitTimeActivityHandler;}
			set { _limitTimeActivityHandler = value; }
		}

		public MailHandler mailHandler
		{
			get { return _mailHandler;}
			set { _mailHandler = value; }
		}

		public MapHandler mapHandler
		{
			get { return _mapHandler;}
			set { _mapHandler = value; }
		}

		public MasteryHandler masteryHandler
		{
			get { return _masteryHandler;}
			set { _masteryHandler = value; }
		}

		public MedalHandler medalHandler
		{
			get { return _medalHandler;}
			set { _medalHandler = value; }
		}

		public MessageHandler messageHandler
		{
			get { return _messageHandler;}
			set { _messageHandler = value; }
		}

		public MountHandler mountHandler
		{
			get { return _mountHandler;}
			set { _mountHandler = value; }
		}

		public NpcHandler npcHandler
		{
			get { return _npcHandler;}
			set { _npcHandler = value; }
		}

		public OfflineAwardHandler offlineAwardHandler
		{
			get { return _offlineAwardHandler;}
			set { _offlineAwardHandler = value; }
		}

		public OnlineGiftHandler onlineGiftHandler
		{
			get { return _onlineGiftHandler;}
			set { _onlineGiftHandler = value; }
		}

		public PayGiftHandler payGiftHandler
		{
			get { return _payGiftHandler;}
			set { _payGiftHandler = value; }
		}

		public PetHandler petHandler
		{
			get { return _petHandler;}
			set { _petHandler = value; }
		}

		public PetNewHandler petNewHandler
		{
			get { return _petNewHandler;}
			set { _petNewHandler = value; }
		}

		public PlayerHandler playerHandler
		{
			get { return _playerHandler;}
			set { _playerHandler = value; }
		}

		public PrepaidHandler prepaidHandler
		{
			get { return _prepaidHandler;}
			set { _prepaidHandler = value; }
		}

		public RankHandler rankHandler
		{
			get { return _rankHandler;}
			set { _rankHandler = value; }
		}

		public ResourceDungeonHandler resourceDungeonHandler
		{
			get { return _resourceDungeonHandler;}
			set { _resourceDungeonHandler = value; }
		}

		public ResourceHandler resourceHandler
		{
			get { return _resourceHandler;}
			set { _resourceHandler = value; }
		}

		public RewardHandler rewardHandler
		{
			get { return _rewardHandler;}
			set { _rewardHandler = value; }
		}

		public SaleHandler saleHandler
		{
			get { return _saleHandler;}
			set { _saleHandler = value; }
		}

		public ShopMallHandler shopMallHandler
		{
			get { return _shopMallHandler;}
			set { _shopMallHandler = value; }
		}

		public SkillHandler skillHandler
		{
			get { return _skillHandler;}
			set { _skillHandler = value; }
		}

		public SkillKeysHandler skillKeysHandler
		{
			get { return _skillKeysHandler;}
			set { _skillKeysHandler = value; }
		}

		public SoloHandler soloHandler
		{
			get { return _soloHandler;}
			set { _soloHandler = value; }
		}

		public StealHandler stealHandler
		{
			get { return _stealHandler;}
			set { _stealHandler = value; }
		}

		public SysSetHandler sysSetHandler
		{
			get { return _sysSetHandler;}
			set { _sysSetHandler = value; }
		}

		public TaskHandler taskHandler
		{
			get { return _taskHandler;}
			set { _taskHandler = value; }
		}

		public TeamHandler teamHandler
		{
			get { return _teamHandler;}
			set { _teamHandler = value; }
		}

		public TradeHandler tradeHandler
		{
			get { return _tradeHandler;}
			set { _tradeHandler = value; }
		}

		public TreasureHandler treasureHandler
		{
			get { return _treasureHandler;}
			set { _treasureHandler = value; }
		}

		public UpLevelHandler upLevelHandler
		{
			get { return _upLevelHandler;}
			set { _upLevelHandler = value; }
		}

		public VipHandler vipHandler
		{
			get { return _vipHandler;}
			set { _vipHandler = value; }
		}

		public VitalityHandler vitalityHandler
		{
			get { return _vitalityHandler;}
			set { _vitalityHandler = value; }
		}

		public WingHandler wingHandler
		{
			get { return _wingHandler;}
			set { _wingHandler = value; }
		}

		public ActivityRevelryHandler activityRevelryHandler
		{
			get { return _activityRevelryHandler;}
			set { _activityRevelryHandler = value; }
		}

		public AuctionHandler auctionHandler
		{
			get { return _auctionHandler;}
			set { _auctionHandler = value; }
		}

		public ChatHandler chatHandler
		{
			get { return _chatHandler;}
			set { _chatHandler = value; }
		}

		public DaoYouHandler daoYouHandler
		{
			get { return _daoYouHandler;}
			set { _daoYouHandler = value; }
		}

		public EntryHandler entryHandler
		{
			get { return _entryHandler;}
			set { _entryHandler = value; }
		}

		public RoleHandler roleHandler
		{
			get { return _roleHandler;}
			set { _roleHandler = value; }
		}

		public FarmHandler farmHandler
		{
			get { return _farmHandler;}
			set { _farmHandler = value; }
		}

		public Five2FiveHandler five2FiveHandler
		{
			get { return _five2FiveHandler;}
			set { _five2FiveHandler = value; }
		}

		public GuildManagerHandler guildManagerHandler
		{
			get { return _guildManagerHandler;}
			set { _guildManagerHandler = value; }
		}

		public XianYuanHandler xianYuanHandler
		{
			get { return _xianYuanHandler;}
			set { _xianYuanHandler = value; }
		}

		public GameSocket(ISerializer serializer) : base(serializer)
		{
			_achievementHandler = new AchievementHandler(this);
			_activityHandler = new ActivityHandler(this);
			_activityFavorHandler = new ActivityFavorHandler(this);
			_amuletHandler = new AmuletHandler(this);
			_arenaHandler = new ArenaHandler(this);
			_attendanceHandler = new AttendanceHandler(this);
			_bagHandler = new BagHandler(this);
			_battleHandler = new BattleHandler(this);
			_cardHandler = new CardHandler(this);
			_consignmentLineHandler = new ConsignmentLineHandler(this);
			_crossServerHandler = new CrossServerHandler(this);
			_dailyActivityHandler = new DailyActivityHandler(this);
			_demonTowerHandler = new DemonTowerHandler(this);
			_equipHandler = new EquipHandler(this);
			_exchangeHandler = new ExchangeHandler(this);
			_fashionHandler = new FashionHandler(this);
			_fightLevelHandler = new FightLevelHandler(this);
			_fleeHandler = new FleeHandler(this);
			_friendHandler = new FriendHandler(this);
			_functionHandler = new FunctionHandler(this);
			_functionOpenHandler = new FunctionOpenHandler(this);
			_giftOnlineHandler = new GiftOnlineHandler(this);
			_goddessHandler = new GoddessHandler(this);
			_guildBlessHandler = new GuildBlessHandler(this);
			_guildBossHandler = new GuildBossHandler(this);
			_guildDepotHandler = new GuildDepotHandler(this);
			_guildHandler = new GuildHandler(this);
			_guildShopHandler = new GuildShopHandler(this);
			_guildTechHandler = new GuildTechHandler(this);
			_hookSetHandler = new HookSetHandler(this);
			_interactHandler = new InteractHandler(this);
			_intergalMallHandler = new IntergalMallHandler(this);
			_itemHandler = new ItemHandler(this);
			_leaderBoardHandler = new LeaderBoardHandler(this);
			_limitTimeActivityHandler = new LimitTimeActivityHandler(this);
			_mailHandler = new MailHandler(this);
			_mapHandler = new MapHandler(this);
			_masteryHandler = new MasteryHandler(this);
			_medalHandler = new MedalHandler(this);
			_messageHandler = new MessageHandler(this);
			_mountHandler = new MountHandler(this);
			_npcHandler = new NpcHandler(this);
			_offlineAwardHandler = new OfflineAwardHandler(this);
			_onlineGiftHandler = new OnlineGiftHandler(this);
			_payGiftHandler = new PayGiftHandler(this);
			_petHandler = new PetHandler(this);
			_petNewHandler = new PetNewHandler(this);
			_playerHandler = new PlayerHandler(this);
			_prepaidHandler = new PrepaidHandler(this);
			_rankHandler = new RankHandler(this);
			_resourceDungeonHandler = new ResourceDungeonHandler(this);
			_resourceHandler = new ResourceHandler(this);
			_rewardHandler = new RewardHandler(this);
			_saleHandler = new SaleHandler(this);
			_shopMallHandler = new ShopMallHandler(this);
			_skillHandler = new SkillHandler(this);
			_skillKeysHandler = new SkillKeysHandler(this);
			_soloHandler = new SoloHandler(this);
			_stealHandler = new StealHandler(this);
			_sysSetHandler = new SysSetHandler(this);
			_taskHandler = new TaskHandler(this);
			_teamHandler = new TeamHandler(this);
			_tradeHandler = new TradeHandler(this);
			_treasureHandler = new TreasureHandler(this);
			_upLevelHandler = new UpLevelHandler(this);
			_vipHandler = new VipHandler(this);
			_vitalityHandler = new VitalityHandler(this);
			_wingHandler = new WingHandler(this);
			_activityRevelryHandler = new ActivityRevelryHandler(this);
			_auctionHandler = new AuctionHandler(this);
			_chatHandler = new ChatHandler(this);
			_daoYouHandler = new DaoYouHandler(this);
			_entryHandler = new EntryHandler(this);
			_roleHandler = new RoleHandler(this);
			_farmHandler = new FarmHandler(this);
			_five2FiveHandler = new Five2FiveHandler(this);
			_guildManagerHandler = new GuildManagerHandler(this);
			_xianYuanHandler = new XianYuanHandler(this);

		}
		public void onAchievementPush(Action<OnAchievementPush> cb)
		{
			_achievementHandler.onAchievementPush(cb);

		}
		public void onSuperPackageBuyPush(Action<SuperPackageBuyPush> cb)
		{
			_activityFavorHandler.onSuperPackageBuyPush(cb);

		}
		public void onAmuletEquipNewPush(Action<AmuletEquipNewPush> cb)
		{
			_amuletHandler.onAmuletEquipNewPush(cb);

		}
		public void onArenaBattleInfoPush(Action<OnArenaBattleInfoPush> cb)
		{
			_arenaHandler.onArenaBattleInfoPush(cb);

		}
		public void onArenaBattleEndPush(Action<OnArenaBattleEndPush> cb)
		{
			_arenaHandler.onArenaBattleEndPush(cb);

		}
		public void onLuxuryRewardPush(Action<LuxuryRewardPush> cb)
		{
			_attendanceHandler.onLuxuryRewardPush(cb);

		}
		public void onBagItemUpdatePush(Action<BagItemUpdatePush> cb)
		{
			_bagHandler.onBagItemUpdatePush(cb);

		}
		public void onBagNewItemPush(Action<BagNewItemPush> cb)
		{
			_bagHandler.onBagNewItemPush(cb);

		}
		public void onBagNewEquipPush(Action<BagNewEquipPush> cb)
		{
			_bagHandler.onBagNewEquipPush(cb);

		}
		public void onBagGridFullPush(Action<BagGridFullPush> cb)
		{
			_bagHandler.onBagGridFullPush(cb);

		}
		public void onBagGridNumPush(Action<BagGridNumPush> cb)
		{
			_bagHandler.onBagGridNumPush(cb);

		}
		public void onThrowPointItemListPush(Action<ThrowPointItemListPush> cb)
		{
			_battleHandler.onThrowPointItemListPush(cb);

		}
		public void onThrowPointResultPush(Action<ThrowPointResultPush> cb)
		{
			_battleHandler.onThrowPointResultPush(cb);

		}
		public void onFightLevelResultPush(Action<FightLevelResultPush> cb)
		{
			_battleHandler.onFightLevelResultPush(cb);

		}
		public void onItemDropPush(Action<ItemDropPush> cb)
		{
			_battleHandler.onItemDropPush(cb);

		}
		public void onSceneNamePush(Action<SceneNamePush> cb)
		{
			_battleHandler.onSceneNamePush(cb);

		}
		public void onResourceDungeonResultPush(Action<ResourceDungeonResultPush> cb)
		{
			_battleHandler.onResourceDungeonResultPush(cb);

		}
		public void onConsignmentRemovePush(Action<ConsignmentRemovePush> cb)
		{
			_consignmentLineHandler.onConsignmentRemovePush(cb);

		}
		public void onTreasureOpenPush(Action<TreasureOpenPush> cb)
		{
			_crossServerHandler.onTreasureOpenPush(cb);

		}
		public void onUpdateActivityPush(Action<UpdateActivityPush> cb)
		{
			_dailyActivityHandler.onUpdateActivityPush(cb);

		}
		public void onSweepDemonTowerEndPush(Action<SweepDemonTowerEndPush> cb)
		{
			_demonTowerHandler.onSweepDemonTowerEndPush(cb);

		}
		public void onEquipmentSimplePush(Action<EquipmentSimplePush> cb)
		{
			_equipHandler.onEquipmentSimplePush(cb);

		}
		public void onEquipInheritPush(Action<EquipInheritPush> cb)
		{
			_equipHandler.onEquipInheritPush(cb);

		}
		public void onEquipStrengthPosPush(Action<StrengthPosPush> cb)
		{
			_equipHandler.onEquipStrengthPosPush(cb);

		}
		public void onFashionGetPush(Action<FashionGetPush> cb)
		{
			_fashionHandler.onFashionGetPush(cb);

		}
		public void onConfirmEnterFubenPush(Action<OnConfirmEnterFubenPush> cb)
		{
			_fightLevelHandler.onConfirmEnterFubenPush(cb);

		}
		public void onMemberEnterFubenStateChangePush(Action<OnMemberEnterFubenStateChangePush> cb)
		{
			_fightLevelHandler.onMemberEnterFubenStateChangePush(cb);

		}
		public void onFubenClosePush(Action<OnFubenClosePush> cb)
		{
			_fightLevelHandler.onFubenClosePush(cb);

		}
		public void onCloseHandUpPush(Action<CloseHandUpPush> cb)
		{
			_fightLevelHandler.onCloseHandUpPush(cb);

		}
		public void onIllusionPush(Action<IllusionPush> cb)
		{
			_fightLevelHandler.onIllusionPush(cb);

		}
		public void onIllusion2Push(Action<Illusion2Push> cb)
		{
			_fightLevelHandler.onIllusion2Push(cb);

		}
		public void onFleeDeathPush(Action<OnFleeDeathPush> cb)
		{
			_fleeHandler.onFleeDeathPush(cb);

		}
		public void onFleeEndPush(Action<OnFleeEndPush> cb)
		{
			_fleeHandler.onFleeEndPush(cb);

		}
		public void onFunctionGoToPush(Action<FunctionGoToPush> cb)
		{
			_functionHandler.onFunctionGoToPush(cb);

		}
		public void onTaskGuideFuncPush(Action<TaskGuideFuncPush> cb)
		{
			_functionHandler.onTaskGuideFuncPush(cb);

		}
		public void onFunctionOpenListPush(Action<FunctionOpenListPush> cb)
		{
			_functionOpenHandler.onFunctionOpenListPush(cb);

		}
		public void onFunctionAwardListPush(Action<FunctionAwardListPush> cb)
		{
			_functionOpenHandler.onFunctionAwardListPush(cb);

		}
		public void onGoddessEquipDynamicPush(Action<GoddessEquipDynamicPush> cb)
		{
			_goddessHandler.onGoddessEquipDynamicPush(cb);

		}
		public void onGoddessGiftDynamicPush(Action<GoddessGiftDynamicPush> cb)
		{
			_goddessHandler.onGoddessGiftDynamicPush(cb);

		}
		public void onBlessRefreshPush(Action<BlessRefreshPush> cb)
		{
			_guildBlessHandler.onBlessRefreshPush(cb);

		}
		public void onHurtRankChangePush(Action<OnHurtRankChangePush> cb)
		{
			_guildBossHandler.onHurtRankChangePush(cb);

		}
		public void onInspireSingleChangePush(Action<OnInspireSingleChangePush> cb)
		{
			_guildBossHandler.onInspireSingleChangePush(cb);

		}
		public void onInspireGuildChangePush(Action<OnInspireGuildChangePush> cb)
		{
			_guildBossHandler.onInspireGuildChangePush(cb);

		}
		public void onGuildBossOverPush(Action<OnGuildBossOverPush> cb)
		{
			_guildBossHandler.onGuildBossOverPush(cb);

		}
		public void onQuitGuildBossPush(Action<OnQuitGuildBossPush> cb)
		{
			_guildBossHandler.onQuitGuildBossPush(cb);

		}
		public void onDepotRefreshPush(Action<DepotRefreshPush> cb)
		{
			_guildDepotHandler.onDepotRefreshPush(cb);

		}
		public void onGuildRefreshPush(Action<GuildRefreshPush> cb)
		{
			_guildHandler.onGuildRefreshPush(cb);

		}
		public void onGuildInvitePush(Action<GuildInvitePush> cb)
		{
			_guildHandler.onGuildInvitePush(cb);

		}
		public void onDungeonEndPush(Action<OnDungeonEndPush> cb)
		{
			_guildHandler.onDungeonEndPush(cb);

		}
		public void onGuildDungeonOpenPush(Action<GuildDungeonOpenPush> cb)
		{
			_guildHandler.onGuildDungeonOpenPush(cb);

		}
		public void onGuildDungeonPassPush(Action<GuildDungeonPassPush> cb)
		{
			_guildHandler.onGuildDungeonPassPush(cb);

		}
		public void onGuildDungeonPlayerNumPush(Action<GuildDungeonPlayerNumPush> cb)
		{
			_guildHandler.onGuildDungeonPlayerNumPush(cb);

		}
		public void onShopRefreshPush(Action<ShopRefreshPush> cb)
		{
			_guildShopHandler.onShopRefreshPush(cb);

		}
		public void onGuildTechRefreshPush(Action<GuildTechRefreshPush> cb)
		{
			_guildTechHandler.onGuildTechRefreshPush(cb);

		}
		public void onReceiveInteractPush(Action<ReceiveInteractPush> cb)
		{
			_interactHandler.onReceiveInteractPush(cb);

		}
		public void onFishItemPush(Action<FishItemPush> cb)
		{
			_itemHandler.onFishItemPush(cb);

		}
		public void onCountItemChangePush(Action<CountItemChangePush> cb)
		{
			_itemHandler.onCountItemChangePush(cb);

		}
		public void onItemDetailPush(Action<ItemDetailPush> cb)
		{
			_itemHandler.onItemDetailPush(cb);

		}
		public void onRewardItemPush(Action<RewardItemPush> cb)
		{
			_itemHandler.onRewardItemPush(cb);

		}
		public void onLtActivityInfoPush(Action<LTActivityInfoPush> cb)
		{
			_limitTimeActivityHandler.onLtActivityInfoPush(cb);

		}
		public void onGetMailPush(Action<OnGetMailPush> cb)
		{
			_mailHandler.onGetMailPush(cb);

		}
		public void onMedalTitleChangePush(Action<MedalTitleChangePush> cb)
		{
			_medalHandler.onMedalTitleChangePush(cb);

		}
		public void onMessageAddPush(Action<OnMessageAddPush> cb)
		{
			_messageHandler.onMessageAddPush(cb);

		}
		public void onMountFlagPush(Action<MountFlagPush> cb)
		{
			_mountHandler.onMountFlagPush(cb);

		}
		public void onMountNewSkinPush(Action<MountNewSkinPush> cb)
		{
			_mountHandler.onMountNewSkinPush(cb);

		}
		public void onGiftInfoPush(Action<GiftInfoPush> cb)
		{
			_onlineGiftHandler.onGiftInfoPush(cb);

		}
		public void onPetDetailPush(Action<OnPetDetailPush> cb)
		{
			_petHandler.onPetDetailPush(cb);

		}
		public void onPetExpPush(Action<OnPetExpPush> cb)
		{
			_petHandler.onPetExpPush(cb);

		}
		public void onNewPetDetailPush(Action<OnNewPetDetailPush> cb)
		{
			_petNewHandler.onNewPetDetailPush(cb);

		}
		public void onPetExpUpdatePush(Action<PetExpUpdatePush> cb)
		{
			_petNewHandler.onPetExpUpdatePush(cb);

		}
		public void onPetInfoUpdatePush(Action<PetInfoUpdatePush> cb)
		{
			_petNewHandler.onPetInfoUpdatePush(cb);

		}
		public void onClientConfigPush(Action<ClientConfigPush> cb)
		{
			_playerHandler.onClientConfigPush(cb);

		}
		public void onBattleEventPush(Action<BattleEventPush> cb)
		{
			_playerHandler.onBattleEventPush(cb);

		}
		public void onBattleClearPush(Action<BattleClearPush> cb)
		{
			_playerHandler.onBattleClearPush(cb);

		}
		public void onSuperScriptPush(Action<SuperScriptPush> cb)
		{
			_playerHandler.onSuperScriptPush(cb);

		}
		public void onChangeAreaPush(Action<ChangeAreaPush> cb)
		{
			_playerHandler.onChangeAreaPush(cb);

		}
		public void onPlayerDynamicPush(Action<PlayerDynamicPush> cb)
		{
			_playerHandler.onPlayerDynamicPush(cb);

		}
		public void onPlayerRelivePush(Action<PlayerRelivePush> cb)
		{
			_playerHandler.onPlayerRelivePush(cb);

		}
		public void onPlayerSaverRebirthPush(Action<PlayerSaverRebirthPush> cb)
		{
			_playerHandler.onPlayerSaverRebirthPush(cb);

		}
		public void onSimulateDropPush(Action<SimulateDataPush> cb)
		{
			_playerHandler.onSimulateDropPush(cb);

		}
		public void onKickPlayerPush(Action<KickPlayerPush> cb)
		{
			_playerHandler.onKickPlayerPush(cb);

		}
		public void onSuitPropertyUpPush(Action<SuitPropertyUpPush> cb)
		{
			_playerHandler.onSuitPropertyUpPush(cb);

		}
		public void onCommonPropertyPush(Action<CommonPropertyPush> cb)
		{
			_playerHandler.onCommonPropertyPush(cb);

		}
		public void onBuffPropertyPush(Action<BuffPropertyPush> cb)
		{
			_playerHandler.onBuffPropertyPush(cb);

		}
		public void onPlayerBattleAttributePush(Action<PlayerBattleAttributePush> cb)
		{
			_playerHandler.onPlayerBattleAttributePush(cb);

		}
		public void onPayGiftStatePush(Action<PayGiftStatePush> cb)
		{
			_playerHandler.onPayGiftStatePush(cb);

		}
		public void onAwardRankPush(Action<OnAwardRankPush> cb)
		{
			_rankHandler.onAwardRankPush(cb);

		}
		public void onSkillUpdatePush(Action<SkillUpdatePush> cb)
		{
			_skillHandler.onSkillUpdatePush(cb);

		}
		public void onSkillKeyUpdatePush(Action<SkillKeyUpdatePush> cb)
		{
			_skillKeysHandler.onSkillKeyUpdatePush(cb);

		}
		public void onSoloMatchedPush(Action<OnSoloMatchedPush> cb)
		{
			_soloHandler.onSoloMatchedPush(cb);

		}
		public void onNewRewardPush(Action<OnNewRewardPush> cb)
		{
			_soloHandler.onNewRewardPush(cb);

		}
		public void onFightPointPush(Action<OnFightPointPush> cb)
		{
			_soloHandler.onFightPointPush(cb);

		}
		public void onRoundEndPush(Action<OnRoundEndPush> cb)
		{
			_soloHandler.onRoundEndPush(cb);

		}
		public void onGameEndPush(Action<OnGameEndPush> cb)
		{
			_soloHandler.onGameEndPush(cb);

		}
		public void onLeftSoloTimePush(Action<LeftSoloTimePush> cb)
		{
			_soloHandler.onLeftSoloTimePush(cb);

		}
		public void onCancelMatchPush(Action<CancelMatchPush> cb)
		{
			_soloHandler.onCancelMatchPush(cb);

		}
		public void onTaskUpdatePush(Action<TaskUpdatePush> cb)
		{
			_taskHandler.onTaskUpdatePush(cb);

		}
		public void onTaskAutoPush(Action<TaskAutoPush> cb)
		{
			_taskHandler.onTaskAutoPush(cb);

		}
		public void onTreasureScenePointPush(Action<TreasureScenePointPush> cb)
		{
			_taskHandler.onTreasureScenePointPush(cb);

		}
		public void onLoopResultPush(Action<LoopResultPush> cb)
		{
			_taskHandler.onLoopResultPush(cb);

		}
		public void onSummonTeamPush(Action<OnSummonTeamPush> cb)
		{
			_teamHandler.onSummonTeamPush(cb);

		}
		public void onTeamUpdatePush(Action<OnTeamUpdatePush> cb)
		{
			_teamHandler.onTeamUpdatePush(cb);

		}
		public void onTeamMemberUpdatePush(Action<OnTeamMemberUpdatePush> cb)
		{
			_teamHandler.onTeamMemberUpdatePush(cb);

		}
		public void onTeamTargetPush(Action<OnTeamTargetPush> cb)
		{
			_teamHandler.onTeamTargetPush(cb);

		}
		public void onAcrossTeamInfoPush(Action<OnAcrossTeamInfoPush> cb)
		{
			_teamHandler.onAcrossTeamInfoPush(cb);

		}
		public void onTradeBeginPush(Action<TradeBeginPush> cb)
		{
			_tradeHandler.onTradeBeginPush(cb);

		}
		public void onTradeItemChangePush(Action<TradeItemChangePush> cb)
		{
			_tradeHandler.onTradeItemChangePush(cb);

		}
		public void onTradeOperatePush(Action<TradeOperatePush> cb)
		{
			_tradeHandler.onTradeOperatePush(cb);

		}
		public void onAuctionItemPush(Action<AuctionItemPush> cb)
		{
			_auctionHandler.onAuctionItemPush(cb);

		}
		public void onAddAuctionItemPush(Action<AddAuctionItemPush> cb)
		{
			_auctionHandler.onAddAuctionItemPush(cb);

		}
		public void onRemoveAuctionItemPush(Action<RemoveAuctionItemPush> cb)
		{
			_auctionHandler.onRemoveAuctionItemPush(cb);

		}
		public void onChatPush(Action<OnChatPush> cb)
		{
			_chatHandler.onChatPush(cb);

		}
		public void onChatErrorPush(Action<OnChatErrorPush> cb)
		{
			_chatHandler.onChatErrorPush(cb);

		}
		public void onTipPush(Action<TipPush> cb)
		{
			_chatHandler.onTipPush(cb);

		}
		public void onLoginQueuePush(Action<LoginQueuePush> cb)
		{
			_entryHandler.onLoginQueuePush(cb);

		}
		public void onFive2FiveApplyMatchPush(Action<Five2FiveApplyMatchPush> cb)
		{
			_five2FiveHandler.onFive2FiveApplyMatchPush(cb);

		}
		public void onFive2FiveMatchMemberInfoPush(Action<Five2FiveMatchMemberInfoPush> cb)
		{
			_five2FiveHandler.onFive2FiveMatchMemberInfoPush(cb);

		}
		public void onFive2FiveMemberChoicePush(Action<Five2FiveMemberChoicePush> cb)
		{
			_five2FiveHandler.onFive2FiveMemberChoicePush(cb);

		}
		public void onFive2FiveOnGameEndPush(Action<Five2FiveOnGameEndPush> cb)
		{
			_five2FiveHandler.onFive2FiveOnGameEndPush(cb);

		}
		public void onFive2FiveOnNewRewardPush(Action<Five2FiveOnNewRewardPush> cb)
		{
			_five2FiveHandler.onFive2FiveOnNewRewardPush(cb);

		}
		public void onFive2FiveOnNoRewardPush(Action<Five2FiveOnNoRewardPush> cb)
		{
			_five2FiveHandler.onFive2FiveOnNoRewardPush(cb);

		}
		public void onFive2FiveMatchFailedPush(Action<Five2FiveMatchFailedPush> cb)
		{
			_five2FiveHandler.onFive2FiveMatchFailedPush(cb);

		}
		public void onFive2FiveLeaderCancelMatchPush(Action<Five2FiveLeaderCancelMatchPush> cb)
		{
			_five2FiveHandler.onFive2FiveLeaderCancelMatchPush(cb);

		}
		public void onFive2FiveTeamChangePush(Action<Five2FiveTeamChangePush> cb)
		{
			_five2FiveHandler.onFive2FiveTeamChangePush(cb);

		}
		public void onFive2FiveMatchPoolChangePush(Action<Five2FiveMatchPoolChangePush> cb)
		{
			_five2FiveHandler.onFive2FiveMatchPoolChangePush(cb);

		}
		public void onFive2FiveApplyMatchResultPush(Action<Five2FiveApplyMatchResultPush> cb)
		{
			_five2FiveHandler.onFive2FiveApplyMatchResultPush(cb);

		}

	}


}