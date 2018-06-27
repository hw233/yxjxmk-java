#!/usr/bin/env python
# coding: utf-8
import os
import os.path
import sys
import codecs
import xlrd
excelDir = ".\excel"
jsonDir = ".\json"
excelDir=unicode(excelDir,'utf8')
jsonDir=unicode(jsonDir,'utf8')

def FloatToString (aFloat):
    if len(str(aFloat)) == 0:
        return '0';
    if type(aFloat) != float:
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

def table2jsn(table, jsonfilename):
    nrows = table.nrows
    ncols = table.ncols
    f = codecs.open(jsonfilename,"w","utf-8")
    f.write(u"[\n")
    for r in range(nrows):
        if r == 2:
            continue
        f.write(u"\t[ ")
        for c in range(ncols):
            strCellValue = u""
            objName = str(table.cell_value(1,c))
            objType = str(table.cell_value(2,c))
            objStr = table.cell_value(r,c)
            if(objName.find("@") >= 0):
                continue
            if r == 0 or r == 1:
                strCellValue = u"\""  + objStr + u"\""
            else:
                if cmp(objType, "NUMBER") == 0:
                    strCellValue = FloatToString(objStr)
                else:
                    strvalue = StringToString(objStr).strip();
                    strvalue = "".join(strvalue.split("\n"))
                    strCellValue = u"\""  + strvalue + u"\""

            if c < ncols-1:
                isNext = haveNext(table, c+1, 1, ncols)
                if isNext != 0:
                    strCellValue += u", "
            f.write(strCellValue)
        f.write(u" ]")
        if r < nrows-1:
            f.write(u",")
        f.write(u"\n")
    f.write(u"]")
    f.close()
    print "Create ",jsonfilename," OK"
    return

def excelToJson(excelFileName):
    print 'begin trans excel:' + excelFileName
    data = xlrd.open_workbook(excelFileName)
    for table in data.sheets():
        print table.name
        if (not table.name.lower().startswith('config')) and (not table.name.lower().startswith('remark')) and (not table.name.lower().startswith('(')):
            destfilename = os.path.join(jsonDir, table.name + ".json")
            table2jsn(table,destfilename)

    print "All OK"

if __name__ == '__main__':
    reload(sys)
    sys.setdefaultencoding( "utf-8" )
    print excelDir
    for parent,dirnames,filenames in os.walk(excelDir):
        for filename in filenames:
            sufix = os.path.splitext(filename)[1][1:]
            print('sufix:' + sufix);
            if sufix == 'xls' or sufix == 'xlsx' or sufix == 'xlsm':
                print 'filename:' + filename
                excelFileName = os.path.join(parent, filename)
                excelToJson(excelFileName)
    os.system('pause')
