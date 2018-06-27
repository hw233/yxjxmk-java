-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGameSocket"
require "base64"
require "stealHandler_pb"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------StealHandler-------------------------------
Pomelo.StealHandler = {}

local function stealRequestEncoder(msg)
	local input = stealHandler_pb.StealRequest()
	protobuf.FromMessage(input,msg)
	return (input:SerializeToString())
end

local function stealRequestDecoder(stream)
	local res = stealHandler_pb.StealResponse()
	res:ParseFromString(stream)
	return res
end

function Pomelo.StealHandler.stealRequest(c2s_id,cb,option)
	local msg = {}
	msg.c2s_id = c2s_id
	Socket.OnRequestStart("area.stealHandler.stealRequest", option)
	Socket.Request("area.stealHandler.stealRequest", msg, function(res)
		if(res.s2c_code == 200) then
			Pomelo.StealHandler.lastStealResponse = res
			Socket.OnRequestEnd("area.stealHandler.stealRequest", true)
			cb(nil,res)
		else
			local ex = {}
			if(res.s2c_code) then
				ex.Code = res.s2c_code
				ex.Message = res.s2c_msg
			else
				ex.Code = 501
				ex.Message = "[LuaXmdsNetClient] area.stealHandler.stealRequest decode error!!"
			end
			Socket.OnRequestEnd("area.stealHandler.stealRequest", false,ex.Code,ex.Message)
			cb(ex,nil)
		end
	end, stealRequestEncoder, stealRequestDecoder)
end




--------------------------------Pomelo-------------------------------
return Pomelo
