-------------------------------------------------
-- 本文件由代码生成器自动生成，
-- 千万不要修改本文件的任何代码，
-- 修改的的任何代码都会被覆盖掉！
----------------------------------------------------

local Socket = require "Xmds.Pomelo.LuaGateSocket"
require "base64"

--------------------------------Pomelo-------------------------------
Pomelo = Pomelo or {}

--------------------------------GateSocket-------------------------------
Pomelo.GateSocket = {}

local function serverStatePushDecoder(stream)
	local res = loginHandler_pb.ServerStatePush()
	res:ParseFromString(stream)
	return res
end

function Pomelo.GateSocket.serverStatePush(cb)
	Socket.On("login.loginPush.serverStatePush", function(res) 
		Pomelo.GateSocket.lastServerStatePush = res
		cb(nil,res) 
	end, serverStatePushDecoder) 
end




--------------------------------Pomelo-------------------------------
return Pomelo
