@echo off
title 生成服务器json脚本工具

@echo.
echo 请选择要生成json脚本的语言版本：
echo =====================================
@echo.
echo   1 = 生成简体中文json脚本
echo   2 = 生成越南文json脚本
echo   3 = 生成繁体中文json脚本
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

rem 生成简体中文json脚本
:build-chinese
echo 您要生成的是【简体中文】json脚本
call .\工具库文件\excelToJson.py
goto exit

rem 生成越南文json脚本
:build-vietnam
echo 您要生成的是【越南文】json脚本
call .\工具库文件\excelToJson_vietnam.py
goto exit

rem 生成繁体中文json脚本
:build-taiwan
echo 您要生成的是【繁体中文】json脚本
call .\工具库文件\excelToJson_taiwan.py
goto exit


echo "                        "
echo "                        "
echo "  json脚本生成成功      "
echo "                        "
echo "                        "
:exit
pause