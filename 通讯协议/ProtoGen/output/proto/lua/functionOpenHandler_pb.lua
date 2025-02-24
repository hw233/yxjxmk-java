-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
local common_pb = require("common_pb")
local player_pb = require("player_pb")
module('functionOpenHandler_pb')


GETFUNCTIONLISTREQUEST = protobuf.Descriptor();
GETFUNCTIONLISTRESPONSE = protobuf.Descriptor();
local GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD = protobuf.FieldDescriptor();
SETFUNCTIONPLAYEDREQUEST = protobuf.Descriptor();
local SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD = protobuf.FieldDescriptor();
SETFUNCTIONPLAYEDRESPONSE = protobuf.Descriptor();
local SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
RECEIVEFUNCTIONAWARDREQUEST = protobuf.Descriptor();
local RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD = protobuf.FieldDescriptor();
RECEIVEFUNCTIONAWARDRESPONSE = protobuf.Descriptor();
local RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
FUNCTIONOPENLISTPUSH = protobuf.Descriptor();
local FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD = protobuf.FieldDescriptor();
local FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD = protobuf.FieldDescriptor();
FUNCTIONAWARDLISTPUSH = protobuf.Descriptor();
local FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD = protobuf.FieldDescriptor();

GETFUNCTIONLISTREQUEST.name = "GetFunctionListRequest"
GETFUNCTIONLISTREQUEST.full_name = ".pomelo.area.GetFunctionListRequest"
GETFUNCTIONLISTREQUEST.nested_types = {}
GETFUNCTIONLISTREQUEST.enum_types = {}
GETFUNCTIONLISTREQUEST.fields = {}
GETFUNCTIONLISTREQUEST.is_extendable = false
GETFUNCTIONLISTREQUEST.extensions = {}
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.GetFunctionListResponse.s2c_code"
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.number = 1
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.index = 0
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.label = 2
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.has_default_value = false
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.default_value = 0
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.type = 5
GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD.cpp_type = 1

GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.GetFunctionListResponse.s2c_msg"
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.number = 2
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.index = 1
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.label = 1
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.has_default_value = false
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.default_value = ""
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.type = 9
GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD.cpp_type = 9

GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.name = "s2c_list"
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.full_name = ".pomelo.area.GetFunctionListResponse.s2c_list"
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.number = 3
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.index = 2
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.label = 3
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.has_default_value = false
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.default_value = {}
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.message_type = player_pb.FUNCTIONINFO
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.type = 11
GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD.cpp_type = 10

GETFUNCTIONLISTRESPONSE.name = "GetFunctionListResponse"
GETFUNCTIONLISTRESPONSE.full_name = ".pomelo.area.GetFunctionListResponse"
GETFUNCTIONLISTRESPONSE.nested_types = {}
GETFUNCTIONLISTRESPONSE.enum_types = {}
GETFUNCTIONLISTRESPONSE.fields = {GETFUNCTIONLISTRESPONSE_S2C_CODE_FIELD, GETFUNCTIONLISTRESPONSE_S2C_MSG_FIELD, GETFUNCTIONLISTRESPONSE_S2C_LIST_FIELD}
GETFUNCTIONLISTRESPONSE.is_extendable = false
GETFUNCTIONLISTRESPONSE.extensions = {}
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.name = "functionName"
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.full_name = ".pomelo.area.SetFunctionPlayedRequest.functionName"
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.number = 1
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.index = 0
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.label = 2
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.has_default_value = false
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.default_value = ""
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.type = 9
SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD.cpp_type = 9

SETFUNCTIONPLAYEDREQUEST.name = "SetFunctionPlayedRequest"
SETFUNCTIONPLAYEDREQUEST.full_name = ".pomelo.area.SetFunctionPlayedRequest"
SETFUNCTIONPLAYEDREQUEST.nested_types = {}
SETFUNCTIONPLAYEDREQUEST.enum_types = {}
SETFUNCTIONPLAYEDREQUEST.fields = {SETFUNCTIONPLAYEDREQUEST_FUNCTIONNAME_FIELD}
SETFUNCTIONPLAYEDREQUEST.is_extendable = false
SETFUNCTIONPLAYEDREQUEST.extensions = {}
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.SetFunctionPlayedResponse.s2c_code"
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.number = 1
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.index = 0
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.label = 2
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.has_default_value = false
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.default_value = 0
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.type = 5
SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD.cpp_type = 1

SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.SetFunctionPlayedResponse.s2c_msg"
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.number = 2
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.index = 1
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.label = 1
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.has_default_value = false
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.default_value = ""
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.type = 9
SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD.cpp_type = 9

SETFUNCTIONPLAYEDRESPONSE.name = "SetFunctionPlayedResponse"
SETFUNCTIONPLAYEDRESPONSE.full_name = ".pomelo.area.SetFunctionPlayedResponse"
SETFUNCTIONPLAYEDRESPONSE.nested_types = {}
SETFUNCTIONPLAYEDRESPONSE.enum_types = {}
SETFUNCTIONPLAYEDRESPONSE.fields = {SETFUNCTIONPLAYEDRESPONSE_S2C_CODE_FIELD, SETFUNCTIONPLAYEDRESPONSE_S2C_MSG_FIELD}
SETFUNCTIONPLAYEDRESPONSE.is_extendable = false
SETFUNCTIONPLAYEDRESPONSE.extensions = {}
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.name = "guide_id"
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.full_name = ".pomelo.area.ReceiveFunctionAwardRequest.guide_id"
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.number = 1
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.index = 0
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.label = 2
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.has_default_value = false
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.default_value = 0
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.type = 5
RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD.cpp_type = 1

RECEIVEFUNCTIONAWARDREQUEST.name = "ReceiveFunctionAwardRequest"
RECEIVEFUNCTIONAWARDREQUEST.full_name = ".pomelo.area.ReceiveFunctionAwardRequest"
RECEIVEFUNCTIONAWARDREQUEST.nested_types = {}
RECEIVEFUNCTIONAWARDREQUEST.enum_types = {}
RECEIVEFUNCTIONAWARDREQUEST.fields = {RECEIVEFUNCTIONAWARDREQUEST_GUIDE_ID_FIELD}
RECEIVEFUNCTIONAWARDREQUEST.is_extendable = false
RECEIVEFUNCTIONAWARDREQUEST.extensions = {}
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.ReceiveFunctionAwardResponse.s2c_code"
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.number = 1
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.index = 0
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.label = 2
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.has_default_value = false
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.default_value = 0
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.type = 5
RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD.cpp_type = 1

RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.ReceiveFunctionAwardResponse.s2c_msg"
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.number = 2
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.index = 1
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.label = 1
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.has_default_value = false
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.default_value = ""
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.type = 9
RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD.cpp_type = 9

RECEIVEFUNCTIONAWARDRESPONSE.name = "ReceiveFunctionAwardResponse"
RECEIVEFUNCTIONAWARDRESPONSE.full_name = ".pomelo.area.ReceiveFunctionAwardResponse"
RECEIVEFUNCTIONAWARDRESPONSE.nested_types = {}
RECEIVEFUNCTIONAWARDRESPONSE.enum_types = {}
RECEIVEFUNCTIONAWARDRESPONSE.fields = {RECEIVEFUNCTIONAWARDRESPONSE_S2C_CODE_FIELD, RECEIVEFUNCTIONAWARDRESPONSE_S2C_MSG_FIELD}
RECEIVEFUNCTIONAWARDRESPONSE.is_extendable = false
RECEIVEFUNCTIONAWARDRESPONSE.extensions = {}
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.name = "s2c_code"
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.full_name = ".pomelo.area.FunctionOpenListPush.s2c_code"
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.number = 1
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.index = 0
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.label = 2
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.has_default_value = false
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.default_value = 0
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.type = 5
FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD.cpp_type = 1

FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.name = "s2c_msg"
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.full_name = ".pomelo.area.FunctionOpenListPush.s2c_msg"
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.number = 2
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.index = 1
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.label = 1
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.has_default_value = false
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.default_value = ""
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.type = 9
FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD.cpp_type = 9

FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.name = "s2c_list"
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.full_name = ".pomelo.area.FunctionOpenListPush.s2c_list"
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.number = 3
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.index = 2
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.label = 3
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.has_default_value = false
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.default_value = {}
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.message_type = player_pb.FUNCTIONINFO
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.type = 11
FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD.cpp_type = 10

FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.name = "s2c_isAll"
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.full_name = ".pomelo.area.FunctionOpenListPush.s2c_isAll"
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.number = 4
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.index = 3
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.label = 1
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.has_default_value = false
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.default_value = 0
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.type = 5
FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD.cpp_type = 1

FUNCTIONOPENLISTPUSH.name = "FunctionOpenListPush"
FUNCTIONOPENLISTPUSH.full_name = ".pomelo.area.FunctionOpenListPush"
FUNCTIONOPENLISTPUSH.nested_types = {}
FUNCTIONOPENLISTPUSH.enum_types = {}
FUNCTIONOPENLISTPUSH.fields = {FUNCTIONOPENLISTPUSH_S2C_CODE_FIELD, FUNCTIONOPENLISTPUSH_S2C_MSG_FIELD, FUNCTIONOPENLISTPUSH_S2C_LIST_FIELD, FUNCTIONOPENLISTPUSH_S2C_ISALL_FIELD}
FUNCTIONOPENLISTPUSH.is_extendable = false
FUNCTIONOPENLISTPUSH.extensions = {}
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.name = "guideIds"
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.full_name = ".pomelo.area.FunctionAwardListPush.guideIds"
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.number = 1
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.index = 0
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.label = 3
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.has_default_value = false
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.default_value = {}
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.type = 5
FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD.cpp_type = 1

FUNCTIONAWARDLISTPUSH.name = "FunctionAwardListPush"
FUNCTIONAWARDLISTPUSH.full_name = ".pomelo.area.FunctionAwardListPush"
FUNCTIONAWARDLISTPUSH.nested_types = {}
FUNCTIONAWARDLISTPUSH.enum_types = {}
FUNCTIONAWARDLISTPUSH.fields = {FUNCTIONAWARDLISTPUSH_GUIDEIDS_FIELD}
FUNCTIONAWARDLISTPUSH.is_extendable = false
FUNCTIONAWARDLISTPUSH.extensions = {}

FunctionAwardListPush = protobuf.Message(FUNCTIONAWARDLISTPUSH)
FunctionOpenListPush = protobuf.Message(FUNCTIONOPENLISTPUSH)
GetFunctionListRequest = protobuf.Message(GETFUNCTIONLISTREQUEST)
GetFunctionListResponse = protobuf.Message(GETFUNCTIONLISTRESPONSE)
ReceiveFunctionAwardRequest = protobuf.Message(RECEIVEFUNCTIONAWARDREQUEST)
ReceiveFunctionAwardResponse = protobuf.Message(RECEIVEFUNCTIONAWARDRESPONSE)
SetFunctionPlayedRequest = protobuf.Message(SETFUNCTIONPLAYEDREQUEST)
SetFunctionPlayedResponse = protobuf.Message(SETFUNCTIONPLAYEDRESPONSE)

