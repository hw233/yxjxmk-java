-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
local common_pb = require("common_pb")
module('wingHandler_pb')


WINGDATA = protobuf.Descriptor();
local WINGDATA_CURRLEVEL_FIELD = protobuf.FieldDescriptor();
local WINGDATA_CURRSTAR_FIELD = protobuf.FieldDescriptor();
local WINGDATA_CURREXP_FIELD = protobuf.FieldDescriptor();
local WINGDATA_CURRREIKI_FIELD = protobuf.FieldDescriptor();
local WINGDATA_FIGHTPOWER_FIELD = protobuf.FieldDescriptor();
local WINGDATA_SAVEDLEVEL_FIELD = protobuf.FieldDescriptor();
GETWINGINFOREQUEST = protobuf.Descriptor();
GETWINGINFORESPONSE = protobuf.Descriptor();
local GETWINGINFORESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local GETWINGINFORESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local GETWINGINFORESPONSE_S2C_WINGDATA_FIELD = protobuf.FieldDescriptor();
TRAININGWINGREQUEST = protobuf.Descriptor();
local TRAININGWINGREQUEST_C2S_TYPE_FIELD = protobuf.FieldDescriptor();
TRAININGWINGRESPONSE = protobuf.Descriptor();
local TRAININGWINGRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local TRAININGWINGRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD = protobuf.FieldDescriptor();
SAVEWINGNOTIFY = protobuf.Descriptor();
local SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD = protobuf.FieldDescriptor();

WINGDATA_CURRLEVEL_FIELD.name = "currLevel"
WINGDATA_CURRLEVEL_FIELD.full_name = ".pomelo.area.WingData.currLevel"
WINGDATA_CURRLEVEL_FIELD.number = 1
WINGDATA_CURRLEVEL_FIELD.index = 0
WINGDATA_CURRLEVEL_FIELD.label = 2
WINGDATA_CURRLEVEL_FIELD.has_default_value = false
WINGDATA_CURRLEVEL_FIELD.default_value = 0
WINGDATA_CURRLEVEL_FIELD.type = 5
WINGDATA_CURRLEVEL_FIELD.cpp_type = 1

WINGDATA_CURRSTAR_FIELD.name = "currStar"
WINGDATA_CURRSTAR_FIELD.full_name = ".pomelo.area.WingData.currStar"
WINGDATA_CURRSTAR_FIELD.number = 2
WINGDATA_CURRSTAR_FIELD.index = 1
WINGDATA_CURRSTAR_FIELD.label = 2
WINGDATA_CURRSTAR_FIELD.has_default_value = false
WINGDATA_CURRSTAR_FIELD.default_value = 0
WINGDATA_CURRSTAR_FIELD.type = 5
WINGDATA_CURRSTAR_FIELD.cpp_type = 1

WINGDATA_CURREXP_FIELD.name = "currExp"
WINGDATA_CURREXP_FIELD.full_name = ".pomelo.area.WingData.currExp"
WINGDATA_CURREXP_FIELD.number = 3
WINGDATA_CURREXP_FIELD.index = 2
WINGDATA_CURREXP_FIELD.label = 2
WINGDATA_CURREXP_FIELD.has_default_value = false
WINGDATA_CURREXP_FIELD.default_value = 0
WINGDATA_CURREXP_FIELD.type = 5
WINGDATA_CURREXP_FIELD.cpp_type = 1

WINGDATA_CURRREIKI_FIELD.name = "currReiki"
WINGDATA_CURRREIKI_FIELD.full_name = ".pomelo.area.WingData.currReiki"
WINGDATA_CURRREIKI_FIELD.number = 4
WINGDATA_CURRREIKI_FIELD.index = 3
WINGDATA_CURRREIKI_FIELD.label = 2
WINGDATA_CURRREIKI_FIELD.has_default_value = false
WINGDATA_CURRREIKI_FIELD.default_value = 0
WINGDATA_CURRREIKI_FIELD.type = 5
WINGDATA_CURRREIKI_FIELD.cpp_type = 1

WINGDATA_FIGHTPOWER_FIELD.name = "fightPower"
WINGDATA_FIGHTPOWER_FIELD.full_name = ".pomelo.area.WingData.fightPower"
WINGDATA_FIGHTPOWER_FIELD.number = 5
WINGDATA_FIGHTPOWER_FIELD.index = 4
WINGDATA_FIGHTPOWER_FIELD.label = 2
WINGDATA_FIGHTPOWER_FIELD.has_default_value = false
WINGDATA_FIGHTPOWER_FIELD.default_value = 0
WINGDATA_FIGHTPOWER_FIELD.type = 5
WINGDATA_FIGHTPOWER_FIELD.cpp_type = 1

WINGDATA_SAVEDLEVEL_FIELD.name = "savedLevel"
WINGDATA_SAVEDLEVEL_FIELD.full_name = ".pomelo.area.WingData.savedLevel"
WINGDATA_SAVEDLEVEL_FIELD.number = 6
WINGDATA_SAVEDLEVEL_FIELD.index = 5
WINGDATA_SAVEDLEVEL_FIELD.label = 1
WINGDATA_SAVEDLEVEL_FIELD.has_default_value = false
WINGDATA_SAVEDLEVEL_FIELD.default_value = 0
WINGDATA_SAVEDLEVEL_FIELD.type = 5
WINGDATA_SAVEDLEVEL_FIELD.cpp_type = 1

WINGDATA.name = "WingData"
WINGDATA.full_name = ".pomelo.area.WingData"
WINGDATA.nested_types = {}
WINGDATA.enum_types = {}
WINGDATA.fields = {WINGDATA_CURRLEVEL_FIELD, WINGDATA_CURRSTAR_FIELD, WINGDATA_CURREXP_FIELD, WINGDATA_CURRREIKI_FIELD, WINGDATA_FIGHTPOWER_FIELD, WINGDATA_SAVEDLEVEL_FIELD}
WINGDATA.is_extendable = false
WINGDATA.extensions = {}
GETWINGINFOREQUEST.name = "GetWingInfoRequest"
GETWINGINFOREQUEST.full_name = ".pomelo.area.GetWingInfoRequest"
GETWINGINFOREQUEST.nested_types = {}
GETWINGINFOREQUEST.enum_types = {}
GETWINGINFOREQUEST.fields = {}
GETWINGINFOREQUEST.is_extendable = false
GETWINGINFOREQUEST.extensions = {}
GETWINGINFORESPONSE_S2C_CODE_FIELD.name = "s2c_code"
GETWINGINFORESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.GetWingInfoResponse.s2c_code"
GETWINGINFORESPONSE_S2C_CODE_FIELD.number = 1
GETWINGINFORESPONSE_S2C_CODE_FIELD.index = 0
GETWINGINFORESPONSE_S2C_CODE_FIELD.label = 2
GETWINGINFORESPONSE_S2C_CODE_FIELD.has_default_value = false
GETWINGINFORESPONSE_S2C_CODE_FIELD.default_value = 0
GETWINGINFORESPONSE_S2C_CODE_FIELD.type = 5
GETWINGINFORESPONSE_S2C_CODE_FIELD.cpp_type = 1

GETWINGINFORESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
GETWINGINFORESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.GetWingInfoResponse.s2c_msg"
GETWINGINFORESPONSE_S2C_MSG_FIELD.number = 2
GETWINGINFORESPONSE_S2C_MSG_FIELD.index = 1
GETWINGINFORESPONSE_S2C_MSG_FIELD.label = 1
GETWINGINFORESPONSE_S2C_MSG_FIELD.has_default_value = false
GETWINGINFORESPONSE_S2C_MSG_FIELD.default_value = ""
GETWINGINFORESPONSE_S2C_MSG_FIELD.type = 9
GETWINGINFORESPONSE_S2C_MSG_FIELD.cpp_type = 9

GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.name = "s2c_wingData"
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.full_name = ".pomelo.area.GetWingInfoResponse.s2c_wingData"
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.number = 3
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.index = 2
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.label = 1
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.has_default_value = false
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.default_value = nil
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.message_type = WINGDATA
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.type = 11
GETWINGINFORESPONSE_S2C_WINGDATA_FIELD.cpp_type = 10

GETWINGINFORESPONSE.name = "GetWingInfoResponse"
GETWINGINFORESPONSE.full_name = ".pomelo.area.GetWingInfoResponse"
GETWINGINFORESPONSE.nested_types = {}
GETWINGINFORESPONSE.enum_types = {}
GETWINGINFORESPONSE.fields = {GETWINGINFORESPONSE_S2C_CODE_FIELD, GETWINGINFORESPONSE_S2C_MSG_FIELD, GETWINGINFORESPONSE_S2C_WINGDATA_FIELD}
GETWINGINFORESPONSE.is_extendable = false
GETWINGINFORESPONSE.extensions = {}
TRAININGWINGREQUEST_C2S_TYPE_FIELD.name = "c2s_type"
TRAININGWINGREQUEST_C2S_TYPE_FIELD.full_name = ".pomelo.area.TrainingWingRequest.c2s_type"
TRAININGWINGREQUEST_C2S_TYPE_FIELD.number = 1
TRAININGWINGREQUEST_C2S_TYPE_FIELD.index = 0
TRAININGWINGREQUEST_C2S_TYPE_FIELD.label = 2
TRAININGWINGREQUEST_C2S_TYPE_FIELD.has_default_value = false
TRAININGWINGREQUEST_C2S_TYPE_FIELD.default_value = 0
TRAININGWINGREQUEST_C2S_TYPE_FIELD.type = 5
TRAININGWINGREQUEST_C2S_TYPE_FIELD.cpp_type = 1

TRAININGWINGREQUEST.name = "TrainingWingRequest"
TRAININGWINGREQUEST.full_name = ".pomelo.area.TrainingWingRequest"
TRAININGWINGREQUEST.nested_types = {}
TRAININGWINGREQUEST.enum_types = {}
TRAININGWINGREQUEST.fields = {TRAININGWINGREQUEST_C2S_TYPE_FIELD}
TRAININGWINGREQUEST.is_extendable = false
TRAININGWINGREQUEST.extensions = {}
TRAININGWINGRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
TRAININGWINGRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.TrainingWingResponse.s2c_code"
TRAININGWINGRESPONSE_S2C_CODE_FIELD.number = 1
TRAININGWINGRESPONSE_S2C_CODE_FIELD.index = 0
TRAININGWINGRESPONSE_S2C_CODE_FIELD.label = 2
TRAININGWINGRESPONSE_S2C_CODE_FIELD.has_default_value = false
TRAININGWINGRESPONSE_S2C_CODE_FIELD.default_value = 0
TRAININGWINGRESPONSE_S2C_CODE_FIELD.type = 5
TRAININGWINGRESPONSE_S2C_CODE_FIELD.cpp_type = 1

TRAININGWINGRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
TRAININGWINGRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.TrainingWingResponse.s2c_msg"
TRAININGWINGRESPONSE_S2C_MSG_FIELD.number = 2
TRAININGWINGRESPONSE_S2C_MSG_FIELD.index = 1
TRAININGWINGRESPONSE_S2C_MSG_FIELD.label = 1
TRAININGWINGRESPONSE_S2C_MSG_FIELD.has_default_value = false
TRAININGWINGRESPONSE_S2C_MSG_FIELD.default_value = ""
TRAININGWINGRESPONSE_S2C_MSG_FIELD.type = 9
TRAININGWINGRESPONSE_S2C_MSG_FIELD.cpp_type = 9

TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.name = "s2c_wingData"
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.full_name = ".pomelo.area.TrainingWingResponse.s2c_wingData"
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.number = 3
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.index = 2
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.label = 1
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.has_default_value = false
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.default_value = nil
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.message_type = WINGDATA
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.type = 11
TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD.cpp_type = 10

TRAININGWINGRESPONSE.name = "TrainingWingResponse"
TRAININGWINGRESPONSE.full_name = ".pomelo.area.TrainingWingResponse"
TRAININGWINGRESPONSE.nested_types = {}
TRAININGWINGRESPONSE.enum_types = {}
TRAININGWINGRESPONSE.fields = {TRAININGWINGRESPONSE_S2C_CODE_FIELD, TRAININGWINGRESPONSE_S2C_MSG_FIELD, TRAININGWINGRESPONSE_S2C_WINGDATA_FIELD}
TRAININGWINGRESPONSE.is_extendable = false
TRAININGWINGRESPONSE.extensions = {}
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.name = "c2s_wingLevel"
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.full_name = ".pomelo.area.SaveWingNotify.c2s_wingLevel"
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.number = 1
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.index = 0
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.label = 2
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.has_default_value = false
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.default_value = 0
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.type = 5
SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD.cpp_type = 1

SAVEWINGNOTIFY.name = "SaveWingNotify"
SAVEWINGNOTIFY.full_name = ".pomelo.area.SaveWingNotify"
SAVEWINGNOTIFY.nested_types = {}
SAVEWINGNOTIFY.enum_types = {}
SAVEWINGNOTIFY.fields = {SAVEWINGNOTIFY_C2S_WINGLEVEL_FIELD}
SAVEWINGNOTIFY.is_extendable = false
SAVEWINGNOTIFY.extensions = {}

GetWingInfoRequest = protobuf.Message(GETWINGINFOREQUEST)
GetWingInfoResponse = protobuf.Message(GETWINGINFORESPONSE)
SaveWingNotify = protobuf.Message(SAVEWINGNOTIFY)
TrainingWingRequest = protobuf.Message(TRAININGWINGREQUEST)
TrainingWingResponse = protobuf.Message(TRAININGWINGRESPONSE)
WingData = protobuf.Message(WINGDATA)

