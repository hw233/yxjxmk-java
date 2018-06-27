@echo off
title 生成客户端lua脚本工具

@echo.
echo 请选择要生成lua脚本的语言版本：
echo =====================================
@echo.
echo   1 = 简体中文lua脚本
echo   2 = 越 南 文lua脚本
echo   3 = 繁体中文lua脚本
@echo.                      
echo =====================================

:loop
set/p server_type=请输入编号：
if %server_type%==1 goto build-chinese
if %server_type%==2 goto build-vietnam
if %server_type%==3 goto build-taiwan
if %server_type% GTR 3 goto next0
if %server_type% LSS 1 goto next0

echo 温馨提示：请输入[1-3]编号
@echo.
goto loop

:next0
echo 温馨提示：此编号语言版本尚未实现
@echo.
goto loop

rem 生成简体中文lua脚本
:build-chinese
echo 您要生成的是【简体中文】lua脚本
cd .\工具库文件
cmd /c copy_to_csvdata.bat
cmd /c excelToLua.py
goto exit

rem 生成越南文lua脚本
:build-vietnam
echo 您要生成的是【越南文】lua脚本
cd .\工具库文件
cmd /c excelToLua_vietnam.py
goto exit

rem 生成繁体中文lua脚本
:build-taiwan
echo 您要生成的是【繁体中文】lua脚本
cd .\工具库文件
cmd /c excelToLua_taiwan.py
goto exit


:exit
if %errorlevel% equ 0 (
	echo "                       "
	echo "                       "
	echo " 客户端LUA全部生成成功 "
	echo "                       "
	echo "                       "
	pause
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