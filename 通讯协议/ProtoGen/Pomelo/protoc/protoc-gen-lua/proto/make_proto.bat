@echo off

call clean.bat

call copyfrom.bat

cd ..\protoc-gen-lua\plugin\
set plugin_dir=%cd%\build.bat
cd ..\..\proto\
if exist .\lua rmdir /S/Q .\lua\
mkdir .\lua\
REM echo %plugin_dir%
for %%i in (*.proto) do (
	protoc --lua_out=./lua --plugin=protoc-gen-lua="%plugin_dir%" %%i  
)  

::python GenOp.py


call copyto.bat

call clean.bat
