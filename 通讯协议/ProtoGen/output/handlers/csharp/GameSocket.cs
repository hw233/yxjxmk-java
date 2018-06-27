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
using pomelo.connector;

namespace Pomelo.DotNetClient
{
	public class GameSocket : PomeloClient
	{
		private BagHandler _bagHandler;
		private BattleHandler _battleHandler;
		private DailyActivityHandler _dailyActivityHandler;
		private EquipHandler _equipHandler;
		private ItemHandler _itemHandler;
		private MessageHandler _messageHandler;
		private NpcHandler _npcHandler;
		private PetHandler _petHandler;
		private PetNewHandler _petNewHandler;
		private PlayerHandler _playerHandler;
		private PrepaidHandler _prepaidHandler;
		private ResourceHandler _resourceHandler;
		private SkillHandler _skillHandler;
		private SkillKeysHandler _skillKeysHandler;
		private TaskHandler _taskHandler;
		private TeamHandler _teamHandler;
		private EntryHandler _entryHandler;
		private RoleHandler _roleHandler;

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

		public DailyActivityHandler dailyActivityHandler
		{
			get { return _dailyActivityHandler;}
			set { _dailyActivityHandler = value; }
		}

		public EquipHandler equipHandler
		{
			get { return _equipHandler;}
			set { _equipHandler = value; }
		}

		public ItemHandler itemHandler
		{
			get { return _itemHandler;}
			set { _itemHandler = value; }
		}

		public MessageHandler messageHandler
		{
			get { return _messageHandler;}
			set { _messageHandler = value; }
		}

		public NpcHandler npcHandler
		{
			get { return _npcHandler;}
			set { _npcHandler = value; }
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

		public ResourceHandler resourceHandler
		{
			get { return _resourceHandler;}
			set { _resourceHandler = value; }
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

		public GameSocket(ISerializer serializer) : base(serializer)
		{
			_bagHandler = new BagHandler(this);
			_battleHandler = new BattleHandler(this);
			_dailyActivityHandler = new DailyActivityHandler(this);
			_equipHandler = new EquipHandler(this);
			_itemHandler = new ItemHandler(this);
			_messageHandler = new MessageHandler(this);
			_npcHandler = new NpcHandler(this);
			_petHandler = new PetHandler(this);
			_petNewHandler = new PetNewHandler(this);
			_playerHandler = new PlayerHandler(this);
			_prepaidHandler = new PrepaidHandler(this);
			_resourceHandler = new ResourceHandler(this);
			_skillHandler = new SkillHandler(this);
			_skillKeysHandler = new SkillKeysHandler(this);
			_taskHandler = new TaskHandler(this);
			_teamHandler = new TeamHandler(this);
			_entryHandler = new EntryHandler(this);
			_roleHandler = new RoleHandler(this);

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
		public void onUpdateActivityPush(Action<UpdateActivityPush> cb)
		{
			_dailyActivityHandler.onUpdateActivityPush(cb);

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
		public void onMessageAddPush(Action<OnMessageAddPush> cb)
		{
			_messageHandler.onMessageAddPush(cb);

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
		public void onSkillUpdatePush(Action<SkillUpdatePush> cb)
		{
			_skillHandler.onSkillUpdatePush(cb);

		}
		public void onSkillKeyUpdatePush(Action<SkillKeyUpdatePush> cb)
		{
			_skillKeysHandler.onSkillKeyUpdatePush(cb);

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
		public void onLoginQueuePush(Action<LoginQueuePush> cb)
		{
			_entryHandler.onLoginQueuePush(cb);

		}

	}


}