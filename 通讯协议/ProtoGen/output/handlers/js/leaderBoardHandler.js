/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var LeaderBoardHandler = function(socket){
	this.socket = socket;
}

LeaderBoardHandler.prototype.leaderBoardRequest = async(function(c2s_kind,c2s_season){
	return await(this.socket.requestAsync('area.leaderBoardHandler.leaderBoardRequest',{c2s_kind:c2s_kind,c2s_season:c2s_season}));
});

LeaderBoardHandler.prototype.guildInfoRequest = async(function(c2s_guildId){
	return await(this.socket.requestAsync('area.leaderBoardHandler.guildInfoRequest',{c2s_guildId:c2s_guildId}));
});

LeaderBoardHandler.prototype.worShipRequest = async(function(c2s_type){
	return await(this.socket.requestAsync('area.leaderBoardHandler.worShipRequest',{c2s_type:c2s_type}));
});

LeaderBoardHandler.prototype.worldLevelInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.leaderBoardHandler.worldLevelInfoRequest',{}));
});


module.exports = LeaderBoardHandler;
