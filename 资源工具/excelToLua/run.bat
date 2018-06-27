@echo off
cmd /c excelToLua.py
if %errorlevel% equ 0 (
	cmd /c copy_to_luadata.bat
	exit
)
color fc
title 错误
echo "             错误总是在这个时候发生了             "
echo "             错误总是在这个时候发生了             "
echo "             错误总是在这个时候发生了             "
echo "                 根据上方提示修复！               "
pause