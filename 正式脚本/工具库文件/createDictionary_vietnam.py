#!/usr/bin/env python
# coding: utf-8
import os.path
import sys
import codecs
import xlrd
import xlwt
from xlwt import Workbook
import shutil
import re

ZONE = "vietnam"
logFile = "createDictionary.txt"
excelDir = ".\策划脚本"
csvDir = ".\工具库文件\\client_csv_config"
#csvDir = "..\csv"
dictDir = ".\dict"+"\\" +ZONE

uiDir = "..\GameEditors\\UIEdit\\res\\ui_edit\\xmds_ui\\"
scenesDir = "..\GameEditors\\GameEditor\\data\\scenes\\"
itemDir = "..\GameEditors\\GameEditor\\data\\items\\"

uiPattern = "([tT]?ext=\".*?\")"
scenesPattern = "(<element>showname=.*?</element>)"
itemsPattern = "(<PickActionName>.*?</PickActionName>)"
    
excelDir = unicode(excelDir,'utf8')
csvDir = unicode(csvDir,'utf8')
dictDir = unicode(dictDir,'utf8')
translatedFile = dictDir + '\\translated.xls'
unTranslateFile = dictDir + '\\unTranslated.xls'

g_objName=""
transDict = {}
unTransDict = {}

def isContainChinese(check_str):
    for ch in check_str.decode('utf-8'):
        if u'\u4e00' <= ch <= u'\u9fff':
            return True
    return False

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



    
def NumberToString (aFloat):
    strTemp = str(aFloat)
    if len(strTemp) == 0:
        return '0';
    if type(aFloat) != float:
        print strTemp + u" - 数字类型格式错误"
        os.system("pause")
        return ""
    strList = strTemp.split(".")
    if len(strList) == 1 :
        return strTemp
    else:
        if strList[1] == "0" :
            return strList[0]
        else:
            print g_objName + " : " + strTemp + u" - 类型是否应该改为FLOAT"
            os.system("pause")

def FloatToString (aFloat):
    strTemp = str(aFloat)
    if len(strTemp) == 0:
        return '0';
    if type(aFloat) != float:
        print strTemp + u" - 数字类型格式错误"
        os.system("pause")
        return ""
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

def table2Dict(table):
    type = sys.getfilesystemencoding()
    nrows = table.nrows
    ncols = table.ncols
    if nrows <= 3:
        return
    for r in range(nrows):
        rowName = str(table.cell_value(r,0))
        if(rowName.find("@")>=0 ):#略过@打头的行
            continue

        for c in range(ncols):
            strCellValue = ''
            objName = str(table.cell_value(1,c))
            global g_objName
            g_objName= objName
            
            if(objName.find("@") >= 0):#@打头的列为注释，直接跳过
                continue            

            if r <= 2:
                continue
            
            objType = str(table.cell_value(2,c))

            if objType=='STRING':
                strCellValue = str(table.cell_value(r,c)).strip()
                print strCellValue.decode('utf-8').encode(type)
                if(isContainChinese(strCellValue)): 
                    #the key not in translated dictionary    
                    if not strCellValue in transDict :               
                        unTransDict[strCellValue] = ''               

    print "--Operate ",table.name," OK----------"
    return

def excelToDict(excelFileName,lgFile):
    print 'begin trans excel:' + excelFileName
    lgFile.write('Excel dir:' + excelFileName)
    lgFile.write(u"\r\n")
    
    data = xlrd.open_workbook(excelFileName)
    for table in data.sheets():
        print "sheet : " + table.name
        lgFile.write('\t'+'sheetCO : ' + table.name)
        lgFile.write(u"\r\n")
        sheetName = table.name.lower()
        if (not sheetName.startswith('config')) and (not sheetName.startswith('sheet')) and (not sheetName.startswith('remark')) and (not sheetName.startswith('(')):
            if(sheetName=='blackword' or sheetName=='prefix' or sheetName=='suffix'):
                continue
            try:
                table2Dict(table)
            except Exception,e:  
                print Exception,":",e
                os.system('pause')
    print "trans excel OK"

def csvToDict(csvFileName,lgFile):
    print 'begin trans csv:' + csvFileName
    lgFile.write('csv file:' + csvFileName)
    lgFile.write(u"\r\n")
    
    data = open(csvFileName,"r")
    type = sys.getfilesystemencoding()
    try:
        reader = data.readlines()
        for strCellValue in reader:
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
                    
                    print key.decode('utf-8').encode(type)
                    #the key not in translated dictionary    
                    if not key in transDict :               
                        unTransDict[key] = ''   
        data.close()                
    except Exception,e:  
        print Exception,":",e
        os.system('pause')
    print "trans csv OK"

def xmlToDict(xmlFileName,destPattern,lgFile):
    print 'begin trans xml:' + xmlFileName
    lgFile.write('xml file:' + xmlFileName)
    lgFile.write(u"\r\n")
    
    data = open(xmlFileName,"r")
    type = sys.getfilesystemencoding()
    try:
        reader = data.read()   
        dest = re.compile(destPattern)
   
        res = dest.findall(reader)     
        for elem in res:
            print elem
            strCellValue = str(elem).strip()
            if len(strCellValue) > 0:
                if(isContainChinese(strCellValue)):
                    print strCellValue.decode('utf-8').encode(type)
                    #the key not in translated dictionary    
                    if not strCellValue in transDict :               
                        unTransDict[strCellValue] = ''   
        data.close()                
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
    lgFile.write('==========================Begin extract xml files==================')     
    lgFile.write(u"\r\n")    
    walkXmlDir(uiDir, uiPattern, lgFile)
    walkXmlDir(scenesDir, scenesPattern, lgFile)
    walkXmlDir(itemDir, itemsPattern, lgFile)
    
    
if __name__ == '__main__':
    reload(sys)
    sys.setdefaultencoding( "utf-8" )
 
    #if os.path.isdir(dictDir): 
    if not os.path.exists(dictDir):
        os.makedirs(dictDir) 
    

    try:        
        if os.path.exists(translatedFile):
            loadTranslatedDict()
        
        lgFile = codecs.open(logFile,"w","utf-8")
        
        #extract xml file
        extractXml(lgFile)
        
        print csvDir
        if not os.path.exists(csvDir):
            lgFile.write(csvDir+' csv files dir not exist!!!')
            lgFile.write(u"\r\n") 
            os.system('pause')
        lgFile.write('==========================Begin extract csv files==================')     
        lgFile.write(u"\r\n")           
        for parent,dirnames,filenames in os.walk(csvDir):
            for filename in filenames:
                print 'filename : ' + filename
                excelFileName = os.path.join(parent, filename)
                csvToDict(excelFileName,lgFile)                
                
        print excelDir
        lgFile.write('==========================Begin extract excel files==================')
        lgFile.write(u"\r\n")
        for parent,dirnames,filenames in os.walk(excelDir):
            for filename in filenames:
                if not filename.startswith("~$"):
                    sufix = os.path.splitext(filename)[1][1:]
                    #	print('sufix:' + sufix);
                    if sufix == 'xls' or sufix == 'xlsx':
                        print 'filename : ' + filename
                        excelFileName = os.path.join(parent, filename)
                        excelToDict(excelFileName,lgFile)
         
 
        lgFile.write('==========================All OK==================')
        lgFile.close()
         
        book = Workbook(encoding='utf-8')
        sheet1 = book.add_sheet('Sheet 1')
        row = 0;
        col = 0;
        for item in unTransDict.keys():
            sheet1.write(row,col,str(item))
            row += 1
        book.save(unTranslateFile)
    except Exception,e:  
        print Exception,":",e
    # os.system('pause')
