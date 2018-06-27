@echo off
for /f "tokens=2 delims=:" %%i in ('ipconfig ^| findstr "192.168.1\."') do (
	set ip=%%i
	GOTO :END
)
:END
title java²ß»®·þ
java -Xdebug -Xrunjdwp:transport=dt_socket,address=3019,server=y,suspend=n -javaagent:agent.jar -jar mmoarpg-game.jar %ip%