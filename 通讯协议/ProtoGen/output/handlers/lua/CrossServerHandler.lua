-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGameSocket"
require "base64"
require "crossServerHandler_pb"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------CrossServerHandler-------------------------------
Pomelo.CrossServerHandler = {}

local function treasureOpenPushDecoder(stream)
	local res = crossServerHandler_pb.TreasureOpenPush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.CrossServerHandler.treasureOpenPush(cb)
	Socket.On("area.crossServerPush.treasureOpenPush", function(res) 
		Pomelo.CrossServerHandler.lastTreasureOpenPush = res
		cb(nil,res) 
	end, treasureOpenPushDecoder) 
end




--------------------------------Pomelo-------------------------------
return Pomelo
