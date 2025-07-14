$WORKSPACE="./"
$WORKSPACEGEN="../unity/Packages/cn.etetet.config"
$GEN_CLIENT="$WORKSPACE/.Tools/Luban/Luban.dll"
$CONFIG_ROOT="Config/Base"
$START_CONFIG_ROOT="StartConfig"
$CUSTOM="$WORKSPACE/.ToolsGen/Custom"

$DotNet = "dotnet.exe"
if ($null -ne $IsMacOS) {
    $DotNet = "/usr/local/share/dotnet/dotnet"
}


# 客户端 Client
& $DotNet  $GEN_CLIENT    --customTemplateDir $CUSTOM    -t client    -c cs-bin    -d bin    -d json    --conf $CONFIG_ROOT/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"     -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/Client/LubanGen/Config     -x bin.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Binary/Client    -x json.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Json/Client
Write-Host "==================== Client 客户端 完成 ===================="

# 服务器 Server
& $DotNet   $GEN_CLIENT    --customTemplateDir $CUSTOM    -t server    -c cs-bin    -d bin    -d json    --conf $CONFIG_ROOT/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"    -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/Server/LubanGen/Config     -x bin.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Binary/Server    -x json.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Json/Server
Write-Host "==================== Server 服务器 完成 ===================="


# 所有 ClientServer
& $DotNet   $GEN_CLIENT    --customTemplateDir $CUSTOM    -t all    -c cs-bin    -d bin    -d json    --conf $CONFIG_ROOT/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"    -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/ClientServer/LubanGen/Config     -x bin.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Binary/ClientServer    -x json.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/Config/Json/ClientServer
Write-Host "==================== ClientServer 所有 完成 ===================="





# Localhost
& $DotNet  $GEN_CLIENT    --customTemplateDir $CUSTOM    -t all    -c cs-bin    -d bin    -d json    --conf $START_CONFIG_ROOT/Localhost/Base/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"    -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/Server/LubanGen/StartConfig    -x bin.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/StartConfig/Localhost/Binary/Server    -x json.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/StartConfig/Localhost/Json/Server
Write-Host "==================== Localhost 完成 ===================="

# Release
& $DotNet  $GEN_CLIENT    --customTemplateDir $CUSTOM    -t all    -c cs-bin    -d bin    -d json    --conf $START_CONFIG_ROOT/Release/Base/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"    -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/Server/LubanGen/StartConfig    -x bin.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/StartConfig/Release/Binary/Server    -x json.outputDataDir=$WORKSPACEGEN/Assets/LubanGen/StartConfig/Release/Json/Server
Write-Host "==================== Release 完成 ===================="




# Localhost ClientServer
& $DotNet  $GEN_CLIENT    --customTemplateDir $CUSTOM    -t all    -c cs-bin    --conf $START_CONFIG_ROOT/Localhost/Base/luban.conf    -x tableImporter.filePattern="(.*)"     -x tableImporter.tableNamespaceFormat="{0}"     -x tableImporter.tableNameFormat="{0}ConfigCategory"     -x tableImporter.valueTypeNameFormat="{0}Config"    -x outputCodeDir=$WORKSPACEGEN/CodeMode/Model/ClientServer/LubanGen/StartConfig 
Write-Host "==================== Localhost ClientServer 完成 ===================="
