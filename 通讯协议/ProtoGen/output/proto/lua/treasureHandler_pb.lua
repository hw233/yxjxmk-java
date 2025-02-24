-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
module('treasureHandler_pb')


OPENTYPE = protobuf.EnumDescriptor();
local OPENTYPE_OPEN_ONE_ENUM = protobuf.EnumValueDescriptor();
local OPENTYPE_OPEN_TEN_ENUM = protobuf.EnumValueDescriptor();
TREASUREITEM = protobuf.Descriptor();
local TREASUREITEM_ITEMCODE_FIELD = protobuf.FieldDescriptor();
local TREASUREITEM_ITEMNUM_FIELD = protobuf.FieldDescriptor();
local TREASUREITEM_ISBIND_FIELD = protobuf.FieldDescriptor();
local TREASUREITEM_SCORE_FIELD = protobuf.FieldDescriptor();
GETTREASUREINFOREQUEST = protobuf.Descriptor();
local GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD = protobuf.FieldDescriptor();
GETTREASUREINFORESPONSE = protobuf.Descriptor();
local GETTREASUREINFORESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local GETTREASUREINFORESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD = protobuf.FieldDescriptor();
local GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD = protobuf.FieldDescriptor();
GETTREASUREBAGINFOREQUEST = protobuf.Descriptor();
GETTREASUREBAGINFORESPONSE = protobuf.Descriptor();
local GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD = protobuf.FieldDescriptor();
OPENTREASUREREQUEST = protobuf.Descriptor();
local OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD = protobuf.FieldDescriptor();
local OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD = protobuf.FieldDescriptor();
OPENTREASURERESPONSE = protobuf.Descriptor();
local OPENTREASURERESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local OPENTREASURERESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();
local OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD = protobuf.FieldDescriptor();
RECEIVETREASUREBAGREQUEST = protobuf.Descriptor();
RECEIVETREASUREBAGRESPONSE = protobuf.Descriptor();
local RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD = protobuf.FieldDescriptor();
local RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD = protobuf.FieldDescriptor();

OPENTYPE_OPEN_ONE_ENUM.name = "OPEN_ONE"
OPENTYPE_OPEN_ONE_ENUM.index = 0
OPENTYPE_OPEN_ONE_ENUM.number = 1
OPENTYPE_OPEN_TEN_ENUM.name = "OPEN_TEN"
OPENTYPE_OPEN_TEN_ENUM.index = 1
OPENTYPE_OPEN_TEN_ENUM.number = 2
OPENTYPE.name = "OpenType"
OPENTYPE.full_name = ".pomelo.area.OpenType"
OPENTYPE.values = {OPENTYPE_OPEN_ONE_ENUM,OPENTYPE_OPEN_TEN_ENUM}
TREASUREITEM_ITEMCODE_FIELD.name = "itemCode"
TREASUREITEM_ITEMCODE_FIELD.full_name = ".pomelo.area.TreasureItem.itemCode"
TREASUREITEM_ITEMCODE_FIELD.number = 1
TREASUREITEM_ITEMCODE_FIELD.index = 0
TREASUREITEM_ITEMCODE_FIELD.label = 2
TREASUREITEM_ITEMCODE_FIELD.has_default_value = false
TREASUREITEM_ITEMCODE_FIELD.default_value = ""
TREASUREITEM_ITEMCODE_FIELD.type = 9
TREASUREITEM_ITEMCODE_FIELD.cpp_type = 9

TREASUREITEM_ITEMNUM_FIELD.name = "itemNum"
TREASUREITEM_ITEMNUM_FIELD.full_name = ".pomelo.area.TreasureItem.itemNum"
TREASUREITEM_ITEMNUM_FIELD.number = 2
TREASUREITEM_ITEMNUM_FIELD.index = 1
TREASUREITEM_ITEMNUM_FIELD.label = 2
TREASUREITEM_ITEMNUM_FIELD.has_default_value = false
TREASUREITEM_ITEMNUM_FIELD.default_value = 0
TREASUREITEM_ITEMNUM_FIELD.type = 5
TREASUREITEM_ITEMNUM_FIELD.cpp_type = 1

TREASUREITEM_ISBIND_FIELD.name = "isBind"
TREASUREITEM_ISBIND_FIELD.full_name = ".pomelo.area.TreasureItem.isBind"
TREASUREITEM_ISBIND_FIELD.number = 3
TREASUREITEM_ISBIND_FIELD.index = 2
TREASUREITEM_ISBIND_FIELD.label = 1
TREASUREITEM_ISBIND_FIELD.has_default_value = false
TREASUREITEM_ISBIND_FIELD.default_value = 0
TREASUREITEM_ISBIND_FIELD.type = 5
TREASUREITEM_ISBIND_FIELD.cpp_type = 1

TREASUREITEM_SCORE_FIELD.name = "score"
TREASUREITEM_SCORE_FIELD.full_name = ".pomelo.area.TreasureItem.score"
TREASUREITEM_SCORE_FIELD.number = 4
TREASUREITEM_SCORE_FIELD.index = 3
TREASUREITEM_SCORE_FIELD.label = 1
TREASUREITEM_SCORE_FIELD.has_default_value = false
TREASUREITEM_SCORE_FIELD.default_value = 0
TREASUREITEM_SCORE_FIELD.type = 5
TREASUREITEM_SCORE_FIELD.cpp_type = 1

TREASUREITEM.name = "TreasureItem"
TREASUREITEM.full_name = ".pomelo.area.TreasureItem"
TREASUREITEM.nested_types = {}
TREASUREITEM.enum_types = {}
TREASUREITEM.fields = {TREASUREITEM_ITEMCODE_FIELD, TREASUREITEM_ITEMNUM_FIELD, TREASUREITEM_ISBIND_FIELD, TREASUREITEM_SCORE_FIELD}
TREASUREITEM.is_extendable = false
TREASUREITEM.extensions = {}
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.name = "c2s_treasureMsg"
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.full_name = ".pomelo.area.GetTreasureInfoRequest.c2s_treasureMsg"
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.number = 1
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.index = 0
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.label = 2
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.has_default_value = false
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.default_value = 0
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.type = 5
GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD.cpp_type = 1

GETTREASUREINFOREQUEST.name = "GetTreasureInfoRequest"
GETTREASUREINFOREQUEST.full_name = ".pomelo.area.GetTreasureInfoRequest"
GETTREASUREINFOREQUEST.nested_types = {}
GETTREASUREINFOREQUEST.enum_types = {}
GETTREASUREINFOREQUEST.fields = {GETTREASUREINFOREQUEST_C2S_TREASUREMSG_FIELD}
GETTREASUREINFOREQUEST.is_extendable = false
GETTREASUREINFOREQUEST.extensions = {}
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.name = "s2c_code"
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.GetTreasureInfoResponse.s2c_code"
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.number = 1
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.index = 0
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.label = 2
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.has_default_value = false
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.default_value = 0
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.type = 5
GETTREASUREINFORESPONSE_S2C_CODE_FIELD.cpp_type = 1

GETTREASUREINFORESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.GetTreasureInfoResponse.s2c_msg"
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.number = 2
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.index = 1
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.label = 1
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.has_default_value = false
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.default_value = ""
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.type = 9
GETTREASUREINFORESPONSE_S2C_MSG_FIELD.cpp_type = 9

GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.name = "s2c_treasureBagSize"
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.full_name = ".pomelo.area.GetTreasureInfoResponse.s2c_treasureBagSize"
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.number = 3
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.index = 2
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.label = 2
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.has_default_value = false
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.default_value = 0
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.type = 5
GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD.cpp_type = 1

GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.name = "s2c_treasureMsg"
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.full_name = ".pomelo.area.GetTreasureInfoResponse.s2c_treasureMsg"
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.number = 4
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.index = 3
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.label = 3
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.has_default_value = false
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.default_value = {}
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.type = 9
GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD.cpp_type = 9

GETTREASUREINFORESPONSE.name = "GetTreasureInfoResponse"
GETTREASUREINFORESPONSE.full_name = ".pomelo.area.GetTreasureInfoResponse"
GETTREASUREINFORESPONSE.nested_types = {}
GETTREASUREINFORESPONSE.enum_types = {}
GETTREASUREINFORESPONSE.fields = {GETTREASUREINFORESPONSE_S2C_CODE_FIELD, GETTREASUREINFORESPONSE_S2C_MSG_FIELD, GETTREASUREINFORESPONSE_S2C_TREASUREBAGSIZE_FIELD, GETTREASUREINFORESPONSE_S2C_TREASUREMSG_FIELD}
GETTREASUREINFORESPONSE.is_extendable = false
GETTREASUREINFORESPONSE.extensions = {}
GETTREASUREBAGINFOREQUEST.name = "GetTreasureBagInfoRequest"
GETTREASUREBAGINFOREQUEST.full_name = ".pomelo.area.GetTreasureBagInfoRequest"
GETTREASUREBAGINFOREQUEST.nested_types = {}
GETTREASUREBAGINFOREQUEST.enum_types = {}
GETTREASUREBAGINFOREQUEST.fields = {}
GETTREASUREBAGINFOREQUEST.is_extendable = false
GETTREASUREBAGINFOREQUEST.extensions = {}
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.name = "s2c_code"
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.GetTreasureBagInfoResponse.s2c_code"
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.number = 1
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.index = 0
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.label = 2
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.has_default_value = false
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.default_value = 0
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.type = 5
GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD.cpp_type = 1

GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.GetTreasureBagInfoResponse.s2c_msg"
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.number = 2
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.index = 1
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.label = 1
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.has_default_value = false
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.default_value = ""
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.type = 9
GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD.cpp_type = 9

GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.name = "s2c_treasureBag"
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.full_name = ".pomelo.area.GetTreasureBagInfoResponse.s2c_treasureBag"
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.number = 3
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.index = 2
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.label = 3
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.has_default_value = false
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.default_value = {}
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.message_type = TREASUREITEM
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.type = 11
GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD.cpp_type = 10

GETTREASUREBAGINFORESPONSE.name = "GetTreasureBagInfoResponse"
GETTREASUREBAGINFORESPONSE.full_name = ".pomelo.area.GetTreasureBagInfoResponse"
GETTREASUREBAGINFORESPONSE.nested_types = {}
GETTREASUREBAGINFORESPONSE.enum_types = {}
GETTREASUREBAGINFORESPONSE.fields = {GETTREASUREBAGINFORESPONSE_S2C_CODE_FIELD, GETTREASUREBAGINFORESPONSE_S2C_MSG_FIELD, GETTREASUREBAGINFORESPONSE_S2C_TREASUREBAG_FIELD}
GETTREASUREBAGINFORESPONSE.is_extendable = false
GETTREASUREBAGINFORESPONSE.extensions = {}
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.name = "c2s_openType"
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.full_name = ".pomelo.area.OpenTreasureRequest.c2s_openType"
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.number = 1
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.index = 0
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.label = 2
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.has_default_value = false
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.default_value = nil
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.enum_type = OPENTYPE
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.type = 14
OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD.cpp_type = 8

OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.name = "c2s_useDiamond"
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.full_name = ".pomelo.area.OpenTreasureRequest.c2s_useDiamond"
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.number = 2
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.index = 1
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.label = 2
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.has_default_value = false
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.default_value = 0
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.type = 5
OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD.cpp_type = 1

OPENTREASUREREQUEST.name = "OpenTreasureRequest"
OPENTREASUREREQUEST.full_name = ".pomelo.area.OpenTreasureRequest"
OPENTREASUREREQUEST.nested_types = {}
OPENTREASUREREQUEST.enum_types = {}
OPENTREASUREREQUEST.fields = {OPENTREASUREREQUEST_C2S_OPENTYPE_FIELD, OPENTREASUREREQUEST_C2S_USEDIAMOND_FIELD}
OPENTREASUREREQUEST.is_extendable = false
OPENTREASUREREQUEST.extensions = {}
OPENTREASURERESPONSE_S2C_CODE_FIELD.name = "s2c_code"
OPENTREASURERESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.OpenTreasureResponse.s2c_code"
OPENTREASURERESPONSE_S2C_CODE_FIELD.number = 1
OPENTREASURERESPONSE_S2C_CODE_FIELD.index = 0
OPENTREASURERESPONSE_S2C_CODE_FIELD.label = 2
OPENTREASURERESPONSE_S2C_CODE_FIELD.has_default_value = false
OPENTREASURERESPONSE_S2C_CODE_FIELD.default_value = 0
OPENTREASURERESPONSE_S2C_CODE_FIELD.type = 5
OPENTREASURERESPONSE_S2C_CODE_FIELD.cpp_type = 1

OPENTREASURERESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
OPENTREASURERESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.OpenTreasureResponse.s2c_msg"
OPENTREASURERESPONSE_S2C_MSG_FIELD.number = 2
OPENTREASURERESPONSE_S2C_MSG_FIELD.index = 1
OPENTREASURERESPONSE_S2C_MSG_FIELD.label = 1
OPENTREASURERESPONSE_S2C_MSG_FIELD.has_default_value = false
OPENTREASURERESPONSE_S2C_MSG_FIELD.default_value = ""
OPENTREASURERESPONSE_S2C_MSG_FIELD.type = 9
OPENTREASURERESPONSE_S2C_MSG_FIELD.cpp_type = 9

OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.name = "s2c_treasureItem"
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.full_name = ".pomelo.area.OpenTreasureResponse.s2c_treasureItem"
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.number = 3
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.index = 2
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.label = 3
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.has_default_value = false
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.default_value = {}
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.message_type = TREASUREITEM
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.type = 11
OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD.cpp_type = 10

OPENTREASURERESPONSE.name = "OpenTreasureResponse"
OPENTREASURERESPONSE.full_name = ".pomelo.area.OpenTreasureResponse"
OPENTREASURERESPONSE.nested_types = {}
OPENTREASURERESPONSE.enum_types = {}
OPENTREASURERESPONSE.fields = {OPENTREASURERESPONSE_S2C_CODE_FIELD, OPENTREASURERESPONSE_S2C_MSG_FIELD, OPENTREASURERESPONSE_S2C_TREASUREITEM_FIELD}
OPENTREASURERESPONSE.is_extendable = false
OPENTREASURERESPONSE.extensions = {}
RECEIVETREASUREBAGREQUEST.name = "ReceiveTreasureBagRequest"
RECEIVETREASUREBAGREQUEST.full_name = ".pomelo.area.ReceiveTreasureBagRequest"
RECEIVETREASUREBAGREQUEST.nested_types = {}
RECEIVETREASUREBAGREQUEST.enum_types = {}
RECEIVETREASUREBAGREQUEST.fields = {}
RECEIVETREASUREBAGREQUEST.is_extendable = false
RECEIVETREASUREBAGREQUEST.extensions = {}
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.name = "s2c_code"
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.full_name = ".pomelo.area.ReceiveTreasureBagResponse.s2c_code"
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.number = 1
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.index = 0
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.label = 2
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.has_default_value = false
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.default_value = 0
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.type = 5
RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD.cpp_type = 1

RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.name = "s2c_msg"
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.full_name = ".pomelo.area.ReceiveTreasureBagResponse.s2c_msg"
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.number = 2
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.index = 1
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.label = 1
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.has_default_value = false
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.default_value = ""
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.type = 9
RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD.cpp_type = 9

RECEIVETREASUREBAGRESPONSE.name = "ReceiveTreasureBagResponse"
RECEIVETREASUREBAGRESPONSE.full_name = ".pomelo.area.ReceiveTreasureBagResponse"
RECEIVETREASUREBAGRESPONSE.nested_types = {}
RECEIVETREASUREBAGRESPONSE.enum_types = {}
RECEIVETREASUREBAGRESPONSE.fields = {RECEIVETREASUREBAGRESPONSE_S2C_CODE_FIELD, RECEIVETREASUREBAGRESPONSE_S2C_MSG_FIELD}
RECEIVETREASUREBAGRESPONSE.is_extendable = false
RECEIVETREASUREBAGRESPONSE.extensions = {}

GetTreasureBagInfoRequest = protobuf.Message(GETTREASUREBAGINFOREQUEST)
GetTreasureBagInfoResponse = protobuf.Message(GETTREASUREBAGINFORESPONSE)
GetTreasureInfoRequest = protobuf.Message(GETTREASUREINFOREQUEST)
GetTreasureInfoResponse = protobuf.Message(GETTREASUREINFORESPONSE)
OPEN_ONE = 1
OPEN_TEN = 2
OpenTreasureRequest = protobuf.Message(OPENTREASUREREQUEST)
OpenTreasureResponse = protobuf.Message(OPENTREASURERESPONSE)
ReceiveTreasureBagRequest = protobuf.Message(RECEIVETREASUREBAGREQUEST)
ReceiveTreasureBagResponse = protobuf.Message(RECEIVETREASUREBAGRESPONSE)
TreasureItem = protobuf.Message(TREASUREITEM)

