@echo off
title ���ɿͻ���lua�ű�����

@echo.
echo ��ѡ��Ҫ����lua�ű������԰汾��
echo =====================================
@echo.
echo   1 = ��������lua�ű�
echo   2 = Խ �� ��lua�ű�
echo   3 = ��������lua�ű�
@echo.                      
echo =====================================

:loop
set/p server_type=�������ţ�
if %server_type%==1 goto build-chinese
if %server_type%==2 goto build-vietnam
if %server_type%==3 goto build-taiwan
if %server_type% GTR 3 goto next0
if %server_type% LSS 1 goto next0

echo ��ܰ��ʾ��������[1-3]���
@echo.
goto loop

:next0
echo ��ܰ��ʾ���˱�����԰汾��δʵ��
@echo.
goto loop

rem ���ɼ�������lua�ű�
:build-chinese
echo ��Ҫ���ɵ��ǡ��������ġ�lua�ű�
cd .\���߿��ļ�
cmd /c copy_to_csvdata.bat
cmd /c excelToLua.py
goto exit

rem ����Խ����lua�ű�
:build-vietnam
echo ��Ҫ���ɵ��ǡ�Խ���ġ�lua�ű�
cd .\���߿��ļ�
cmd /c excelToLua_vietnam.py
goto exit

rem ���ɷ�������lua�ű�
:build-taiwan
echo ��Ҫ���ɵ��ǡ��������ġ�lua�ű�
cd .\���߿��ļ�
cmd /c excelToLua_taiwan.py
goto exit


:exit
if %errorlevel% equ 0 (
	echo "                       "
	echo "                       "
	echo " �ͻ���LUAȫ�����ɳɹ� "
	echo "                       "
	echo "                       "
	pause
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