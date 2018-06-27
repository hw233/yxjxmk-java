-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGameSocket"
require "base64"
require "guildBossHandler_pb"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------GuildBossHandler-------------------------------
Pomelo.GuildBossHandler = {}

local function enterGuildBossAreaRequestEncoder(msg)
	local input = guildBossHandler_pb.EnterGuildBossAreaRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function enterGuildBossAreaRequestDecoder(stream)
	local res = guildBossHandler_pb.EnterGuildBossAreaResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.enterGuildBossAreaRequest(cb,option)
	local input = nil
	Socket.OnRequestStart("area.guildBossHandler.enterGuildBossAreaRequest", option)
	Socket.Request("area.guildBossHandler.enterGuildBossAreaRequest", input, function(res)
		if(res.s2c_code == 200) then
			Pomelo.GuildBossHandler.lastEnterGuildBossAreaResponse = res
			Socket.OnRequestEnd("area.guildBossHandler.enterGuildBossAreaRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.guildBossHandler.enterGuildBossAreaRequest decode error!!"
			end
			Socket.OnRequestEnd("area.guildBossHandler.enterGuildBossAreaRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, enterGuildBossAreaRequestEncoder, enterGuildBossAreaRequestDecoder)
end


local function getGuildBossInfoRequestEncoder(msg)
	local input = guildBossHandler_pb.GetGuildBossInfoRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function getGuildBossInfoRequestDecoder(stream)
	local res = guildBossHandler_pb.GetGuildBossInfoResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.getGuildBossInfoRequest(cb,option)
	local input = nil
	Socket.OnRequestStart("area.guildBossHandler.getGuildBossInfoRequest", option)
	Socket.Request("area.guildBossHandler.getGuildBossInfoRequest", input, function(res)
		if(res.s2c_code == 200) then
			Pomelo.GuildBossHandler.lastGetGuildBossInfoResponse = res
			Socket.OnRequestEnd("area.guildBossHandler.getGuildBossInfoRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.guildBossHandler.getGuildBossInfoRequest decode error!!"
			end
			Socket.OnRequestEnd("area.guildBossHandler.getGuildBossInfoRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, getGuildBossInfoRequestEncoder, getGuildBossInfoRequestDecoder)
end


local function guildBossInspireRequestEncoder(msg)
	local input = guildBossHandler_pb.GuildBossInspireRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function guildBossInspireRequestDecoder(stream)
	local res = guildBossHandler_pb.GuildBossInspireResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.guildBossInspireRequest(c2s_index,cb,option)
	local msg = {}
	msg.c2s_index = c2s_index
	Socket.OnRequestStart("area.guildBossHandler.guildBossInspireRequest", option)
	Socket.Request("area.guildBossHandler.guildBossInspireRequest", msg, function(res)
		if(res.s2c_code == 200) then
			Pomelo.GuildBossHandler.lastGuildBossInspireResponse = res
			Socket.OnRequestEnd("area.guildBossHandler.guildBossInspireRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.guildBossHandler.guildBossInspireRequest decode error!!"
			end
			Socket.OnRequestEnd("area.guildBossHandler.guildBossInspireRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, guildBossInspireRequestEncoder, guildBossInspireRequestDecoder)
end


local function onHurtRankChangePushDecoder(stream)
	local res = guildBossHandler_pb.OnHurtRankChangePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.onHurtRankChangePush(cb)
	Socket.On("area.guildBossPush.onHurtRankChangePush", function(res) 
		Pomelo.GuildBossHandler.lastOnHurtRankChangePush = res
		cb(nil,res) 
	end, onHurtRankChangePushDecoder) 
end


local function onInspireSingleChangePushDecoder(stream)
	local res = guildBossHandler_pb.OnInspireSingleChangePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.onInspireSingleChangePush(cb)
	Socket.On("area.guildBossPush.onInspireSingleChangePush", function(res) 
		Pomelo.GuildBossHandler.lastOnInspireSingleChangePush = res
		cb(nil,res) 
	end, onInspireSingleChangePushDecoder) 
end


local function onInspireGuildChangePushDecoder(stream)
	local res = guildBossHandler_pb.OnInspireGuildChangePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.onInspireGuildChangePush(cb)
	Socket.On("area.guildBossPush.onInspireGuildChangePush", function(res) 
		Pomelo.GuildBossHandler.lastOnInspireGuildChangePush = res
		cb(nil,res) 
	end, onInspireGuildChangePushDecoder) 
end


local function onGuildBossOverPushDecoder(stream)
	local res = guildBossHandler_pb.OnGuildBossOverPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.onGuildBossOverPush(cb)
	Socket.On("area.guildBossPush.onGuildBossOverPush", function(res) 
		Pomelo.GuildBossHandler.lastOnGuildBossOverPush = res
		cb(nil,res) 
	end, onGuildBossOverPushDecoder) 
end


local function onQuitGuildBossPushDecoder(stream)
	local res = guildBossHandler_pb.OnQuitGuildBossPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GuildBossHandler.onQuitGuildBossPush(cb)
	Socket.On("area.guildBossPush.onQuitGuildBossPush", function(res) 
		Pomelo.GuildBossHandler.lastOnQuitGuildBossPush = res
		cb(nil,res) 
	end, onQuitGuildBossPushDecoder) 
end




--------------------------------Pomelo-------------------------------
return Pomelo
