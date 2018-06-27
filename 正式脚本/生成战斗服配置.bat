REM cd .\策划脚本\monster

REM call copyxlsx2gameeditor.bat

@echo -----------------------------------------------------------------------------------
@echo - CopyData2GameEditor
@echo -----------------------------------------------------------------------------------

@IF EXIST ".\策划脚本\monster\Monster.*" (
@copy /Y ".\策划脚本\monster\Monster.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\策划脚本\monster\MonsterDynamicProp.*" (
@copy /Y ".\策划脚本\monster\MonsterDynamicProp.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\策划脚本\skill\SkillData.*" (
@copy /Y ".\策划脚本\skill\SkillData.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\策划脚本\npc\NpcData.*" (
@copy /Y ".\策划脚本\npc\NpcData.*"          "..\GameEditors\GameEditor\data\data_config\"
)
start ..\GameEditors\GameEditor\data\data_config\
