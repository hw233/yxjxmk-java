REM cd .\�߻��ű�\monster

REM call copyxlsx2gameeditor.bat

@echo -----------------------------------------------------------------------------------
@echo - CopyData2GameEditor
@echo -----------------------------------------------------------------------------------

@IF EXIST ".\�߻��ű�\monster\Monster.*" (
@copy /Y ".\�߻��ű�\monster\Monster.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\�߻��ű�\monster\MonsterDynamicProp.*" (
@copy /Y ".\�߻��ű�\monster\MonsterDynamicProp.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\�߻��ű�\skill\SkillData.*" (
@copy /Y ".\�߻��ű�\skill\SkillData.*"          "..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST ".\�߻��ű�\npc\NpcData.*" (
@copy /Y ".\�߻��ű�\npc\NpcData.*"          "..\GameEditors\GameEditor\data\data_config\"
)
start ..\GameEditors\GameEditor\data\data_config\
