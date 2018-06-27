#coding=gbk
#!/usr/bin/env python
from __future__ import with_statement
from xml.dom.minidom import Document
import os
import zlib


SEARCH_DIR = "./"
HEAD_STR = "require \""
TAIL_STR = "\"\n"
SRC_TXT = "./lua/ProtoOp_pb.lua"

def main():
   
    f_out = open(SRC_TXT, 'w')
    
    f_in = open("ProtoOp.proto")
    
    
    line = f_in.readline()
    while line:
        opPos = line.find("OP_")
        if opPos == -1:
                line = f_in.readline()
                continue

        endPos = line.find(";")
        code = line[opPos:endPos]
        f_out.write(code + "\n")
        #print code
        
        line = f_in.readline()
        

    f_out.close()
    
    f_in.close()

if __name__ == "__main__":
    main()