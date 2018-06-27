@echo -----------------------------------------------------------------------------------
@echo - CopyData2GameEditor
@echo -----------------------------------------------------------------------------------

@IF EXIST "Monster.*" (
@copy /Y "Monster.*"          "..\..\..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST "MonsterDynamicProp.*" (
@copy /Y "MonsterDynamicProp.*"          "..\..\..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST "SkillData.*" (
@copy /Y "SkillData.*"          "..\..\..\GameEditors\GameEditor\data\data_config\"
)

@IF EXIST "NpcData.*" (
@copy /Y "NpcData.*"          "..\..\..\GameEditors\GameEditor\data\data_config\"
)
start ..\..\..\GameEditors\GameEditor\data\data_config\


