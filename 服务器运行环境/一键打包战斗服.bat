@echo off
title һ�����ս����

@echo.
echo ��ȷ�����ı༭��������ݱ�������
echo =====================================
@echo.
echo   Y = �ѱ���
echo   N = δ����
@echo.                      
echo =====================================

rem ����Ŀ��λ��
rd /s /Q dist

:loop
set/p server_type=������Y/N��
if %server_type%==Y goto build
if %server_type%==N goto nobuild
if %server_type%==y goto build
if %server_type%==n goto nobuild

echo ��ܰ��ʾ��������Y/N
@echo.
goto loop

rem ����ս����
:build
rem ��ǰʱ����Ϊ������ʱ�侫ȷ������
set date=%Date:~0,4%%Date:~5,2%%Date:~8,2%%time:~0,2%%time:~3,2%
echo ����Ϊ�������Ŀ��λ�ã�dist/B%date%.zip
@echo.

rem ���ɵ�Ŀ��λ��
set target_dirs=dist\B%date%\
for %%i in (%target_dirs%) do (
	if not exist %%i (
		md %%i
	)
)

md %target_dirs%\server
md %target_dirs%\data

xcopy Release_cehua %target_dirs%\server /g /e /q /y
xcopy ..\GameEditors\GameEditor\data %target_dirs%\data /g /e /q /y

cd dist
set temp_tar=B%date%.zip
..\script\7z.exe a -tzip %temp_tar% ".\B%date%\*"
goto exit

rem ȡ������ս����
:nobuild
@echo. 
echo �ѷ����������
@echo. 
goto exit

:exit
pause