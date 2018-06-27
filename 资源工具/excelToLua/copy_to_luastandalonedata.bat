@echo off
set SourcePath=..\..\GameEditors\UIEdit\res\ui_edit\lua\Data
set DstPath=..\..\GameEditors\UIEdit\res\ui_edit\lua_standalone\Data
xcopy %SourcePath% %DstPath% /Y /E
echo "Explorer to lua_standalone path"
pause
explorer "%DstPath%"