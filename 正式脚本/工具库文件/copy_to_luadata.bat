@echo off
set SourcePath=..\..\GameEditors\UIEdit\res\ui_edit\lua\Data\
rd /q /s %SourcePath%
xcopy /S /E /Y ..\lua %SourcePath%
echo "Explorer to lua path"
pause 
explorer %SourcePath%