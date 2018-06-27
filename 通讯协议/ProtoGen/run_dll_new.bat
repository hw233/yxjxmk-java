@echo off

call Pomelo\build %~dp0\..\proto %~dp0\output  xmds  Xmds.Pomelo  %~dp0\_csharp.txt

echo ---------------------copy files--------------------------------

set asset_lua_dir=..\..\GameEditors\UIEdit\res\ui_edit\lua
set client_plugin_dir=..\..\xMaster\xMasterClient\Assets\Plugins
set client_handler_dir="..\..\xMaster\xMasterClient\Assets\Pro Standard Assets\XmdsBattleClient\XmdsNetClient\XmdsNetHandler"

if exist %asset_lua_dir% (
copy  .\output\proto\lua\*.lua     %asset_lua_dir%\Xmds\Pomelo
copy  .\output\handlers\lua\*.lua  %asset_lua_dir%\Xmds\Pomelo
)
if exist %client_plugin_dir% (
copy .\output\*.dll %client_plugin_dir%
)

echo -----------------------all done ------------------------------------
pause