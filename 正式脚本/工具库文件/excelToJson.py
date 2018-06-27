#!/usr/bin/env python
# coding: utf-8
import os.path
import sys
import codecs
import xlrd
import shutil
excelDir = ".\策划脚本"
jsonDir = ".\json"
excelDir=unicode(excelDir,'utf8')
jsonDir=unicode(jsonDir,'utf8')
g_objName=""

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

def table2json(table, jsonfilename):
    nrows = table.nrows
    ncols = table.ncols
    if nrows <= 3:
        return
    f = codecs.open(jsonfilename,"w","utf-8")
    f.write(u"[\n")
    for r in range(nrows):
        # if r == 2:
            # continue
        f.write(u"\t[ ")
        for c in range(ncols):
            strCellValue = u""
            objName = str(table.cell_value(1,c))
            global g_objName
            g_objName= objName
            objType = str(table.cell_value(2,c))
            objStr = table.cell_value(r,c)
            if(objName.find("@") >= 0):
                continue
            if r <= 2:
                strCellValue = u"\""  + objStr + u"\""
            else:
                if cmp(objType, "NUMBER") == 0:
                    strCellValue = NumberToString(objStr)
                elif cmp(objType, "FLOAT") == 0:
                    strCellValue = FloatToString(objStr)
                else:
                    strvalue = StringToString(objStr).strip();
                    strvalue = "".join(strvalue.split("\n"))
                    strCellValue = u"\""  + strvalue.replace("\\", "\\\\") + u"\""

            if c < ncols-1:
                isNext = haveNext(table, c+1, 1, ncols)
                if isNext != 0:
                    strCellValue += u", "
            f.write(strCellValue)
        f.write(u" ]")
        if r <= 1 or (r == 2 and nrows > 3) or (r > 2 and r < nrows-1):
            f.write(u",")
        f.write(u"\n")
    f.write(u"]")
    f.close()
    print "Create ",jsonfilename," OK"
    return

def excelToJson(excelFileName,lgFile):
    print 'begin trans excel:' + excelFileName
    lgFile.write('Excel dir:' + excelFileName)
    lgFile.write(u"\r\n")
    names = excelFileName.split('\\')
    xlsName = names[len(names) - 1].split(".")[0]
    if len(names) > 2 :
        xlsName = names[len(names) - 2] + "\\" + xlsName
    childDir = os.path.join(jsonDir, xlsName)
    if not os.path.exists(childDir) :
        os.makedirs(childDir)
    data = xlrd.open_workbook(excelFileName)
    for table in data.sheets():
        print "sheet : " + table.name
        lgFile.write('\t'+'sheetCO : ' + table.name)
        lgFile.write(u"\r\n")
        if (not table.name.lower().startswith('config')) and (not table.name.lower().startswith('sheet')) and (not table.name.lower().startswith('remark')) and (not table.name.lower().startswith('(')):
            destfilename = os.path.join(jsonDir, xlsName + "\\" + table.name + ".json")
            try:
                table2json(table,destfilename)
            except Exception,e:  
                print Exception,":",e
                os.system('pause')
    print "All OK"

if __name__ == '__main__':
    reload(sys)
    sys.setdefaultencoding( "utf-8" )
    if os.path.isdir(jsonDir): 
        shutil.rmtree(jsonDir)
    os.mkdir(jsonDir)
    print excelDir

    try:
        lgFile = codecs.open('excelToJson.txt',"w","utf-8")
        for parent,dirnames,filenames in os.walk(excelDir):
            for filename in filenames:
                if not filename.startswith("~$"):
                    sufix = os.path.splitext(filename)[1][1:]
                    #	print('sufix:' + sufix);
                    if sufix == 'xls' or sufix == 'xlsx':
                        print 'filename : ' + filename
                        excelFileName = os.path.join(parent, filename)
                        excelToJson(excelFileName,lgFile)
        lgFile.write('==========================All OK==================')
        lgFile.close()
    except Exception,e:  
        print Exception,":",e
    # os.system('pause')
