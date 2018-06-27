@echo off
tasklist /FI "IMAGENAME eq XmdsBotTest.exe" 2>NUL | find /I /N "XmdsBotTest.exe">NUL
if "%ERRORLEVEL%"=="1" echo have no XmdsBotTest.exe
if "%ERRORLEVEL%"=="0" taskkill /f /t /im XmdsBotTest.exe
start XmdsBotTest n="DDog%iA{0}" c=50
pause