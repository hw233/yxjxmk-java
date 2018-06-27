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

namespace pomelo.area
{
	public class TaskHandler
	{
		private PomeloClient _socket;

		public AcceptTaskResponse lastAcceptTaskResponse { get { return _socket.GetLastResponse<AcceptTaskResponse>(); } }
		public QuickFinishResponse lastQuickFinishResponse { get { return _socket.GetLastResponse<QuickFinishResponse>(); } }
		public DiscardTaskResponse lastDiscardTaskResponse { get { return _socket.GetLastResponse<DiscardTaskResponse>(); } }
		public SubmitTaskResponse lastSubmitTaskResponse { get { return _socket.GetLastResponse<SubmitTaskResponse>(); } }
		public UpdateTaskStatusResponse lastUpdateTaskStatusResponse { get { return _socket.GetLastResponse<UpdateTaskStatusResponse>(); } }
		public RefreshSoulTaskResponse lastRefreshSoulTaskResponse { get { return _socket.GetLastResponse<RefreshSoulTaskResponse>(); } }
		public GetDailySoulFinNumResponse lastGetDailySoulFinNumResponse { get { return _socket.GetLastResponse<GetDailySoulFinNumResponse>(); } }
		public TaskFuncDeskResponse lastTaskFuncDeskResponse { get { return _socket.GetLastResponse<TaskFuncDeskResponse>(); } }
		public AcceptLoopTaskResponse lastAcceptLoopTaskResponse { get { return _socket.GetLastResponse<AcceptLoopTaskResponse>(); } }
		public AcceptDailyTaskResponse lastAcceptDailyTaskResponse { get { return _socket.GetLastResponse<AcceptDailyTaskResponse>(); } }
		public ReachTreasurePointResponse lastReachTreasurePointResponse { get { return _socket.GetLastResponse<ReachTreasurePointResponse>(); } }
		static TaskHandler()
		{
			EventTypes.RegistPushType("area.taskPush.taskUpdatePush", typeof(TaskUpdatePush));
			EventTypes.RegistPushType("area.taskPush.taskAutoPush", typeof(TaskAutoPush));
			EventTypes.RegistPushType("area.taskPush.treasureScenePointPush", typeof(TreasureScenePointPush));
			EventTypes.RegistPushType("area.taskPush.loopResultPush", typeof(LoopResultPush));
			EventTypes.RegistRequestType("area.taskHandler.acceptTaskRequest", typeof(AcceptTaskRequest), typeof(AcceptTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.quickFinishRequest", typeof(QuickFinishRequest), typeof(QuickFinishResponse));
			EventTypes.RegistRequestType("area.taskHandler.discardTaskRequest", typeof(DiscardTaskRequest), typeof(DiscardTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.submitTaskRequest", typeof(SubmitTaskRequest), typeof(SubmitTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.updateTaskStatusRequest", typeof(UpdateTaskStatusRequest), typeof(UpdateTaskStatusResponse));
			EventTypes.RegistRequestType("area.taskHandler.refreshSoulTaskRequest", typeof(RefreshSoulTaskRequest), typeof(RefreshSoulTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.getDailySoulFinNumRequest", typeof(GetDailySoulFinNumRequest), typeof(GetDailySoulFinNumResponse));
			EventTypes.RegistRequestType("area.taskHandler.taskFuncDeskRequest", typeof(TaskFuncDeskRequest), typeof(TaskFuncDeskResponse));
			EventTypes.RegistRequestType("area.taskHandler.acceptLoopTaskRequest", typeof(AcceptLoopTaskRequest), typeof(AcceptLoopTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.acceptDailyTaskRequest", typeof(AcceptDailyTaskRequest), typeof(AcceptDailyTaskResponse));
			EventTypes.RegistRequestType("area.taskHandler.reachTreasurePointRequest", typeof(ReachTreasurePointRequest), typeof(ReachTreasurePointResponse));
			EventTypes.RegistNotifyType("area.taskHandler.cjPlayEndNotify", typeof(CjPlayEndNotify));
		}
		public TaskHandler(PomeloClient socket)
		{
			this._socket = socket;

		}
		public void acceptTaskRequest(int c2s_templateId,int c2s_kind,string c2s_npcId,Action<PomeloException,AcceptTaskResponse> cb,object option = null)
		{
			var request = new AcceptTaskRequest();
			request.c2s_templateId= c2s_templateId;
			request.c2s_kind= c2s_kind;
			request.c2s_npcId= c2s_npcId;
			_socket.request<AcceptTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AcceptTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void quickFinishRequest(int c2s_templateId,int c2s_kind,string c2s_npcId,Action<PomeloException,QuickFinishResponse> cb,object option = null)
		{
			var request = new QuickFinishRequest();
			request.c2s_templateId= c2s_templateId;
			request.c2s_kind= c2s_kind;
			request.c2s_npcId= c2s_npcId;
			_socket.request<QuickFinishResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as QuickFinishResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void discardTaskRequest(int c2s_templateId,int c2s_kind,Action<PomeloException,DiscardTaskResponse> cb,object option = null)
		{
			var request = new DiscardTaskRequest();
			request.c2s_templateId= c2s_templateId;
			request.c2s_kind= c2s_kind;
			_socket.request<DiscardTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as DiscardTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void submitTaskRequest(int c2s_templateId,int c2s_kind,int c2s_double,string c2s_npcId,Action<PomeloException,SubmitTaskResponse> cb,object option = null)
		{
			var request = new SubmitTaskRequest();
			request.c2s_templateId= c2s_templateId;
			request.c2s_kind= c2s_kind;
			request.c2s_double= c2s_double;
			request.c2s_npcId= c2s_npcId;
			_socket.request<SubmitTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as SubmitTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void updateTaskStatusRequest(int c2s_templateId,int c2s_kind,Action<PomeloException,UpdateTaskStatusResponse> cb,object option = null)
		{
			var request = new UpdateTaskStatusRequest();
			request.c2s_templateId= c2s_templateId;
			request.c2s_kind= c2s_kind;
			_socket.request<UpdateTaskStatusResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as UpdateTaskStatusResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void refreshSoulTaskRequest(int c2s_taskId,Action<PomeloException,RefreshSoulTaskResponse> cb,object option = null)
		{
			var request = new RefreshSoulTaskRequest();
			request.c2s_taskId= c2s_taskId;
			_socket.request<RefreshSoulTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as RefreshSoulTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void getDailySoulFinNumRequest(Action<PomeloException,GetDailySoulFinNumResponse> cb,object option = null)
		{
			var request = new GetDailySoulFinNumRequest();
			_socket.request<GetDailySoulFinNumResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as GetDailySoulFinNumResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void taskFuncDeskRequest(string c2s_ncpId,Action<PomeloException,TaskFuncDeskResponse> cb,object option = null)
		{
			var request = new TaskFuncDeskRequest();
			request.c2s_ncpId= c2s_ncpId;
			_socket.request<TaskFuncDeskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as TaskFuncDeskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void acceptLoopTaskRequest(string c2s_npcId,Action<PomeloException,AcceptLoopTaskResponse> cb,object option = null)
		{
			var request = new AcceptLoopTaskRequest();
			request.c2s_npcId= c2s_npcId;
			_socket.request<AcceptLoopTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AcceptLoopTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void acceptDailyTaskRequest(string c2s_npcId,Action<PomeloException,AcceptDailyTaskResponse> cb,object option = null)
		{
			var request = new AcceptDailyTaskRequest();
			request.c2s_npcId= c2s_npcId;
			_socket.request<AcceptDailyTaskResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as AcceptDailyTaskResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void reachTreasurePointRequest(int point,Action<PomeloException,ReachTreasurePointResponse> cb,object option = null)
		{
			var request = new ReachTreasurePointRequest();
			request.point= point;
			_socket.request<ReachTreasurePointResponse>(request, (object msg, out int s2c_code, out string s2c_msg) => {
				var rsp = msg as ReachTreasurePointResponse;
				s2c_code = rsp.s2c_code;
				s2c_msg = rsp.s2c_msg;
				return s2c_code == 200;
			}, cb, option);

		}
		public void cjPlayEndNotify(string s2c_msg)
		{
			var notify = new CjPlayEndNotify();
			notify.s2c_msg= s2c_msg;

			_socket.notify(notify);

		}
		public void onTaskUpdatePush(Action<TaskUpdatePush> cb)
		{
			_socket.listen_once<TaskUpdatePush>(cb);
		}
		public void onTaskAutoPush(Action<TaskAutoPush> cb)
		{
			_socket.listen_once<TaskAutoPush>(cb);
		}
		public void onTreasureScenePointPush(Action<TreasureScenePointPush> cb)
		{
			_socket.listen_once<TreasureScenePointPush>(cb);
		}
		public void onLoopResultPush(Action<LoopResultPush> cb)
		{
			_socket.listen_once<LoopResultPush>(cb);
		}

	}


}