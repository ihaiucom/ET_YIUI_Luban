set WORKSPACE=../
set WORKSPACEGEN=../../unity/Packages/cn.etetet.config
set GEN_CLIENT=%WORKSPACE%/.Tools/Luban/Luban.dll
set CONF_ROOT=Base
set CUSTOM=%WORKSPACE%/.ToolsGen/Custom

:: 客户端
dotnet %GEN_CLIENT% ^
--customTemplateDir %CUSTOM% ^
-t client ^
-c cs-bin ^
-d bin ^
-d json ^
--conf %CONF_ROOT%/luban.conf ^
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
--conf %CONF_ROOT%\luban.conf ^
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
--conf %CONF_ROOT%\luban.conf ^
-x outputCodeDir=%WORKSPACEGEN%/CodeMode\Model\ClientServer\LubanGen\Config  ^
-x bin.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Binary\ClientServer ^
-x json.outputDataDir=%WORKSPACEGEN%/Assets\LubanGen\Config\Json\ClientServer
echo ==================== 所有 完成 ====================