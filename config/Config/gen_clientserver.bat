set WORKSPACE=../
set WORKSPACEGEN=../../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONF_ROOT=Base
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom


:: 所有
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONF_ROOT%\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\ClientServer\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\ClientServer ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\ClientServer
echo ==================== 所有 完成 ====================