@echo off
title 一键打包战斗服

@echo.
echo 请确认您的编辑器里的数据保存了吗？
echo =====================================
@echo.
echo   Y = 已保存
echo   N = 未保存
@echo.                      
echo =====================================

rem 清理目标位置
rd /s /Q dist

:loop
set/p server_type=请输入Y/N：
if %server_type%==Y goto build
if %server_type%==N goto nobuild
if %server_type%==y goto build
if %server_type%==n goto nobuild

echo 温馨提示：请输入Y/N
@echo.
goto loop

rem 制作战斗服
:build
rem 当前时间作为包名，时间精确到分钟
set date=%Date:~0,4%%Date:~5,2%%Date:~8,2%%time:~0,2%%time:~3,2%
echo 正在为您打包，目标位置：dist/B%date%.zip
@echo.

rem 生成的目标位置
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

rem 取消制作战斗服
:nobuild
@echo. 
echo 已放弃打包任务
@echo. 
goto exit

:exit
pause