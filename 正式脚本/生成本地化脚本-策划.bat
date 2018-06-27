@echo off
title 自动生成翻译脚本工具

@echo.
echo 请选择要生成脚本的地区版本：
echo =====================================
@echo.
echo   2 = 生成越南版本翻译脚本（.\dict\vietnam\unTranslate.xls）
echo   3 = 生成港澳台版本翻译脚本（.\dict\taiwan\unTranslate.xls）
@echo.                      
echo =====================================

:loop
set/p server_type=请输入编号：
if %server_type%==1 goto build-chinese
if %server_type%==2 goto build-vietnam
if %server_type%==3 goto build-taiwan
if %server_type% GTR 3 goto next0
if %server_type% LSS 1 goto next0

echo 温馨提示：请输入[2-3]编号
@echo.
goto loop

:next0
echo 温馨提示：此编号地区版本尚未实现
@echo.
goto loop

:build-chinese
echo 中国大陆简体中文版本不需要生成翻译脚本
@echo.
goto loop

rem 生成越南版本翻译脚本
:build-vietnam
echo 您要生成的是【越南版本】翻译脚本
call .\工具库文件\createDictionary_vietnam.py
goto exit

rem 生成港澳台版本翻译脚本
:build-taiwan
echo 您要生成的是【港澳台版本】翻译脚本
call .\工具库文件\createDictionary_taiwan.py
goto exit


echo "                        "
echo "                        "
echo "  翻译脚本生成成功      "
echo "                        "
echo "                        "
:exit
pause