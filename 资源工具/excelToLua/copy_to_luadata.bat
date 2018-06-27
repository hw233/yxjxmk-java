@echo off
set SourcePath=..\..\GameEditors\UIEdit\res\ui_edit\lua\Data\
for /d %%p IN ("%SourcePath%\*.*") do rmdir "%%p" /s /q
erase /S /Q "%SourcePath%\*.*"
for /d %%p in ("lua_tmp\*.*") do move /y %%p "%SourcePath%"
for %%p in ("lua_tmp\*.*") do move /y %%p "%SourcePath%"
rd lua_tmp
echo "Explorer to lua path"
pause 
explorer "..\..\GameEditors\UIEdit\res\ui_edit\lua\Data\"