set WORKSPACE=./
set WORKSPACEGEN=../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONFIG_ROOT=Config/Base
set START_CONFIG_ROOT=StartConfig
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom

dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-f  ^
--conf %CONFIG_ROOT%/luban.conf 

pause
