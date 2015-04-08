@echo off
if "%1"=="(x86)" goto sf
if "%1"=="deploy" goto deploy
goto tt

:sf
echo %date%
C:
cd "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\"
devenv /Rebuild Debug "\\192.168.0.236\New SysFreight Source 802\SysFreight.sln"

:deploy
echo %date%
C:
cd "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\"
devenv /Rebuild Debug "\\192.168.0.236\New SysFreight Source 802\SysFreight\SysFreightMain\SysFreight.vbproj"

:tt
echo %date%
C:
cd "C:\Program Files (x86)\MSBuild\12.0\Bin"
msbuild "\\192.168.0.236\New SysFreight Source 802\SysFreight.sln" /t:rebuild 