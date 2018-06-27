///**
// * Created by lusongjie on 2015/4/17.
// */

//处理参数
function processArgv() {
    var ret = {};
    var args = process.argv.slice(2);
    for (var i in args) {
        var list = args[i].split('=');
        ret[list[0]] = list[1];
    }
    return ret;
}
var argv = processArgv();


/*-----------------------------------------------编译proto文件--------------------------------------------------*/
var fs = require('fs');
var ProtoBuf = require("protobufjs");
var util = require("util");

var buildProto = function (argv) {
    var builder = ProtoBuf.newBuilder();

    var protoDir = argv.input;

    fs.readdirSync(protoDir).forEach(function (filename) {
        if (!/\.proto$/.test(filename)) {
            return;
        }
        ProtoBuf.loadProtoFile(protoDir + '\\' + filename, builder);
    });

    builder.build();
    return builder;
}

var builder = buildProto(argv);

//console.log(util.inspect(builder,{depth:5}));

/*-----------------------------------------------通用函数--------------------------------------------------*/
//首字母大写
function firstUpperCase(str) {
    return str.replace(/\b\w/g, function (m) {
        return m.toUpperCase();
    });
}

function firstLowerCase(str) {
    return str.replace(/\b\w/g, function (m) {
        return m.toLowerCase();
    });
}


//生成空行
function genSpaceLine() {
    return '\n';
}

//生成缩进
function genIndent(nest) {
    var str = '';
    for (var i = 0; i < nest; ++i) {
        str += '\t'
    }
    return str;
}

//写入文件
function writeFile(output, fileName, code) {
    fs.writeFileSync(output + '/' + fileName, code);

}
/*-----------------------------------------------结构解析--------------------------------------------------*/

var handlers = {};
var sockets = {};

function push2handler(str) {
    return str.replace(/Push/g, function (m) {
        return 'Handler';
    });
}

function isPush(name) {
    var ret = name.match(/Push$/g);
    return ret !== null;
}

function isNotify(name) {
    var ret = name.match(/Notify$/g);
    return ret !== null;
}

function isRequest(name) {
    var ret = name.match(/Request$/g);
    return ret !== null;
}

function isHandler(name) {
    var ret = name.match(/Handler/g);
    return ret !== null;
}
//handler成员变量名
function handlerFieldName(name) {
    return name.replace(/\b\w/g, function (m) {
        return m.toLowerCase();
    });
}


//request函数参数列表
function requestParams(reflectT) {
    var array = [];
    for (var key in reflectT.children) {
        var field = reflectT.children[key];

        var type = field.type.name;
        if (field.resolvedType != null) {
            type = field.resolvedType.name;
        }

        var params = {
            type: type,
            name: field.name,
            repeated: field.repeated,
            required: field.required
        };
        array.push(params);
    }
    return array;
}


var socketMap = {
    gateHandler: 'GateSocket',
	loginHandler: 'GateSocket',
	loginPush: 'GateSocket'
}

var getSocketName = function (name) {
    var socket = socketMap[name];
    if (socket) {
        return socket;
    }
    return 'GameSocket';
}

/**
 * 添加socket
 * @param socketName
 */
var addSocket = function (socketName) {
    if (sockets[socketName] === undefined) {
        sockets[socketName] = {
            name: socketName,
            base: 'PomeloClient',
            type: 'socket',
            fields: [/*{
                type: 'ProtobufSerializer',
                name: 'serializer',
                notUppder: true
            }*/],
            events: [],
            usings: {},
            socket: socketName
        };
    }
}


/***
 * 添加handler
 * @param reflectT
 */
var addHandler = function (reflectT) {

    var fullHandlerName = reflectT.parent.name + '.' + reflectT.name;
    var handlerName = reflectT.name;
    var socketName = getSocketName(handlerName);

    if (handlers[fullHandlerName] === undefined) {
        handlers[fullHandlerName] = {
            name: firstUpperCase(handlerName),
            type: 'handler',
            fields: [{ type: 'PomeloClient', name: 'socket', skipProp: true },
                     /*{ type: 'ProtobufSerializer', name: 'serializer', skipProp: true }*/],
            requests: [],
            notifies: [],
            events: [],
            responses: [],
            socket: socketName,
            ns: reflectT.parent.name
        }


        if (isHandler(handlerName)) {
            //socket的handler数组
            sockets[socketName].fields.push({
                type: firstUpperCase(handlerName),
                name: handlerFieldName(handlerName),
                notUppder: true
            });
            sockets[socketName].usings[reflectT.parent.name] = true;
        }

        for (var keyRpc in reflectT.children) {

            var rpc = reflectT.children[keyRpc];
            var rpcName = rpc.name;
            var route = fullHandlerName + '.' + rpcName;

            //创建request response
            if (isRequest(rpcName)) {
                handlers[fullHandlerName].requests.push({
                    route: route,
                    type: rpcName,
                    requestType: rpc.resolvedRequestType.name,
                    responseType: rpc.resolvedResponseType.name,
                    params: requestParams(rpc.resolvedRequestType)
                });
            }
                //创建notify
            else if (isNotify(rpcName)) {
                handlers[fullHandlerName].notifies.push({
                    route: route,
                    type: rpcName,
                    requestType: rpc.resolvedRequestType.name,
                    responseType: rpc.resolvedResponseType.name,
                    params: requestParams(rpc.resolvedRequestType)
                });
            }
                //创建event
            else if (isPush(rpcName)) {
                var pushHandler = push2handler(handlerName);
                var event = {
                    route: route,
                    type: rpcName,
                    requestType: rpc.resolvedRequestType.name,
                    responseType: rpc.resolvedResponseType.name,
                    params: requestParams(rpc.resolvedRequestType),
                    handler: pushHandler

                };

				var fullPushHandler = null;
                try {
                    fullPushHandler = reflectT.parent.name + '.' + pushHandler;
                    handlers[fullPushHandler].events.push(event);
                    sockets[socketName].events.push(event);
                }
                catch (e) {
                    console.log("generate error: handler name must br same as filename!!!!!: " + fullPushHandler + "\n" + e);
                    throw e;
                }
            }
            else {
                throw new Error("api must postfix with Push or Request or Notify: " + fullHandlerName + " " + rpcName);
            }
            //  handlers[service.name].responses.push({name: rpc.response, fields: responseParams(key)});
            if (rpc.responseName !== 'Void') {
                handlers[fullHandlerName].fields.push({ type: rpc.responseName, name: 'last' + rpc.responseName });
            }
        }
    }
}

/**
 * 添加节点
 * @param reflectT
 */
var addNode = function (reflectT) {
    //service对应handler
    if (reflectT.className === 'Service') {
        addHandler(reflectT);
        return;
    }
        //message对应message
    else if (reflectT.className === 'Message') {
        //  addMessage(reflectT);
    }

    //遍历子节点
    for (var key in reflectT.children) {
        addNode(reflectT.children[key]);
    }
}

//创建所有的对象
var createAll = function () {
    addSocket('GateSocket');
    addSocket('GameSocket');
    addNode(builder.ns);
}

createAll();

//console.log(util.inspect(handlers, false, null, true));


///*--------------------------------------------C#代码生成--------------------------------------------------------*/
//成员变量类型名字
function fieldTypeName(field) {
    if (field.repeated == 'repeated') {
        return 'List<' + field.type + '>';
    }
    return field.type;
}

//protobuf 和c#的基本类型映射
var typeMap = {
    'Int32': 'int',
    'int32': 'int',
    'uInt32': 'uint',
    'Int64': 'long',
    'int64': 'long',
    'uInt64': 'ulong',
    'string': 'string',
    'bytes': 'byte[]'
}


//转化为c#的类型
function toCSharpType(type) {
    var ret = typeMap[type];
    if (ret === undefined) {
        ret = type;
    }
    return ret;
}

//生成文件头注释
function genComment() {
    var code = '/*-----------------------------------------------\n';
    code += ' *本文件由代码生成器自动生成，\n';
    code += ' *千万不要修改本文件的任何代码，\n';
    code += ' *修改的的任何代码都会被覆盖掉！\n';
    code += ' --------------------------------------------------*/\n';
    code += genSpaceLine();
    return code;
}

//生成引用
function genUsing(usings) {
    var pre = 'using System.IO;\nusing System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nusing Pomelo.DotNetClient;\n';

    if (usings) {
        for (var key in usings) {
            pre += 'using pomelo.' + key + ';\n';
        }
    }
    return pre;
}


//生成名称空间开头
function genNameSpaceBegin(indent, name) {
    return genIndent(indent) + 'namespace ' + name + '\n{';
}

//生成名称空间结尾
function genNameSpaceEnd(indent) {
    return genSpaceLine() + genIndent(indent) + '}';
}

//生成类开头
function genClassBegin(indent, name, base) {
    var str = genIndent(indent) + 'public class ' + name;
    if (base !== undefined) {
        str += ' : ' + base;
    }
    return str + '\n' + genIndent(indent) + '{\n';
}

//生成类结尾
function genClassEnd(indent) {
    return genSpaceLine() + genIndent(indent) + '}';
}

//生成成员变量
function genFieldDeclare(indent, field) {
    var type = fieldTypeName(field);
    if (type == "PomeloClient") {
        var code = genIndent(indent) + 'private ' + type + ' _' + field.name;
        code += ';\n';
        return code;
    } else {
        return '';
    }
}
//生成成员变量属性
function genFieldProperty(indent, field) {
    var code = genIndent(indent) + 'public ' + fieldTypeName(field) + ' ' + field.name + ' { get { return _socket.GetLastResponse<' + fieldTypeName(field) + '>(); } }';
    return code;
}

function genSocketFieldDeclare(indent, field) {
    var type = fieldTypeName(field);
    var code = genIndent(indent) + 'private ' + type + ' _' + field.name;
    code += ';\n';
    return code;
}
function genSocketFieldProperty(indent, field) {
    var code = genIndent(indent) + 'public ' + fieldTypeName(field) + ' ' + field.name + '\n';
    code += genIndent(indent) + '{\n';
    code += genIndent(indent + 1) + 'get { return _' + field.name + ';}\n';
    code += genIndent(indent + 1) + 'set { _' + field.name + ' = value; }\n';
    code += genIndent(indent) + '}\n';
    return code;
}


//生成函数开头
function genMethodBegin(indent, name, params, ret) {
    var code = genIndent(indent) + 'public ';
    code += ret + ' ';
    code += name + '(';
    if (params !== undefined) {
        for (var i in params) {
            var param = params[i];
            //      code+= fieldTypeName(param)+' '+ param.name;
            if (param.repeated) {
                code += 'List<' + toCSharpType(param.type) + '> ' + param.name;
            }
            else {
                code += toCSharpType(param.type) + ' ' + param.name;
            }
            if (param.default != undefined) {
                code += ' = ' + param.default;
            }
            code += ',';
        }
        if (code[code.length - 1] === ',') {
            code = code.substring(0, code.length - 1);
        }
    }
    code += ')\n' + genIndent(indent) + '{\n';
    return code;
}
function genConstructorMethodBegin(indent, name, params, base) {
    var code = genIndent(indent) + 'public ';
    code += name + '(';
    if (params !== undefined) {
        for (var i in params) {
            var param = params[i];
            //      code+= fieldTypeName(param)+' '+ param.name;
            if (param.repeated) {
                code += 'List<' + toCSharpType(param.type) + '> ' + param.name;
            }
            else {
                code += toCSharpType(param.type) + ' ' + param.name;
            }
            if (param.default != undefined) {
                code += ' = ' + param.default;
            }
            code += ',';
        }
        if (code[code.length - 1] === ',') {
            code = code.substring(0, code.length - 1);
        }
    }
    code += ')' + base + '\n' + genIndent(indent) + '{\n';
    return code;
}

//生成函数结尾
function genMethodEnd(indent) {
    return genSpaceLine() + genIndent(indent) + '}';
}

//生成构造函数
function genConstuctor(indent, classInfo) {
    var code = '';
    if (classInfo.type === 'socket') {
        code += genConstructorMethodBegin(indent, classInfo.name, [{ type: 'ISerializer', name: 'serializer' }], ' : base(serializer)');
        for (var i in classInfo.fields) {
            var field = classInfo.fields[i];
            if (field.type === 'ISerializer') {
                // code += genIndent(indent + 1) + '_' + field.name + ' = new ' + field.type + '();\n';
                // code += genIndent(indent + 1) + '_' + field.name + ' = base.Serializer;\n';
            }
            else {
                code += genIndent(indent + 1) + '_' + field.name + ' = new ' + field.type + '(this);\n';
            }
        }
        code += genMethodEnd(indent);
    }
    else if (classInfo.type === 'handler') {
        //静态构造
        code += genIndent(indent) + "static " + classInfo.name + "()\n";
        code += genIndent(indent) + "{\n"
        for (var i in classInfo.events) {
            var event = classInfo.events[i];
            code += genIndent(indent + 1) + "EventTypes.RegistPushType(\"" + event.route + "\", typeof(" + event.requestType + "));\n"
        }
        for (var i in classInfo.requests) {
            var request = classInfo.requests[i];
            code += genIndent(indent + 1) + "EventTypes.RegistRequestType(\"" + request.route + "\", typeof(" + request.requestType + "), typeof(" + request.responseType + "));\n"
        }
        for (var i in classInfo.notifies) {
            var notify = classInfo.notifies[i];
            code += genIndent(indent + 1) + "EventTypes.RegistNotifyType(\"" + notify.route + "\", typeof(" + notify.requestType + "));\n"
        }
        code += genIndent(indent) + "}\n";

        //构造
        code += genConstructorMethodBegin(indent, classInfo.name,
            [{ type: 'PomeloClient', name: 'socket' }, ],
            '');
        code += genIndent(indent + 1) + 'this._socket = socket;\n';
        //code += genIndent(indent + 1) + 'this._serializer = serializer;\n';
        code += genMethodEnd(indent);
    }

    return code;
}


//生成request函数
function genRequest(indent, classInfo, request) {
    var code = '';

    request.params.push({ type: 'Action<PomeloException,' + request.responseType + '>', name: 'cb' });
    request.params.push({ type: 'object', name: 'option', default: 'null' });
    code += genMethodBegin(indent, request.type, request.params, 'void');
    request.params.pop();
    request.params.pop();

    //code += genIndent(indent + 1) + '_socket.onRequestStart("' + request.route + '", option);\n';
    code += genIndent(indent + 1) + 'var request = new ' + request.requestType + '();\n';

    for (var i in request.params) {
        var param = request.params[i];
        if (param.repeated) {
            code += genIndent(indent + 1) + 'request.' + param.name + '.AddRange(' + param.name + ');\n';
        }
        else {
            code += genIndent(indent + 1) + 'request.' + param.name + '= ' + param.name + ';\n';
        }

    }
    //code += '\n';
    //code += genIndent(indent+1)+'MemoryStream input = new MemoryStream();\n';
    //code += genIndent(indent+1)+'_serializer.Serialize(input, request);\n\n';

    var respName = request.responseType;
    code += genIndent(indent + 1) + '_socket.request<' + respName + '>(request, (object msg, out int s2c_code, out string s2c_msg) => {\n';
    code += genIndent(indent + 2) + 'var rsp = msg as ' + respName + ';\n';
    code += genIndent(indent + 2) + 's2c_code = rsp.s2c_code;\n';
    code += genIndent(indent + 2) + 's2c_msg = rsp.s2c_msg;\n';
    code += genIndent(indent + 2) + 'return s2c_code == 200;\n';
    code += genIndent(indent + 1) + '}, cb, option);\n';

    /**
    code += genIndent(indent + 1) + '_socket.request("' + request.route + '", _serializer, request, output => {\n';

    code += genIndent(indent + 2) + 'try\n';
    code += genIndent(indent + 2) + '{\n';
    code += genIndent(indent + 3) + 'var stream = (MemoryStream)output;\n';
    code += genIndent(indent + 3) + respName + ' response = _serializer.Deserialize(stream, null, typeof(' + respName + ')) as ' + respName + ';\n';
    code += genIndent(indent + 3) + 'last' + respName + ' = response;\n';
    code += '\n';
    code += genIndent(indent + 3) + 'int code = response.s2c_code;\n';
    code += genIndent(indent + 3) + 'if (code == 200)\n';
    code += genIndent(indent + 3) + '{\n';
    code += genIndent(indent + 4) + '_socket.onRequestEnd("' + request.route + '", null, last' + respName + ', option);\n';
    code += genIndent(indent + 4) + 'cb(null, last' + respName + ');\n';
    code += genIndent(indent + 3) + '}\n';
    code += genIndent(indent + 3) + 'else\n';
    code += genIndent(indent + 3) + '{\n';
    code += genIndent(indent + 4) + 'string msg = response.s2c_msg;\n';
    code += genIndent(indent + 4) + 'PomeloException exp = new PomeloException(code, msg);\n';
    code += genIndent(indent + 4) + '_socket.onRequestEnd("' + request.route + '",exp, null, option);\n';
    code += genIndent(indent + 4) + ' cb(exp, null);\n';
    code += genIndent(indent + 3) + '}\n';
    code += genIndent(indent + 2) + '}\n';
    code += genIndent(indent + 2) + 'catch (Exception e)\n';
    code += genIndent(indent + 2) + '{\n';
    code += genIndent(indent + 3) + 'PomeloException exp = new PomeloException(501, e.Message + \"\\n\" + e.StackTrace);\n';
    code += genIndent(indent + 3) + '_socket.onRequestEnd("' + request.route + '",exp, null, option);\n';
    code += genIndent(indent + 3) + 'cb(exp, null);\n';
    code += genIndent(indent + 2) + '}\n';
    code += genIndent(indent + 2) + 'cb = null;\n';
    code += genIndent(indent + 1) + '});\n';
    */
    code += genMethodEnd(indent);
    return code;
}

//生成notify函数
function genNotify(indent, classInfo, notify) {
    var code = '';
    code += genMethodBegin(indent, notify.type, notify.params, 'void');

    code += genIndent(indent + 1) + 'var notify = new ' + notify.requestType + '();\n';
    for (var i in notify.params) {
        var param = notify.params[i];
        if (param.repeated) {
            code += genIndent(indent + 1) + 'notify.' + param.name + '.AddRange(' + param.name + ');\n';
        }
        else {
            code += genIndent(indent + 1) + 'notify.' + param.name + '= ' + param.name + ';\n';
        }
    }

    code += '\n';
    //code += genIndent(indent+1)+'MemoryStream input = new MemoryStream();\n';
    //code += genIndent(indent+1)+'_serializer.Serialize(input, notify);\n\n';

    code += genIndent(indent + 1) + '_socket.notify(notify);\n';
    code += genMethodEnd(indent);
    return code;
}
var eventOnName = function (name) {
    var ret = name.match(/^on/g) != null;
    if (ret) {
        return name;
    }

    return 'on' + firstUpperCase(name);
}
//生成事件响应函数
function genEvent(indent, classInfo, event) {

    var code = '';
    var responseType = event.requestType;
    var eventName = event.type;
    var params = [{ type: 'Action<' + responseType + '>', name: 'cb' }];

    code += genMethodBegin(indent, eventOnName(eventName), params, 'void');

    if (classInfo.type == 'socket') {
        code += genIndent(indent + 1) + '_' + event.handler + '.' + eventOnName(eventName) + '(cb);\n';

    }
    else {
        //code += genIndent(indent + 1) + '_socket.listen("' + event.route + '", stream =>  {\n';
        if (event.route === 'area.playerPush.battleEventPush') {
            //code += genIndent(indent + 2) + 'BattleEventPush push = new BattleEventPush();\n';
            //code += genIndent(indent + 2) + 'push.s2c_data = (stream as MemoryStream).ToArray();\n';
        }
        else {
            code += genIndent(indent + 1) + '_socket.listen_once<' + responseType + '>(cb);';
            //code += genIndent(indent + 2) + responseType + ' push = _serializer.Deserialize(stream, null, typeof(' + responseType + ')) as ' + event.requestType + ';\n';
            //code += genIndent(indent + 2) + responseType + ' push = stream as ' + event.requestType + ';\n';//_serializer.Deserialize(stream, null, typeof(' + responseType + ')) as ' + event.requestType + ';\n';
            //code += genIndent(indent + 2) + 'cb(push);\n';
        }
        //code += genIndent(indent + 1) + '});\n';
    }

    code += genMethodEnd(indent);
    return code;
}

//生成类
function genClass(indent, classInfo) {
    var code = '';
    code += genClassBegin(indent, classInfo.name, classInfo.base);
    if (classInfo.base == "PomeloClient") {
        for (var i in classInfo.fields) {
            var field = classInfo.fields[i];
            code += genSocketFieldDeclare(indent + 1, field);
        }
        code += genSpaceLine();
        //生成属性
        for (var i in classInfo.fields) {
            var field = classInfo.fields[i];
            if (field.skipProp) {
                continue;
            }
            code += genSocketFieldProperty(indent + 1, field);
            code += genSpaceLine();
        }
    } else {
        for (var i in classInfo.fields) {
            var field = classInfo.fields[i];
            code += genFieldDeclare(indent + 1, field);
        }
        code += genSpaceLine();
        //生成属性
        for (var i in classInfo.fields) {
            var field = classInfo.fields[i];
            if (field.skipProp) {
                continue;
            }
            code += genFieldProperty(indent + 1, field);
            code += genSpaceLine();
        }
    }

    //生成构造函数
    code += genConstuctor(indent + 1, classInfo);
    code += genSpaceLine();

    //生成request
    for (var i in classInfo.requests) {
        var request = classInfo.requests[i];
        code += genRequest(indent + 1, classInfo, request);
        code += genSpaceLine();
    }

    //生成notify
    for (var i in classInfo.notifies) {
        var notify = classInfo.notifies[i];
        code += genNotify(indent + 1, classInfo, notify);
        code += genSpaceLine();
    }
    //生成event
    for (var i in classInfo.events) {
        var event = classInfo.events[i];
        code += genEvent(indent + 1, classInfo, event);
        code += genSpaceLine();
    }
    code += genClassEnd(indent);

    return code;
}

//生成文件开头
function genFileBegin(classInfo) {
    var code = '';
    code += genComment();
    code += genUsing(classInfo.usings);

    code += genSpaceLine();

    var ns = classInfo.ns;
    if (!ns) {
        ns = 'Pomelo.DotNetClient';
    }
    else {
        ns = 'pomelo.' + ns;

    }
    code += genNameSpaceBegin(0, ns);
    code += genSpaceLine();
    return code;

}

//生成文件结尾
function genFileEnd() {
    return genNameSpaceEnd(0);
}

function genFile(classInfos) {
    var code = '';
    code += genFileBegin(classInfos[0]);
    for (var i in classInfos) {
        code += genClass(1, classInfos[i]);
        code += genSpaceLine();
        code += genSpaceLine();
    }
    code += genFileEnd();
    return code;
}



//socket文件
for (var keySocket in sockets) {
    writeFile(argv.output, sockets[keySocket].name + '.cs', genFile([sockets[keySocket]]));
    process.stdout.write('gen cs : ' + sockets[keySocket].name + '.cs' + '\n');
}

//handler文件
for (var keyHandler in handlers) {
    var fileName = handlers[keyHandler].name;
    if (isHandler(fileName)) {
        writeFile(argv.output, firstUpperCase(fileName) + '.cs', genFile([handlers[keyHandler]]));
        process.stdout.write('gen cs : ' + fileName + '\n');
    }
}

//
///*--------------------------------------------Lua代码生成--------------------------------------------------------*/
function genLuaMethodBegin(indent, name, params) {
    var code = genIndent(indent) + 'function ';

    code += name + '(';
    if (params !== undefined) {
        for (var i in params) {
            var param = params[i];
            code += param.name;
            code += ',';
        }
        if (code[code.length - 1] === ',') {
            code = code.substring(0, code.length - 1);
        }
    }
    code += ')\n';
    return code;
}
function genLuaMethodEnd(indent) {
    return genIndent(indent) + 'end\n\n';
}

function fullLuaName(className) {
    return 'Pomelo.' + className;
}

function genLuaEncodeMethodBegin(indent, name) {
    var code = genIndent(indent) + 'local function ';

    code += name + 'Encoder(msg)\n';
    return code;
}

function genLuaDecodeMethodBegin(indent, name) {
    var code = genIndent(indent) + 'local function ';

    code += name + 'Decoder(stream)\n';
    return code;
}

function genLuaRequest(indent, classInfo, request) {
    var code = '';

    code += genLuaEncodeMethodBegin(indent, request.type);
    code += genIndent(indent + 1) + 'local input = ' + firstLowerCase(classInfo.name) + '_pb.' + request.requestType + '()\n';
    code += genIndent(indent + 1) + 'protobuf.FromMessage(input,msg)\n';
    code += genIndent(indent + 1) + "return (input:SerializeToString())\n";
    code += genLuaMethodEnd(indent);

    code += genLuaDecodeMethodBegin(indent, request.type);
    //code += genIndent(indent + 1) + 'stream = ZZBase64.decode(stream)\n';
    code += genIndent(indent + 1) + 'local res = ' + firstLowerCase(classInfo.name) + '_pb.' + request.responseType + '()\n';
    code += genIndent(indent + 1) + 'res:ParseFromString(stream)\n';
    code += genIndent(indent + 1) + "return res\n";
    code += genLuaMethodEnd(indent);


    request.params.push({ type: 'Action<PomeloException,' + request.responseType + '>', name: 'cb' });
    request.params.push({ type: 'object', name: 'option', default: 'null' });


    code += genLuaMethodBegin(indent, fullLuaName(classInfo.name) + '.' + request.type, request.params);
    request.params.pop();
    request.params.pop();



    if (request.params.length == 0) {
        code += genIndent(indent + 1) + 'local input = nil\n';
    }
    else {
        code += genIndent(indent + 1) + 'local msg = {}\n';
        for (var i in request.params) {
            var param = request.params[i];
            code += genIndent(indent + 1) + 'msg.' + param.name + ' = ' + param.name + '\n';
        }
    }

    code += genIndent(indent + 1) + 'Socket.OnRequestStart("' + request.route + '", option)\n';

    if (request.params.length == 0) {
        code += genIndent(indent + 1) + 'Socket.Request("' + request.route + '", input, function(res)\n';
    }
    else {

        code += genIndent(indent + 1) + 'Socket.Request("' + request.route + '", msg, function(res)\n';
    }

    code += genIndent(indent + 2) + 'if(res.s2c_code == 200) then\n';
    code += genIndent(indent + 3) + 'Pomelo.' + classInfo.name + '.last' + request.responseType + ' = res\n';
    code += genIndent(indent + 3) + 'Socket.OnRequestEnd("' + request.route + '", true)\n';
    code += genIndent(indent + 3) + 'cb(nil,res)\n';
    code += genIndent(indent + 2) + 'else\n';
    code += genIndent(indent + 3) + 'local ex = {}\n';
    code += genIndent(indent + 3) + 'if(res.s2c_code) then\n';
    code += genIndent(indent + 4) + 'ex.Code = res.s2c_code\n';
    code += genIndent(indent + 4) + 'ex.Message = res.s2c_msg\n';
    code += genIndent(indent + 3) + 'else\n';
    code += genIndent(indent + 4) + 'ex.Code = 501\n';
    code += genIndent(indent + 4) + 'ex.Message = \"[LuaXmdsNetClient] ' + request.route + ' decode error!!\"\n';
    code += genIndent(indent + 3) + 'end\n';

    code += genIndent(indent + 3) + 'Socket.OnRequestEnd("' + request.route + '", false,ex.Code,ex.Message)\n';
    code += genIndent(indent + 3) + 'cb(ex,nil)\n';
    code += genIndent(indent + 2) + 'end\n';

    //code += genIndent(indent+2) + 'if(ex == nil) then\n';
    //code += genIndent(indent+3) + fullLuaName(classInfo.name)+'.last'+ request.responseType +' = res\n';
    //code += genIndent(indent+2) + 'end\n';
    //code += genIndent(indent+2) + 'cb(ex,res)\n';
    code += genIndent(indent + 1) + 'end, ' + request.type + 'Encoder, ' + request.type + 'Decoder)\n';
    code += genLuaMethodEnd(indent);
    return code;

}

function genLuaNotify(indent, classInfo, notify) {
    var code = '';

    code += genLuaEncodeMethodBegin(indent, notify.type);
    code += genIndent(indent + 1) + 'local input = ' + firstLowerCase(classInfo.name) + '_pb.' + notify.requestType + '()\n';
    code += genIndent(indent + 1) + 'protobuf.FromMessage(input,msg)\n';
    code += genIndent(indent + 1) + "return (input:SerializeToString())\n";
    code += genLuaMethodEnd(indent);


    code += genLuaMethodBegin(indent, fullLuaName(classInfo.name) + '.' + notify.type, notify.params);

    if (notify.params.length == 0) {
        code += genIndent(indent + 1) + 'local msg = nil\n';
    }
    else {

        code += genIndent(indent + 1) + 'local msg = {}\n';
        for (var i in notify.params) {
            var param = notify.params[i];
            code += genIndent(indent + 1) + 'msg.' + param.name + ' = ' + param.name + '\n';
        }

        //code += genIndent(indent + 1) + 'local input = {}\n';
    }

    //for(var i in notify.params){
    //    var param = notify.params[i];
    //    code += genIndent(indent+1)+'input.'+ param.name +' = '+ param.name+'\n';
    //}
    code += genIndent(indent + 1) + 'Socket.Notify("' + notify.route + '", msg, ' + notify.type + 'Encoder' + ')\n';

    code += genLuaMethodEnd(indent);
    return code;

}

function genLuaEvent(indent, classInfo, event) {
    var code = '';

    code += genLuaDecodeMethodBegin(indent, event.type);
    //code += genIndent(indent + 1) + 'stream = ZZBase64.decode(stream)\n';
    code += genIndent(indent + 1) + 'local res = ' + firstLowerCase(event.handler) + '_pb.' + event.requestType + '()\n';
    code += genIndent(indent + 1) + 'res:ParseFromString(stream)\n';
    code += genIndent(indent + 1) + "return res\n";
    code += genLuaMethodEnd(indent);


    code += genLuaMethodBegin(indent, fullLuaName(classInfo.name) + '.' + event.type, [{ name: 'cb' }]);


    code += genIndent(indent + 1) + 'Socket.On("' + event.route + '", function(res) \n';
    code += genIndent(indent + 2) + 'Pomelo.' + classInfo.name + '.last' + event.requestType + ' = res\n';
    code += genIndent(indent + 2) + 'cb(nil,res) \n';
    code += genIndent(indent + 1) + 'end, ' + event.type + 'Decoder' + ') \n';

    //  code += genIndent(indent+1)+'Socket.On("'+  event.route + '", cb) \n';

    code += genLuaMethodEnd(indent);
    return code;
}

function genLuaClass(indent, classInfo) {
    var code = '';
    code += '--------------------------------' + classInfo.name + '-------------------------------\n';
    code += 'Pomelo.' + classInfo.name + ' = {}\n';
    code += genSpaceLine();

    //生成request
    for (var i in classInfo.requests) {
        var request = classInfo.requests[i];
        code += genLuaRequest(indent, classInfo, request);
        code += genSpaceLine();
    }

    //生成notify
    for (var i in classInfo.notifies) {
        var notify = classInfo.notifies[i];
        code += genLuaNotify(indent, classInfo, notify);
        code += genSpaceLine();
    }
    //生成event
    for (var i in classInfo.events) {
        var event = classInfo.events[i];
        code += genLuaEvent(indent, classInfo, event);
        code += genSpaceLine();
    }

    return code;
}

//生成文件头注释
function genLuaComment() {
    var code = '-------------------------------------------------\n';
    code += '-- 本文件由代码生成器自动生成，\n';
    code += '-- 千万不要修改本文件的任何代码，\n';
    code += '-- 修改的的任何代码都会被覆盖掉！\n';
    code += '----------------------------------------------------\n';
    code += genSpaceLine();
    return code;
}

function genLuaFile(classInfos) {
    var code = '';

    code += genLuaComment();
    code += 'local Socket = require "' + argv.pathLua + '.Lua' + classInfos[0].socket + '"\n';
    //code += 'local cjson = require "cjson"\n';
    code += 'require "base64"\n';

    if (classInfos[0].type === 'handler') {
        code += 'require "' + firstLowerCase(classInfos[0].name) + '_pb"\n';
    }

    code += genSpaceLine();
    code += '--------------------------------Pomelo-------------------------------\n';
    code += 'Pomelo = Pomelo or {}\n';
    code += genSpaceLine();

    for (var i in classInfos) {
        code += genLuaClass(0, classInfos[i]);
        code += genSpaceLine();
        code += genSpaceLine();
    }
    code += '--------------------------------Pomelo-------------------------------\n';
    code += 'return Pomelo\n';

    return code;

}

function genRequire() {
    var code = '';
    for (var keySocket in sockets) {
        code += 'require "' + argv.pathLua + '.' + sockets[keySocket].name + '"\n';
    }

    for (var keyHandler in handlers) {
        if (isHandler(handlers[keyHandler].name)) {
            code += 'require "' + argv.pathLua + '.' + firstUpperCase(handlers[keyHandler].name) + '"\n';
        }
    }
    return code;
}

//socket文件
for (var keySocket in sockets) {
    writeFile(argv.outputLua, sockets[keySocket].name + '.lua', genLuaFile([sockets[keySocket]]));
    process.stdout.write('gen lua : ' + sockets[keySocket].name + '.lua' + '\n');
}

//handler文件
for (var keyHandler in handlers) {
    var fileName = handlers[keyHandler].name;

    if (isHandler(fileName)) {
        writeFile(argv.outputLua, firstUpperCase(fileName) + '.lua', genLuaFile([handlers[keyHandler]]));
        process.stdout.write('gen lua : ' + fileName + '\n');
    }
}

writeFile(argv.outputLua, 'Pomelo.lua', genRequire());
process.stdout.write('gen lua : Pomelo.lua \n');

/*--------------------------------------------js代码生成--------------------------------------------------------*/
function genJsMethodBegin(indent, className, method, isAsync) {
    var code = genIndent(indent) + className + '.prototype.' + method.type + ' = ';

    if (isAsync) {
        code += 'async(';
    }
    code += 'function(';

    if (method.params !== undefined) {
        for (var i in method.params) {
            var param = method.params[i];
            code += param.name;
            code += ',';
        }
        if (code[code.length - 1] === ',') {
            code = code.substring(0, code.length - 1);
        }
    }

    code += '){\n';
    return code;
}
function genJsMethodEnd(indent, isAsync) {
    var code = '';
    code += genIndent(indent) + '}';
    if (isAsync) {
        code += ')';
    }
    code += ';\n';

    return code;
}



function genJsRequest(indent, classInfo, request) {
    var code = '';
    code += genJsMethodBegin(indent, classInfo.name, request, true);

    code += genIndent(indent + 1) + 'return await(this.socket.requestAsync(\'' + request.route + '\',{';
    for (var i in request.params) {
        var param = request.params[i];
        code += param.name + ':' + param.name;
        if (i < request.params.length - 1) {
            code += ',';
        }
    }
    code += '}));\n';
    code += genJsMethodEnd(indent, true);
    return code;

}

function genJsNotify(indent, classInfo, notify) {
    var code = '';
    code += genJsMethodBegin(indent, classInfo.name, notify, false);

    code += genIndent(indent + 1) + 'return this.socket.notify(\'' + notify.route + '\',{';
    for (var i in notify.params) {
        var param = notify.params[i];
        code += param.name + ':' + param.name;
        if (i < notify.params.length - 1) {
            code += ',';
        }
    }
    code += '});\n';
    code += genJsMethodEnd(indent, false);
    return code;

}

function genJsEvent(indent, classInfo, event) {
    var code = '';
    code += genIndent(indent) + classInfo.name + '.prototype.on' + firstUpperCase(event.type) + ' = function(cb){\n';

    if (isHandler(classInfo.name)) {
        code += genIndent(indent + 1) + 'this.socket.on(\'' + event.route + '\',cb);\n';
    }
    else {
        code += genIndent(indent + 1) + 'this.on(\'' + event.route + '\',cb);\n';
    }
    code += genIndent(indent) + '}';
    return code;
}

function genJsConstructor(indent, classInfo) {
    var code = '';

    if (classInfo.type == 'socket') {
        code += genIndent(indent) + 'var ' + classInfo.name + ' = function(protoPath){\n';
        code += genIndent(indent + 1) + 'Socket.call(this,protoPath);\n';
        for (var i in classInfo.fields) {
            var name = classInfo.fields[i].type;
            if (isHandler(name)) {
                code += genIndent(indent + 1) + 'this.' + firstLowerCase(name) + ' = new ' + name + '(this);\n';
            }

        }
    }
    else if (classInfo.type == 'handler') {
        code += genIndent(indent) + 'var ' + classInfo.name + ' = function(socket){\n';
        code += genIndent(indent + 1) + 'this.socket = socket;\n';

    }

    code += genIndent(indent) + '}\n';
    return code;
}

function genJsClass(indent, classInfo) {
    var code = '';

    //handlers
    if (classInfo.type == 'socket') {
        for (var i in classInfo.fields) {
            var name = classInfo.fields[i].type;
            if (isHandler(name)) {
                code += genIndent(indent) + 'var ' + firstUpperCase(name) + ' = require(\'./' + firstLowerCase(name) + '\');\n';
            }
        }
    }

    //构造函数
    code += genSpaceLine();
    code += genJsConstructor(indent, classInfo);
    code += genSpaceLine();

    if (classInfo.type == 'socket') {
        code += genSpaceLine();
        code += genIndent(indent) + 'util.inherits(' + firstUpperCase(classInfo.name) + ', Socket);\n';
        code += genSpaceLine();
    }

    //生成request
    for (var i in classInfo.requests) {
        var request = classInfo.requests[i];
        code += genJsRequest(indent, classInfo, request);
        code += genSpaceLine();
    }

    //生成notify
    for (var i in classInfo.notifies) {
        var notify = classInfo.notifies[i];
        code += genJsNotify(indent, classInfo, notify);
        code += genSpaceLine();
    }
    //生成event
    for (var i in classInfo.events) {
        var event = classInfo.events[i];
        code += genSpaceLine();
        code += genJsEvent(indent, classInfo, event);
        code += genSpaceLine();
    }

    return code;
}


//生成文件头注释
function genJsComment() {
    var code = '/*-----------------------------------------------\n';
    code += ' *本文件由代码生成器自动生成，\n';
    code += ' *千万不要修改本文件的任何代码，\n';
    code += ' *修改的的任何代码都会被覆盖掉！\n';
    code += ' --------------------------------------------------*/\n';
    code += genSpaceLine();
    return code;
}


function genJsFile(classInfo) {
    var code = '';

    code += genJsComment();

    if (classInfo.type == 'socket') {
        code += 'var util = require(\'util\');\n';
        code += 'var Socket = require(\'Xmds-csharp\').Socket;\n';
    }
    else if (classInfo.type == 'handler') {
        code += 'var async = require(\'asyncawait/async\');\n';
        code += 'var await = require(\'asyncawait/await\');\n';
    }

    code += genSpaceLine();
    code += genJsClass(0, classInfo);
    code += genSpaceLine();
    code += 'module.exports = ' + firstUpperCase(classInfo.name) + ';\n';
    return code;

}



if (!!argv.outputJs) {
    //socket文件
    for (var keySocket in sockets) {
        writeFile(argv.outputJs, sockets[keySocket].name + '.js', genJsFile(sockets[keySocket]));
        process.stdout.write('gen js : ' + sockets[keySocket].name + '.js' + '\n');
    }

    //handler文件
    for (var keyHandler in handlers) {

        var fileName = handlers[keyHandler].name;
        if (isHandler(fileName)) {
            writeFile(argv.outputJs, firstLowerCase(fileName) + '.js', genJsFile(handlers[keyHandler]));
            process.stdout.write('gen js : ' + fileName + '\n');
        }
    }
}

