@echo off
title ���ɷ�����json�ű�����

@echo.
echo ��ѡ��Ҫ����json�ű������԰汾��
echo =====================================
@echo.
echo   1 = ���ɼ�������json�ű�
echo   2 = ����Խ����json�ű�
echo   3 = ���ɷ�������json�ű�
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

rem ���ɼ�������json�ű�
:build-chinese
echo ��Ҫ���ɵ��ǡ��������ġ�json�ű�
call .\���߿��ļ�\excelToJson.py
goto exit

rem ����Խ����json�ű�
:build-vietnam
echo ��Ҫ���ɵ��ǡ�Խ���ġ�json�ű�
call .\���߿��ļ�\excelToJson_vietnam.py
goto exit

rem ���ɷ�������json�ű�
:build-taiwan
echo ��Ҫ���ɵ��ǡ��������ġ�json�ű�
call .\���߿��ļ�\excelToJson_taiwan.py
goto exit


echo "                        "
echo "                        "
echo "  json�ű����ɳɹ�      "
echo "                        "
echo "                        "
:exit
pause