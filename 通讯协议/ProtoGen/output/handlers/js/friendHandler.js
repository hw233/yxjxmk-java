/*-----------------------------------------------
 *本文件由代码生成器自动生成，
 *千万不要修改本文件的任何代码，
 *修改的的任何代码都会被覆盖掉！
 --------------------------------------------------*/

var async = require('asyncawait/async');
var await = require('asyncawait/await');


var FriendHandler = function(socket){
	this.socket = socket;
}

FriendHandler.prototype.friendGetAllFriendsRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.friendGetAllFriendsRequest',{}));
});

FriendHandler.prototype.friendApplyRequest = async(function(c2s_toPlayerId){
	return await(this.socket.requestAsync('area.friendHandler.friendApplyRequest',{c2s_toPlayerId:c2s_toPlayerId}));
});

FriendHandler.prototype.friendAllApplyRequest = async(function(c2s_toPlayerIds){
	return await(this.socket.requestAsync('area.friendHandler.friendAllApplyRequest',{c2s_toPlayerIds:c2s_toPlayerIds}));
});

FriendHandler.prototype.friendAgreeApplyRequest = async(function(c2s_requestId){
	return await(this.socket.requestAsync('area.friendHandler.friendAgreeApplyRequest',{c2s_requestId:c2s_requestId}));
});

FriendHandler.prototype.friendAllAgreeApplyRequest = async(function(c2s_requestIds){
	return await(this.socket.requestAsync('area.friendHandler.friendAllAgreeApplyRequest',{c2s_requestIds:c2s_requestIds}));
});

FriendHandler.prototype.friendRefuceApplyRequest = async(function(c2s_requestId){
	return await(this.socket.requestAsync('area.friendHandler.friendRefuceApplyRequest',{c2s_requestId:c2s_requestId}));
});

FriendHandler.prototype.friendAllRefuceApplyRequest = async(function(c2s_requestIds){
	return await(this.socket.requestAsync('area.friendHandler.friendAllRefuceApplyRequest',{c2s_requestIds:c2s_requestIds}));
});

FriendHandler.prototype.friendDeleteRequest = async(function(c2s_friendId){
	return await(this.socket.requestAsync('area.friendHandler.friendDeleteRequest',{c2s_friendId:c2s_friendId}));
});

FriendHandler.prototype.friendDeleteChouRenRequest = async(function(c2s_chouRenId){
	return await(this.socket.requestAsync('area.friendHandler.friendDeleteChouRenRequest',{c2s_chouRenId:c2s_chouRenId}));
});

FriendHandler.prototype.friendAllDeleteChouRenRequest = async(function(c2s_chouRenIds){
	return await(this.socket.requestAsync('area.friendHandler.friendAllDeleteChouRenRequest',{c2s_chouRenIds:c2s_chouRenIds}));
});

FriendHandler.prototype.friendAddChouRenRequest = async(function(c2s_chouRenId){
	return await(this.socket.requestAsync('area.friendHandler.friendAddChouRenRequest',{c2s_chouRenId:c2s_chouRenId}));
});

FriendHandler.prototype.addFriendInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.addFriendInfoRequest',{}));
});

FriendHandler.prototype.queryPlayerNameRequest = async(function(c2s_strName){
	return await(this.socket.requestAsync('area.friendHandler.queryPlayerNameRequest',{c2s_strName:c2s_strName}));
});

FriendHandler.prototype.concernFriendRequest = async(function(c2s_friendId){
	return await(this.socket.requestAsync('area.friendHandler.concernFriendRequest',{c2s_friendId:c2s_friendId}));
});

FriendHandler.prototype.concernAllFriendRequest = async(function(c2s_friendIds){
	return await(this.socket.requestAsync('area.friendHandler.concernAllFriendRequest',{c2s_friendIds:c2s_friendIds}));
});

FriendHandler.prototype.friendMessageListRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.friendMessageListRequest',{}));
});

FriendHandler.prototype.deleteAllFriendMessageRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.deleteAllFriendMessageRequest',{}));
});

FriendHandler.prototype.deleteBlackListRequest = async(function(c2s_blackListId){
	return await(this.socket.requestAsync('area.friendHandler.deleteBlackListRequest',{c2s_blackListId:c2s_blackListId}));
});

FriendHandler.prototype.deleteAllBlackListRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.deleteAllBlackListRequest',{}));
});

FriendHandler.prototype.addBlackListRequest = async(function(c2s_blackListId){
	return await(this.socket.requestAsync('area.friendHandler.addBlackListRequest',{c2s_blackListId:c2s_blackListId}));
});

FriendHandler.prototype.getSocialInfoRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.getSocialInfoRequest',{}));
});

FriendHandler.prototype.getShopItemListRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.getShopItemListRequest',{}));
});

FriendHandler.prototype.exchangeFriendShopItemRequest = async(function(c2s_itemId,c2s_num){
	return await(this.socket.requestAsync('area.friendHandler.exchangeFriendShopItemRequest',{c2s_itemId:c2s_itemId,c2s_num:c2s_num}));
});

FriendHandler.prototype.getRecentChatListRequest = async(function(){
	return await(this.socket.requestAsync('area.friendHandler.getRecentChatListRequest',{}));
});

FriendHandler.prototype.getChatMsgRequest = async(function(c2s_friendId){
	return await(this.socket.requestAsync('area.friendHandler.getChatMsgRequest',{c2s_friendId:c2s_friendId}));
});

FriendHandler.prototype.rmChatMsgRequest = async(function(c2s_friendId){
	return await(this.socket.requestAsync('area.friendHandler.rmChatMsgRequest',{c2s_friendId:c2s_friendId}));
});


module.exports = FriendHandler;
