@echo off
cmd /c excelToLua.py
if %errorlevel% equ 0 (
	cmd /c copy_to_luadata.bat
	exit
)
color fc
title ����
echo "             �������������ʱ������             "
echo "             �������������ʱ������             "
echo "             �������������ʱ������             "
echo "                 �����Ϸ���ʾ�޸���               "
pause