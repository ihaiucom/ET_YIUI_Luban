set WORKSPACE=../
set WORKSPACEGEN=../../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONF_ROOT=Base
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom


:: Localhost
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONF_ROOT%\..\Localhost\Base\luban.conf ^
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
--conf %CONF_ROOT%\..\Release\Base\luban.conf ^
-x outputCodeDir=%WORKSPACEGEN%\CodeMode\Model\Server\LubanGen\StartConfig ^
-x bin.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Release\Binary\Server ^
-x json.outputDataDir=%WORKSPACEGEN%\Assets\LubanGen\StartConfig\Release\Json\Server
echo ==================== Release 完成 ====================




:: Localhost ClientServer
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t all ^
-c cs-bin ^
--conf %CONF_ROOT%\..\Localhost\Base\luban.conf ^
-x outputCodeDir=%WORKSPACEGEN%\CodeMode\Model\ClientServer\LubanGen\StartConfig 
echo ==================== Localhost ClientServer 完成 ====================
