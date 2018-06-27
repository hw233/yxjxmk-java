/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var RankHandler = function(socket){
	this.socket = socket;
}

RankHandler.prototype.getRankInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.rankHandler.getRankInfoRequest',{}));
});

RankHandler.prototype.saveRankNotify = function(c2s_selectedRankId){
	return this.socket.notify('area.rankHandler.saveRankNotify',{c2s_selectedRankId:c2s_selectedRankId});
};


RankHandler.prototype.onOnAwardRankPush = function(cb){
	this.socket.on('area.rankPush.onAwardRankPush',cb);
}

module.exports = RankHandler;
