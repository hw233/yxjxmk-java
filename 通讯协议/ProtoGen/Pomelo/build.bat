
set input_dir=%1
set output_dir=%2
set prj_name=%3
set lua_prefix=%4
set csharp_filter=%5

set csc_dir="C:\Windows\Microsoft.NET\Framework64\v3.5"
set mono_dir="%~dp0\protoc\mono"

echo ---------------------------------------------------------------------------
echo - Init 
echo ---------------------------------------------------------------------------
set csharp_gen_dir=%~dp0\protoc\protoc-gen-cs
set csharp_dll_dir=%~dp0\protoc\protoc-gen-cs\library
set lua_gen_dir=%~dp0\protoc\protoc-gen-lua
set lua_plugin_dir=%~dp0\protoc\protoc-gen-lua\protoc-gen-lua\plugin\build.bat
set java_tools_dir=%~dp0

echo  input dir at : %input_dir%
echo output dir at : %output_dir%
echo  project name : %prj_name%
echo    lua prefix : %lua_prefix%
echo csharp filter : %csharp_filter%

echo ---------------------------------------------------------------------------
echo - Make Dir
echo ---------------------------------------------------------------------------
set proto_out=%output_dir%\proto
if exist %proto_out% (
if exist %proto_out%\lua    	rmdir /S/Q %proto_out%\lua
if exist %proto_out%\csharp 	rmdir /S/Q %proto_out%\csharp
if exist %proto_out%\csharp_all rmdir /S/Q %proto_out%\csharp_all
if exist %proto_out%\js     	rmdir /S/Q %proto_out%\js
) else (
mkdir %proto_out%
)
echo proto output at : %proto_out%
mkdir %proto_out%\lua
mkdir %proto_out%\csharp
mkdir %proto_out%\csharp_all
mkdir %proto_out%\js

set handlers_out=%output_dir%\handlers
if exist %handlers_out% (
if exist %handlers_out%\lua    		rmdir /S/Q %handlers_out%\lua
if exist %handlers_out%\csharp 		rmdir /S/Q %handlers_out%\csharp
if exist %handlers_out%\csharp_all	rmdir /S/Q %handlers_out%\csharp_all
if exist %handlers_out%\js     		rmdir /S/Q %handlers_out%\js
if exist %handlers_out%\temp   		rmdir /S/Q %handlers_out%\temp
) else (
mkdir %handlers_out%
)
echo handlers output at : %handlers_out%
mkdir %handlers_out%\lua
mkdir %handlers_out%\csharp
mkdir %handlers_out%\csharp_all
mkdir %handlers_out%\js
mkdir %handlers_out%\temp

set input_cs_dir=%input_dir%

echo ---------------------------------------------------------------------------
echo - Filter CS files
echo ---------------------------------------------------------------------------
if exist %csharp_filter% (
set input_cs_dir=%output_dir%\temp
mkdir %output_dir%\temp
echo CopyResource  %input_dir%  %output_dir%\temp  %csharp_filter%
java -classpath %java_tools_dir%/g2d_studio.jar CopyResource  %input_dir% %output_dir%\temp %csharp_filter%
)
echo input cs dir at : %input_cs_dir%

echo ---------------------------------------------------------------------------
echo - Gen proto files
echo ---------------------------------------------------------------------------
echo ---- gen unity cs files ----
for /f "delims=" %%i in ('dir /b/a "%input_cs_dir%\*.proto"') do (
%csharp_gen_dir%\protogen.exe -t:csharp-tiny -w:%input_cs_dir% -i:%input_cs_dir%\%%i -o:%proto_out%\csharp\_%%~ni.cs
)
echo ---- gen bot cs files ----
for /f "delims=" %%i in ('dir /b/a "%input_dir%\*.proto"') do (
%csharp_gen_dir%\protogen.exe -t:csharp-tiny -w:%input_dir% -i:%input_dir%\%%i -o:%proto_out%\csharp_all\_%%~ni.cs
)
echo ---- gen lua files ----
for /f "delims=" %%i in ('dir /b/a "%input_dir%\*.proto"') do (
%lua_gen_dir%\protoc.exe --proto_path=%input_dir% --lua_out=%proto_out%\lua --plugin=protoc-gen-lua="%lua_plugin_dir%" %input_dir%\%%i  
)

echo ---------------------------------------------------------------------------
echo - Gen handlers files
echo ---------------------------------------------------------------------------
node "%~dp0\pomelo-gen\genPomeloProtoNew.js" input=%input_dir% output=%handlers_out%\csharp_all  outputLua=%handlers_out%\lua   pathLua=%lua_prefix% outputJs=%handlers_out%\js
if errorlevel 1 (
   echo Failure Reason Given is %errorlevel%
   pause
   goto END
)
echo ---- gen unity handlers files ----
node "%~dp0\pomelo-gen\genPomeloProtoNew.js" input=%input_cs_dir%  output=%handlers_out%\csharp  outputLua=%handlers_out%\temp  pathLua=%lua_prefix% outputJs=%handlers_out%\temp
if errorlevel 1 (
   echo Failure Reason Given is %errorlevel%
   pause
   goto END
)

echo ---------------------------------------------------------------------------
echo - Build : %prj_name%-proto.dll
echo ---------------------------------------------------------------------------
copy %csharp_dll_dir%\protobuf-net.dll         %output_dir%\
copy %csharp_dll_dir%\pomelo-dotnetClient.dll  %output_dir%\
%csc_dir%\csc  /target:library /out:%output_dir%\%prj_name%-proto.dll %proto_out%\csharp\*.cs /r:System.Data.dll;System.dll;%csharp_dll_dir%/protobuf-net.dll
if errorlevel 1 (
   echo Failure Reason Given is %errorlevel%
   pause
   goto END
)

echo ---------------------------------------------------------------------------
echo - Build : %prj_name%-handlers.dll
echo ---------------------------------------------------------------------------
%mono_dir%\mcs /target:library /out:%output_dir%\%prj_name%-handlers.dll %handlers_out%\csharp\*.cs /r:%mono_dir%\System.Core.dll;%output_dir%\protobuf-net.dll;%output_dir%\pomelo-dotnetClient.dll;%output_dir%\%prj_name%-proto.dll
if errorlevel 1 (
   echo Failure Reason Given is %errorlevel%
   pause
   goto END
)

echo ---------------------------------------------------------------------------
echo - Precompile : ProtobufSerializer.dll
echo ---------------------------------------------------------------------------
%csharp_dll_dir%\Precompile\precompile.exe %output_dir%\%prj_name%-proto.dll -o:%output_dir%\ProtobufSerializer.dll -t:ProtobufSerializer
if errorlevel 1 (
   echo Failure Reason Given is %errorlevel%
   pause
   goto END
)

echo ---------------------------------------------------------------------------
echo - Done
echo ---------------------------------------------------------------------------
:END
if exist %output_dir%\temp rmdir /S/Q %output_dir%\temp
