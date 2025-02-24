-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
local common_pb = require("common_pb")
module('chatHandler_pb')


SENDCHATREQUEST = protobuf.Descriptor();
local SENDCHATREQUEST_C2S_SCOPE_FIELD = protobuf.FieldDescriptor();
local SENDCHATREQUEST_C2S_CONTENT_FIELD = protobuf.FieldDescriptor();
local SENDCHATREQUEST_C2S_SERVERDATA_FIELD = protobuf.FieldDescriptor();
local SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD = protobuf.FieldDescriptor();
SENDCHATRESPONSE = protobuf.Descriptor();
local SENDCHATRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local SENDCHATRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
GETSAVECHATMSGREQUEST = protobuf.Descriptor();
local GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD = protobuf.FieldDescriptor();
local GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD = protobuf.FieldDescriptor();
local GETSAVECHATMSGREQUEST_C2S_UID_FIELD = protobuf.FieldDescriptor();
ONCHATPUSH = protobuf.Descriptor();
local ONCHATPUSH_S2C_PLAYERID_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_UID_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_CONTENT_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_SCOPE_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_TIME_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_SYS_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_INDEX_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_SERVERDATA_FIELD = protobuf.FieldDescriptor();
local ONCHATPUSH_S2C_ACCEPTRID_FIELD = protobuf.FieldDescriptor();
GETSAVECHATMSGRESPONSE = protobuf.Descriptor();
local GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD = protobuf.FieldDescriptor();
ONCHATERRORPUSH = protobuf.Descriptor();
local ONCHATERRORPUSH_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local ONCHATERRORPUSH_S2C_MSG_FIELD = protobuf.FieldDescriptor();
TIPPUSH = protobuf.Descriptor();
local TIPPUSH_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local TIPPUSH_S2C_TYPE_FIELD = protobuf.FieldDescriptor();

SENDCHATREQUEST_C2S_SCOPE_FIELD.name = "c2s_scope"
SENDCHATREQUEST_C2S_SCOPE_FIELD.full_name = ".pomelo.chat.SendChatRequest.c2s_scope"
SENDCHATREQUEST_C2S_SCOPE_FIELD.number = 1
SENDCHATREQUEST_C2S_SCOPE_FIELD.index = 0
SENDCHATREQUEST_C2S_SCOPE_FIELD.label = 2
SENDCHATREQUEST_C2S_SCOPE_FIELD.has_default_value = false
SENDCHATREQUEST_C2S_SCOPE_FIELD.default_value = 0
SENDCHATREQUEST_C2S_SCOPE_FIELD.type = 5
SENDCHATREQUEST_C2S_SCOPE_FIELD.cpp_type = 1

SENDCHATREQUEST_C2S_CONTENT_FIELD.name = "c2s_content"
SENDCHATREQUEST_C2S_CONTENT_FIELD.full_name = ".pomelo.chat.SendChatRequest.c2s_content"
SENDCHATREQUEST_C2S_CONTENT_FIELD.number = 2
SENDCHATREQUEST_C2S_CONTENT_FIELD.index = 1
SENDCHATREQUEST_C2S_CONTENT_FIELD.label = 2
SENDCHATREQUEST_C2S_CONTENT_FIELD.has_default_value = false
SENDCHATREQUEST_C2S_CONTENT_FIELD.default_value = ""
SENDCHATREQUEST_C2S_CONTENT_FIELD.type = 9
SENDCHATREQUEST_C2S_CONTENT_FIELD.cpp_type = 9

SENDCHATREQUEST_C2S_SERVERDATA_FIELD.name = "c2s_serverData"
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.full_name = ".pomelo.chat.SendChatRequest.c2s_serverData"
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.number = 3
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.index = 2
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.label = 1
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.has_default_value = false
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.default_value = ""
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.type = 9
SENDCHATREQUEST_C2S_SERVERDATA_FIELD.cpp_type = 9

SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.name = "c2s_acceptRoleId"
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.full_name = ".pomelo.chat.SendChatRequest.c2s_acceptRoleId"
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.number = 4
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.index = 3
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.label = 1
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.has_default_value = false
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.default_value = ""
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.type = 9
SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD.cpp_type = 9

SENDCHATREQUEST.name = "SendChatRequest"
SENDCHATREQUEST.full_name = ".pomelo.chat.SendChatRequest"
SENDCHATREQUEST.nested_types = {}
SENDCHATREQUEST.enum_types = {}
SENDCHATREQUEST.fields = {SENDCHATREQUEST_C2S_SCOPE_FIELD, SENDCHATREQUEST_C2S_CONTENT_FIELD, SENDCHATREQUEST_C2S_SERVERDATA_FIELD, SENDCHATREQUEST_C2S_ACCEPTROLEID_FIELD}
SENDCHATREQUEST.is_extendable = false
SENDCHATREQUEST.extensions = {}
SENDCHATRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
SENDCHATRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.chat.SendChatResponse.s2c_code"
SENDCHATRESPONSE_S2C_CODE_FIELD.number = 1
SENDCHATRESPONSE_S2C_CODE_FIELD.index = 0
SENDCHATRESPONSE_S2C_CODE_FIELD.label = 2
SENDCHATRESPONSE_S2C_CODE_FIELD.has_default_value = false
SENDCHATRESPONSE_S2C_CODE_FIELD.default_value = 0
SENDCHATRESPONSE_S2C_CODE_FIELD.type = 5
SENDCHATRESPONSE_S2C_CODE_FIELD.cpp_type = 1

SENDCHATRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
SENDCHATRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.chat.SendChatResponse.s2c_msg"
SENDCHATRESPONSE_S2C_MSG_FIELD.number = 2
SENDCHATRESPONSE_S2C_MSG_FIELD.index = 1
SENDCHATRESPONSE_S2C_MSG_FIELD.label = 1
SENDCHATRESPONSE_S2C_MSG_FIELD.has_default_value = false
SENDCHATRESPONSE_S2C_MSG_FIELD.default_value = ""
SENDCHATRESPONSE_S2C_MSG_FIELD.type = 9
SENDCHATRESPONSE_S2C_MSG_FIELD.cpp_type = 9

SENDCHATRESPONSE.name = "SendChatResponse"
SENDCHATRESPONSE.full_name = ".pomelo.chat.SendChatResponse"
SENDCHATRESPONSE.nested_types = {}
SENDCHATRESPONSE.enum_types = {}
SENDCHATRESPONSE.fields = {SENDCHATRESPONSE_S2C_CODE_FIELD, SENDCHATRESPONSE_S2C_MSG_FIELD}
SENDCHATRESPONSE.is_extendable = false
SENDCHATRESPONSE.extensions = {}
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.name = "c2s_scope"
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgRequest.c2s_scope"
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.number = 1
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.index = 0
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.label = 2
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.has_default_value = false
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.default_value = 0
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.type = 5
GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD.cpp_type = 1

GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.name = "c2s_index"
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgRequest.c2s_index"
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.number = 2
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.index = 1
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.label = 2
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.has_default_value = false
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.default_value = 0
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.type = 5
GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD.cpp_type = 1

GETSAVECHATMSGREQUEST_C2S_UID_FIELD.name = "c2s_uid"
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgRequest.c2s_uid"
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.number = 3
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.index = 2
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.label = 1
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.has_default_value = false
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.default_value = ""
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.type = 9
GETSAVECHATMSGREQUEST_C2S_UID_FIELD.cpp_type = 9

GETSAVECHATMSGREQUEST.name = "GetSaveChatMsgRequest"
GETSAVECHATMSGREQUEST.full_name = ".pomelo.chat.GetSaveChatMsgRequest"
GETSAVECHATMSGREQUEST.nested_types = {}
GETSAVECHATMSGREQUEST.enum_types = {}
GETSAVECHATMSGREQUEST.fields = {GETSAVECHATMSGREQUEST_C2S_SCOPE_FIELD, GETSAVECHATMSGREQUEST_C2S_INDEX_FIELD, GETSAVECHATMSGREQUEST_C2S_UID_FIELD}
GETSAVECHATMSGREQUEST.is_extendable = false
GETSAVECHATMSGREQUEST.extensions = {}
ONCHATPUSH_S2C_PLAYERID_FIELD.name = "s2c_playerId"
ONCHATPUSH_S2C_PLAYERID_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_playerId"
ONCHATPUSH_S2C_PLAYERID_FIELD.number = 2
ONCHATPUSH_S2C_PLAYERID_FIELD.index = 0
ONCHATPUSH_S2C_PLAYERID_FIELD.label = 2
ONCHATPUSH_S2C_PLAYERID_FIELD.has_default_value = false
ONCHATPUSH_S2C_PLAYERID_FIELD.default_value = ""
ONCHATPUSH_S2C_PLAYERID_FIELD.type = 9
ONCHATPUSH_S2C_PLAYERID_FIELD.cpp_type = 9

ONCHATPUSH_S2C_UID_FIELD.name = "s2c_uid"
ONCHATPUSH_S2C_UID_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_uid"
ONCHATPUSH_S2C_UID_FIELD.number = 3
ONCHATPUSH_S2C_UID_FIELD.index = 1
ONCHATPUSH_S2C_UID_FIELD.label = 2
ONCHATPUSH_S2C_UID_FIELD.has_default_value = false
ONCHATPUSH_S2C_UID_FIELD.default_value = ""
ONCHATPUSH_S2C_UID_FIELD.type = 9
ONCHATPUSH_S2C_UID_FIELD.cpp_type = 9

ONCHATPUSH_S2C_CONTENT_FIELD.name = "s2c_content"
ONCHATPUSH_S2C_CONTENT_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_content"
ONCHATPUSH_S2C_CONTENT_FIELD.number = 4
ONCHATPUSH_S2C_CONTENT_FIELD.index = 2
ONCHATPUSH_S2C_CONTENT_FIELD.label = 2
ONCHATPUSH_S2C_CONTENT_FIELD.has_default_value = false
ONCHATPUSH_S2C_CONTENT_FIELD.default_value = ""
ONCHATPUSH_S2C_CONTENT_FIELD.type = 9
ONCHATPUSH_S2C_CONTENT_FIELD.cpp_type = 9

ONCHATPUSH_S2C_SCOPE_FIELD.name = "s2c_scope"
ONCHATPUSH_S2C_SCOPE_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_scope"
ONCHATPUSH_S2C_SCOPE_FIELD.number = 5
ONCHATPUSH_S2C_SCOPE_FIELD.index = 3
ONCHATPUSH_S2C_SCOPE_FIELD.label = 2
ONCHATPUSH_S2C_SCOPE_FIELD.has_default_value = false
ONCHATPUSH_S2C_SCOPE_FIELD.default_value = 0
ONCHATPUSH_S2C_SCOPE_FIELD.type = 5
ONCHATPUSH_S2C_SCOPE_FIELD.cpp_type = 1

ONCHATPUSH_S2C_TIME_FIELD.name = "s2c_time"
ONCHATPUSH_S2C_TIME_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_time"
ONCHATPUSH_S2C_TIME_FIELD.number = 6
ONCHATPUSH_S2C_TIME_FIELD.index = 4
ONCHATPUSH_S2C_TIME_FIELD.label = 1
ONCHATPUSH_S2C_TIME_FIELD.has_default_value = false
ONCHATPUSH_S2C_TIME_FIELD.default_value = ""
ONCHATPUSH_S2C_TIME_FIELD.type = 9
ONCHATPUSH_S2C_TIME_FIELD.cpp_type = 9

ONCHATPUSH_S2C_SYS_FIELD.name = "s2c_sys"
ONCHATPUSH_S2C_SYS_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_sys"
ONCHATPUSH_S2C_SYS_FIELD.number = 7
ONCHATPUSH_S2C_SYS_FIELD.index = 5
ONCHATPUSH_S2C_SYS_FIELD.label = 1
ONCHATPUSH_S2C_SYS_FIELD.has_default_value = false
ONCHATPUSH_S2C_SYS_FIELD.default_value = 0
ONCHATPUSH_S2C_SYS_FIELD.type = 5
ONCHATPUSH_S2C_SYS_FIELD.cpp_type = 1

ONCHATPUSH_S2C_INDEX_FIELD.name = "s2c_index"
ONCHATPUSH_S2C_INDEX_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_index"
ONCHATPUSH_S2C_INDEX_FIELD.number = 8
ONCHATPUSH_S2C_INDEX_FIELD.index = 6
ONCHATPUSH_S2C_INDEX_FIELD.label = 1
ONCHATPUSH_S2C_INDEX_FIELD.has_default_value = false
ONCHATPUSH_S2C_INDEX_FIELD.default_value = 0
ONCHATPUSH_S2C_INDEX_FIELD.type = 5
ONCHATPUSH_S2C_INDEX_FIELD.cpp_type = 1

ONCHATPUSH_S2C_SERVERDATA_FIELD.name = "s2c_serverData"
ONCHATPUSH_S2C_SERVERDATA_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_serverData"
ONCHATPUSH_S2C_SERVERDATA_FIELD.number = 9
ONCHATPUSH_S2C_SERVERDATA_FIELD.index = 7
ONCHATPUSH_S2C_SERVERDATA_FIELD.label = 1
ONCHATPUSH_S2C_SERVERDATA_FIELD.has_default_value = false
ONCHATPUSH_S2C_SERVERDATA_FIELD.default_value = ""
ONCHATPUSH_S2C_SERVERDATA_FIELD.type = 9
ONCHATPUSH_S2C_SERVERDATA_FIELD.cpp_type = 9

ONCHATPUSH_S2C_ACCEPTRID_FIELD.name = "s2c_acceptRid"
ONCHATPUSH_S2C_ACCEPTRID_FIELD.full_name = ".pomelo.chat.OnChatPush.s2c_acceptRid"
ONCHATPUSH_S2C_ACCEPTRID_FIELD.number = 10
ONCHATPUSH_S2C_ACCEPTRID_FIELD.index = 8
ONCHATPUSH_S2C_ACCEPTRID_FIELD.label = 1
ONCHATPUSH_S2C_ACCEPTRID_FIELD.has_default_value = false
ONCHATPUSH_S2C_ACCEPTRID_FIELD.default_value = ""
ONCHATPUSH_S2C_ACCEPTRID_FIELD.type = 9
ONCHATPUSH_S2C_ACCEPTRID_FIELD.cpp_type = 9

ONCHATPUSH.name = "OnChatPush"
ONCHATPUSH.full_name = ".pomelo.chat.OnChatPush"
ONCHATPUSH.nested_types = {}
ONCHATPUSH.enum_types = {}
ONCHATPUSH.fields = {ONCHATPUSH_S2C_PLAYERID_FIELD, ONCHATPUSH_S2C_UID_FIELD, ONCHATPUSH_S2C_CONTENT_FIELD, ONCHATPUSH_S2C_SCOPE_FIELD, ONCHATPUSH_S2C_TIME_FIELD, ONCHATPUSH_S2C_SYS_FIELD, ONCHATPUSH_S2C_INDEX_FIELD, ONCHATPUSH_S2C_SERVERDATA_FIELD, ONCHATPUSH_S2C_ACCEPTRID_FIELD}
ONCHATPUSH.is_extendable = false
ONCHATPUSH.extensions = {}
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgResponse.s2c_code"
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.number = 1
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.index = 0
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.label = 2
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.has_default_value = false
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.default_value = 0
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.type = 5
GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD.cpp_type = 1

GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgResponse.s2c_msg"
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.number = 2
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.index = 1
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.label = 1
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.has_default_value = false
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.default_value = ""
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.type = 9
GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD.cpp_type = 9

GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.name = "s2c_data"
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.full_name = ".pomelo.chat.GetSaveChatMsgResponse.s2c_data"
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.number = 3
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.index = 2
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.label = 3
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.has_default_value = false
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.default_value = {}
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.message_type = ONCHATPUSH
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.type = 11
GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD.cpp_type = 10

GETSAVECHATMSGRESPONSE.name = "GetSaveChatMsgResponse"
GETSAVECHATMSGRESPONSE.full_name = ".pomelo.chat.GetSaveChatMsgResponse"
GETSAVECHATMSGRESPONSE.nested_types = {}
GETSAVECHATMSGRESPONSE.enum_types = {}
GETSAVECHATMSGRESPONSE.fields = {GETSAVECHATMSGRESPONSE_S2C_CODE_FIELD, GETSAVECHATMSGRESPONSE_S2C_MSG_FIELD, GETSAVECHATMSGRESPONSE_S2C_DATA_FIELD}
GETSAVECHATMSGRESPONSE.is_extendable = false
GETSAVECHATMSGRESPONSE.extensions = {}
ONCHATERRORPUSH_S2C_CODE_FIELD.name = "s2c_code"
ONCHATERRORPUSH_S2C_CODE_FIELD.full_name = ".pomelo.chat.OnChatErrorPush.s2c_code"
ONCHATERRORPUSH_S2C_CODE_FIELD.number = 1
ONCHATERRORPUSH_S2C_CODE_FIELD.index = 0
ONCHATERRORPUSH_S2C_CODE_FIELD.label = 2
ONCHATERRORPUSH_S2C_CODE_FIELD.has_default_value = false
ONCHATERRORPUSH_S2C_CODE_FIELD.default_value = 0
ONCHATERRORPUSH_S2C_CODE_FIELD.type = 5
ONCHATERRORPUSH_S2C_CODE_FIELD.cpp_type = 1

ONCHATERRORPUSH_S2C_MSG_FIELD.name = "s2c_msg"
ONCHATERRORPUSH_S2C_MSG_FIELD.full_name = ".pomelo.chat.OnChatErrorPush.s2c_msg"
ONCHATERRORPUSH_S2C_MSG_FIELD.number = 2
ONCHATERRORPUSH_S2C_MSG_FIELD.index = 1
ONCHATERRORPUSH_S2C_MSG_FIELD.label = 2
ONCHATERRORPUSH_S2C_MSG_FIELD.has_default_value = false
ONCHATERRORPUSH_S2C_MSG_FIELD.default_value = ""
ONCHATERRORPUSH_S2C_MSG_FIELD.type = 9
ONCHATERRORPUSH_S2C_MSG_FIELD.cpp_type = 9

ONCHATERRORPUSH.name = "OnChatErrorPush"
ONCHATERRORPUSH.full_name = ".pomelo.chat.OnChatErrorPush"
ONCHATERRORPUSH.nested_types = {}
ONCHATERRORPUSH.enum_types = {}
ONCHATERRORPUSH.fields = {ONCHATERRORPUSH_S2C_CODE_FIELD, ONCHATERRORPUSH_S2C_MSG_FIELD}
ONCHATERRORPUSH.is_extendable = false
ONCHATERRORPUSH.extensions = {}
TIPPUSH_S2C_MSG_FIELD.name = "s2c_msg"
TIPPUSH_S2C_MSG_FIELD.full_name = ".pomelo.chat.TipPush.s2c_msg"
TIPPUSH_S2C_MSG_FIELD.number = 2
TIPPUSH_S2C_MSG_FIELD.index = 0
TIPPUSH_S2C_MSG_FIELD.label = 2
TIPPUSH_S2C_MSG_FIELD.has_default_value = false
TIPPUSH_S2C_MSG_FIELD.default_value = ""
TIPPUSH_S2C_MSG_FIELD.type = 9
TIPPUSH_S2C_MSG_FIELD.cpp_type = 9

TIPPUSH_S2C_TYPE_FIELD.name = "s2c_type"
TIPPUSH_S2C_TYPE_FIELD.full_name = ".pomelo.chat.TipPush.s2c_type"
TIPPUSH_S2C_TYPE_FIELD.number = 3
TIPPUSH_S2C_TYPE_FIELD.index = 1
TIPPUSH_S2C_TYPE_FIELD.label = 2
TIPPUSH_S2C_TYPE_FIELD.has_default_value = false
TIPPUSH_S2C_TYPE_FIELD.default_value = 0
TIPPUSH_S2C_TYPE_FIELD.type = 5
TIPPUSH_S2C_TYPE_FIELD.cpp_type = 1

TIPPUSH.name = "TipPush"
TIPPUSH.full_name = ".pomelo.chat.TipPush"
TIPPUSH.nested_types = {}
TIPPUSH.enum_types = {}
TIPPUSH.fields = {TIPPUSH_S2C_MSG_FIELD, TIPPUSH_S2C_TYPE_FIELD}
TIPPUSH.is_extendable = false
TIPPUSH.extensions = {}

GetSaveChatMsgRequest = protobuf.Message(GETSAVECHATMSGREQUEST)
GetSaveChatMsgResponse = protobuf.Message(GETSAVECHATMSGRESPONSE)
OnChatErrorPush = protobuf.Message(ONCHATERRORPUSH)
OnChatPush = protobuf.Message(ONCHATPUSH)
SendChatRequest = protobuf.Message(SENDCHATREQUEST)
SendChatResponse = protobuf.Message(SENDCHATRESPONSE)
TipPush = protobuf.Message(TIPPUSH)

