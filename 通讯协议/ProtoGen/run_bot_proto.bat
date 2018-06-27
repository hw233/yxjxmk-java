@echo off
call Pomelo\build %~dp0\..\proto %~dp0\output  xmds  Xmds.Pomelo  %~dp0\_csharp.txt

echo ---------------------copy files--------------------------------

set handlers_csharp_all=E:\work\XmdsCommon\ProtoGen\output\handlers\csharp_all
set proto_csharp_all=E:\work\XmdsCommon\ProtoGen\output\proto\csharp_all

if exist %handlers_csharp_all% rmdir /S/Q %handlers_csharp_all%
if exist %proto_csharp_all% rmdir /S/Q %proto_csharp_all%

mkdir %handlers_csharp_all%
mkdir %proto_csharp_all%

if exist %handlers_csharp_all% copy  .\output\handlers\csharp_all\*.cs     %handlers_csharp_all%
if exist %proto_csharp_all% copy  .\output\proto\csharp_all\*.cs     %proto_csharp_all%

echo -----------------------all done ------------------------------------
pause