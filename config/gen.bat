set WORKSPACE=./
set WORKSPACEGEN=../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONFIG_ROOT=Config/Base
set START_CONFIG_ROOT=StartConfig
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom

:: 客户端
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t client ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONFIG_ROOT%/luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\Client\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\Client ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\Client
echo ==================== 客户端 完成 ====================


:: 服务器
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t server ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONFIG_ROOT%\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\Server\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\Server ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\Server
echo ==================== 服务器 完成 ====================


:: 所有
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONFIG_ROOT%\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\ClientServer\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\ClientServer ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\ClientServer
echo ==================== 所有 完成 ====================





:: Localhost
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %START_CONFIG_ROOT%\Localhost\Base\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%\CodeMode\Model\Server\LubanGen\StartConfig ^
-x bin.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Localhost\Binary\Server ^
-x json.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Localhost\Json\Server
echo ==================== Localhost 完成 ====================

:: Release
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %START_CONFIG_ROOT%\Release\Base\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%\CodeMode\Model\Server\LubanGen\StartConfig ^
-x bin.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Release\Binary\Server ^
-x json.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Release\Json\Server
echo ==================== Release 完成 ====================




:: Localhost ClientServer
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
--conf %START_CONFIG_ROOT%\Localhost\Base\luban.conf ^
-x tableImporter.filePattern=(.*) ^
-x tableImporter.tableNamespaceFormat={0} ^
-x tableImporter.tableNameFormat={0}ConfigCategory ^
-x tableImporter.valueTypeNameFormat={0}Config ^
-x outputCodeDir=%WORKSPACEGEN%\CodeMode\Model\ClientServer\LubanGen\StartConfig 
echo ==================== Localhost ClientServer 完成 ====================
