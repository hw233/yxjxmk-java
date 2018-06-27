import os
import os.path
import sys
import codecs
import xlrd
import shutil
import re
import copy
from _ast import Or


lua_data_dir = "../lua"

ZONE = "vietnam"
dictDir = "..\dict"+"\\" +ZONE
dictDir = unicode(dictDir,'utf8')

csvDir = ".\client_csv_config"
#csvDir = "..\csv"
csvDir = unicode(csvDir,'utf8')

destCsvDir = "..\\..\\GameEditors\\UIEdit\\res\\ui_edit\\config\\"
#destCsvDir = "..\destCsv\\"

uiDir = "..\\..\\GameEditors\\UIEdit\\res\\ui_edit\\xmds_ui\\"
scenesDir = "..\\..\\GameEditors\\GameEditor\\data\\scenes\\"
itemDir = "..\\..\\GameEditors\\GameEditor\\data\\items\\"

uiPattern = "([tT]?ext=\".*?\")"
scenesPattern = "(<element>showname=.*?</element>)"
itemsPattern = "(<PickActionName>.*?</PickActionName>)"

translatedFile = dictDir + '\\translated.xls'

transDict = {}
unTransDict = {}

def isContainChinese(check_str):
    for ch in check_str.decode('utf-8'):
        if u'\u4e00' <= ch <= u'\u9fff':
            return True
    return False

def logUntranslatedStr(lgFile):
    if len(unTransDict) > 0 :
        type = sys.getfilesystemencoding()
        lgFile.write(u"\r\n")
        lgFile.write("===================Following words those can't find in dictionary=========================\r\n")
        print "Warning!!! Can't find in dictionary, please check log file excelToLua.txt ========================="
        for key in unTransDict.keys():
            print key.decode('utf-8').encode(type)
            lgFile.write(key)
            lgFile.write(u"\r\n")
        print "Warning!!! Can't find in dictionary, please check log file excelToLua.txt ========================="
    return

def loadTranslatedDict():
    data = xlrd.open_workbook(translatedFile)
    print "Begin loadTranslatedDict : " + translatedFile
    for table in data.sheets():
        print " sheet : " + table.name
        try:
            nrows = table.nrows
            ncols = table.ncols
            if nrows <= 3:
                return
            for r in range(nrows):
                if ncols<2:
                    continue
                key = str(table.cell_value(r,0)).strip()
                val = str(table.cell_value(r,1)).strip()
                if len(key)>0 and len(val)>0 :
                    transDict[key] = val
        except Exception,e:  
            print Exception,":",e
            os.system('pause')
    print "loadTranslatedDict OK"
    return

def transCsv(srcCsv,destCsv,lgFile):
    print 'begin convert csv: ' + srcCsv
    lgFile.write('csv dir: ' + srcCsv)
    lgFile.write(u"\r\n")

    try:
        dic = []
        with open(srcCsv, "r") as csvfile:
            reader = csvfile.readlines()
            for strCellValue in reader:
                line = strCellValue
                if(isContainChinese(strCellValue)):
                    index = strCellValue.find(',')
                    if index > 0:
                        val1 = strCellValue[0:index]
                        val2 = strCellValue[index+1:len(strCellValue)]
                        #去除首尾空格、首尾双引号，末尾逗号
                        key = val2.strip() 
                        key = key.rstrip(',')
                        key = key.strip('\"')
                        key = key.strip()
                        
                        if transDict.has_key(key) :
                            reVal = transDict.get(key)
                            val2 = val2.replace(key,reVal)                        
                        else:
                            unTransDict[key] = '' 
                        line = val1+','+val2
                print line
                dic.append(line)
        csvfile.close()    
        
        print "---------dic size: " + str(len(dic))
        #write back to the csvfile
        with open(destCsv,"w") as csvfile: 
            csvfile.writelines(dic)
        csvfile.close()            
    except Exception,e:  
        print Exception,":",e
        os.system('pause')
    lgFile.write(srcCsv)     
    lgFile.write(u" ......converted \r\n") 


def FloatToString (aFloat):
    if len(str(aFloat)) == 0:
        return '0';
    if type(aFloat) != float:
        print aFloat+" - 数字类型格式错误"
        os.system("pause")
        return ""
    strTemp = str(aFloat)
    strList = strTemp.split(".")
    if len(strList) == 1 :
        return strTemp
    else:
        if strList[1] == "0" :
            return strList[0]
        else:
            return strTemp

def StringToString (aStr):
    if type(aStr) != float:
        return str(aStr)
    strTemp = str(aStr)
    strList = strTemp.split(".")
    if len(strList) == 1 :
        return strTemp
    else:
        if strList[1] == "0" :
            return strList[0]
        else:
            return strTemp

def haveNext(table, col, row, max_cols):
    for c in range(col, max_cols):
        objType = str(table.cell_value(row, c));
        if(objType.find("@") == -1):
            return 1
    return 0

def table2lua(table, jsonfilename, main_key=None, con_str=None,uncon_str=None):

    con_array = []
    uncon_array = []
    if con_str:
        con_array = con_str.split('|')
    if uncon_str:
        uncon_array = uncon_str.split('|')

    nrows = table.nrows
    ncols = table.ncols
    if os.path.exists(jsonfilename):
        print 'error : ',jsonfilename,'already exist!'
        exit(1)
    f = codecs.open(jsonfilename,"w","utf-8")
    f.write(u"return {\n")
    for r in range(1,nrows):
        if r == 2:
            continue
        line = u"{"
        #f.write(u"\t{ ")
        for c in range(ncols):
            strCellValue = u""
            objName = str(table.cell_value(1,c))
            objType = str(table.cell_value(2,c))
            objStr = table.cell_value(r,c)
            if(objName.find("@") >= 0 or objType.find("@")>=0 ):
                continue

            if len(con_array) > 0:
                check = False
                for it in con_array:
                    if it == objName:
                        check = True
                        break
                if not check:
                    continue       
            elif len(uncon_array) > 0:
                check = True
                for it in uncon_array:
                    if it == objName:
                        check = False
                        break
                if not check:
                    continue     
                     
            if r == 0 or r == 1:
                if type(objStr) == float:
                    firstCol = str(table.cell_value(r,0))
                    print 'Type Error: (row:%s,col:%s)' % (firstCol,objName)
                    exit(1)
                strCellValue = u"\""  + objStr + u"\""
            else:
                if cmp(objType, "NUMBER") == 0 or cmp(objType, "FLOAT") == 0:
                    strCellValue = FloatToString(objStr)
                    if strCellValue == '':
                        firstCol = str(table.cell_value(r,0))
                        print 'Type Error: (row:%s,col:%s)' % (firstCol,objName)
                        exit(1)
                else:
                    keyStr = str(objStr).strip()
                    if isContainChinese(keyStr):
                        if transDict.has_key(keyStr):
                            objStr = transDict.get(keyStr)
                        else:
                            unTransDict[objStr] = ""
                    strvalue = StringToString(objStr).strip();
                    strvalue = "".join(strvalue.split("\n"))
                    strCellValue = u"\""  + strvalue + u"\""
            if main_key and main_key == objName:
                line = line + strCellValue
                #key row
                if r == 1:
                    line = u"[\"_key_\"] = " + line
                else:
                    line = u"[" + strCellValue + u"] = " + line
            else:
                line = line + strCellValue
            line += u","
            # if c < ncols-1:
            #     isNext = haveNext(table, c+1, 1, ncols)
            #     if isNext != 0:                   
            #f.write(strCellValue)
        line = line + u"}"
        f.write(line)
        # f.write(u" }")
        # if r < nrows-1:
        #     f.write(u",")
        # f.write(u"\n")
        f.write(u",\n")
    f.write(u"}")
    f.close()
    print "Create ",jsonfilename," OK"
    return


def excelTolua(key, main_key=None,con_str=None,uncon_str=None,dirstr=None):
    print 'begin trans excel:' + key
    data = xlrd.open_workbook(key.split(':')[0])
    if not dirstr:
        dirstr = lua_data_dir

    for table in data.sheets():
        if key.split(':')[1] == table.name:
            #do
            destfilename = os.path.join(dirstr, table.name + ".lua")
            table2lua(table,destfilename,main_key,con_str,uncon_str)
            return table.name
    print 'error : ',key,'not exist!'
    exit(1)

def tag2luaTable(tagname,taglist):
    ret = u"{"
    for name in taglist:
        v = u"\"" + tagname + u"." + name + u"\","
        ret = ret + v
    ret = ret + u"}"
    return ret


def xmlToDict(xmlFileName,destPattern,lgFile):
    print 'begin trans xml:' + xmlFileName
    lgFile.write('xml file:' + xmlFileName)
    lgFile.write(u"\r\n")
    
    data = open(xmlFileName,"rU")
    try:
        reader = data.read()   
        newContent = reader
        
        dest = re.compile(destPattern)
        res = dest.findall(reader)     
        for elem in res:
            strCellValue = str(elem).strip()
            print strCellValue
            if len(strCellValue) > 0 and isContainChinese(strCellValue):
 
                if transDict.has_key(strCellValue) :
                    dest = transDict.get(strCellValue) 
                    newContent = newContent.replace(strCellValue, dest)                       
                else:
                    unTransDict[strCellValue] = ''  
        data.close()   
        print "---------new xmlfile size: " + str(len(reader))
        #write back to the xmlfile
        newFile = codecs.open(xmlFileName,"wb","utf-8")   
        newFile.write(newContent.replace("\n","\r\n"))
        newFile.close()
                    
    except Exception,e:  
        print Exception,":",e
        os.system('pause')
    print "trans xml OK"

def walkXmlDir(xmlDir,destPattern,lgFile):
    print xmlDir
    if not os.path.exists(xmlDir):
        lgFile.write(xmlDir+' xml files dir not exist!!!')
        lgFile.write(u"\r\n") 
        os.system('pause')
        
    for parent,dirnames,filenames in os.walk(xmlDir):
        for filename in filenames:
            if filename.endswith(".xml") :
                print 'filename : ' + filename
                excelFileName = os.path.join(parent, filename)
                xmlToDict(excelFileName,destPattern,lgFile)

def extractXml(lgFile):    
    walkXmlDir(uiDir, uiPattern, lgFile)
    walkXmlDir(scenesDir, scenesPattern, lgFile)
    walkXmlDir(itemDir, itemsPattern, lgFile)


if __name__ == '__main__':
    reload(sys)
    sys.setdefaultencoding( "utf-8" )
    lgFile = codecs.open('..\excelToLua.txt',"w","utf-8")
    try:
        if os.path.exists(translatedFile):
            loadTranslatedDict()
        else:
            print "Can't find dict file: " + translatedFile
            os.system('pause')
            
        
        
        print csvDir
        if not os.path.exists(csvDir):
            lgFile.write(csvDir+' csv files dir not exist!!!')
            lgFile.write(u"\r\n") 
            os.system('pause')
        lgFile.write('==========================Begin convert csv files==================')     
        lgFile.write(u"\r\n")           
        for parent,dirnames,filenames in os.walk(csvDir):
            for filename in filenames:
                print 'filename : ' + filename
                srcCsvFileName = os.path.join(parent, filename)
                destCsvFileName = destCsvDir+filename
                print destCsvFileName
                transCsv(srcCsvFileName,destCsvFileName,lgFile)

        
        lgFile.write('==========================Begin extract xml files==================')     
        lgFile.write(u"\r\n")  
        extractXml(lgFile)
        lgFile.write('==========================Convert xml files ended ==================')
        
        os.system('pause')
    except Exception,e:  
        print Exception,":",e
    
    
    if os.path.isdir(lua_data_dir):
        shutil.rmtree(lua_data_dir)
    os.mkdir(lua_data_dir)

    data = xlrd.open_workbook("LuaConfig.xlsm")
    map_tag = dict()
    for table in data.sheets():
        if table.name == 'LuaConfig':
            #lua
            #Path Key Export Hide
            for r in range(3,table.nrows):
                key = table.cell_value(r,0)
                main_key = table.cell_value(r,1)
                con_str = table.cell_value(r,2)
                uncon_str = table.cell_value(r,3)
                tag_str = table.cell_value(r,4)

                dir_str = None 
                if tag_str != '':
                    dir_str = os.path.join(lua_data_dir, tag_str)
                    if not os.path.isdir(dir_str):
                        os.mkdir(dir_str)
                        map_tag[tag_str] = [] 
                tname = excelTolua(key,main_key,con_str,uncon_str,dir_str)
                if dir_str:
                    map_tag[tag_str].append(tname)
    if len(map_tag) > 0:
        mfilename = os.path.join(lua_data_dir, "_merge_.lua")
        f = codecs.open(mfilename,"w","utf-8")
        f.write(u"return {\n")

        for k,v in map_tag.items():
            line = k + u" = " + tag2luaTable(k,v) + u",\n"
            f.write(line)
        f.write(u"}")
        f.close()
        
    logUntranslatedStr(lgFile)
    lgFile.close()
    #os.system('echo Explorer to lua path')
    #os.system('exit')
    #os.system('explorer ' + lua_data_dir)

