cd /d %~dp0

if not exist %~dp0\unity\Packages\zeng.gameframe.ugui (
    mklink /j %~dp0\unity\Packages\zeng.gameframe.ugui %~dp0\..\zeng.gameframe.ugui\unity\Assets\gameframe\ui
) 
