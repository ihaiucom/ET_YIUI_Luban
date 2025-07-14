set WORKSPACE=../
set WORKSPACEGEN=../../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONF_ROOT=Base
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom


:: 服务器
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t server ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONF_ROOT%\luban.conf ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\Server\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\Server ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\Server
echo ==================== 服务器 完成 ====================