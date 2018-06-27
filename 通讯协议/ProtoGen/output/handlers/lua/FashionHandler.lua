-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGameSocket"
require "base64"
require "fashionHandler_pb"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------FashionHandler-------------------------------
Pomelo.FashionHandler = {}

local function equipFashionRequestEncoder(msg)
	local input = fashionHandler_pb.EquipFashionRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function equipFashionRequestDecoder(stream)
	local res = fashionHandler_pb.EquipFashionResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.FashionHandler.equipFashionRequest(code,ison,cb,option)
	local msg = {}
	msg.code = code
	msg.ison = ison
	Socket.OnRequestStart("area.fashionHandler.equipFashionRequest", option)
	Socket.Request("area.fashionHandler.equipFashionRequest", msg, function(res)
		if(res.s2c_code == 200) then
			Pomelo.FashionHandler.lastEquipFashionResponse = res
			Socket.OnRequestEnd("area.fashionHandler.equipFashionRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.fashionHandler.equipFashionRequest decode error!!"
			end
			Socket.OnRequestEnd("area.fashionHandler.equipFashionRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, equipFashionRequestEncoder, equipFashionRequestDecoder)
end


local function getFashionsRequestEncoder(msg)
	local input = fashionHandler_pb.GetFashionsRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function getFashionsRequestDecoder(stream)
	local res = fashionHandler_pb.GetFashionsResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.FashionHandler.getFashionsRequest(cb,option)
	local input = nil
	Socket.OnRequestStart("area.fashionHandler.getFashionsRequest", option)
	Socket.Request("area.fashionHandler.getFashionsRequest", input, function(res)
		if(res.s2c_code == 200) then
			Pomelo.FashionHandler.lastGetFashionsResponse = res
			Socket.OnRequestEnd("area.fashionHandler.getFashionsRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.fashionHandler.getFashionsRequest decode error!!"
			end
			Socket.OnRequestEnd("area.fashionHandler.getFashionsRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, getFashionsRequestEncoder, getFashionsRequestDecoder)
end


local function onFashionGetPushDecoder(stream)
	local res = fashionHandler_pb.FashionGetPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.FashionHandler.onFashionGetPush(cb)
	Socket.On("area.fashionPush.onFashionGetPush", function(res) 
		Pomelo.FashionHandler.lastFashionGetPush = res
		cb(nil,res) 
	end, onFashionGetPushDecoder) 
end




--------------------------------Pomelo-------------------------------
return Pomelo
