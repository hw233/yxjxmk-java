@echo off
title �Զ����ɷ���ű�����

@echo.
echo ��ѡ��Ҫ���ɽű��ĵ����汾��
echo =====================================
@echo.
echo   2 = ����Խ�ϰ汾����ű���.\dict\vietnam\unTranslate.xls��
echo   3 = ���ɸ۰�̨�汾����ű���.\dict\taiwan\unTranslate.xls��
@echo.                      
echo =====================================

:loop
set/p server_type=�������ţ�
if %server_type%==1 goto build-chinese
if %server_type%==2 goto build-vietnam
if %server_type%==3 goto build-taiwan
if %server_type% GTR 3 goto next0
if %server_type% LSS 1 goto next0

echo ��ܰ��ʾ��������[2-3]���
@echo.
goto loop

:next0
echo ��ܰ��ʾ���˱�ŵ����汾��δʵ��
@echo.
goto loop

:build-chinese
echo �й���½�������İ汾����Ҫ���ɷ���ű�
@echo.
goto loop

rem ����Խ�ϰ汾����ű�
:build-vietnam
echo ��Ҫ���ɵ��ǡ�Խ�ϰ汾������ű�
call .\���߿��ļ�\createDictionary_vietnam.py
goto exit

rem ���ɸ۰�̨�汾����ű�
:build-taiwan
echo ��Ҫ���ɵ��ǡ��۰�̨�汾������ű�
call .\���߿��ļ�\createDictionary_taiwan.py
goto exit


echo "                        "
echo "                        "
echo "  ����ű����ɳɹ�      "
echo "                        "
echo "                        "
:exit
pause