@echo off
set destPath=..\..\GameEditors\UIEdit\res\ui_edit\config\
rd /q /s %destPath%
xcopy /S /E /Y .\client_csv_config %destPath%
echo "Clinet csv config files have already copied into %destPath%"
pause 