@echo off
if "%1"=="(x86)" goto sf
if "%1"=="deploy" goto deploy
goto tt

:tt
echo %date%
C:
cd "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\"
devenv /Rebuild Debug "D:\New SysFreight Source 801\SysFreight.sln"

:sf
echo %date%
C:
cd "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\"
devenv /Rebuild Debug "D:\New SysFreight Source 801\SysFreight.sln"

:deploy
echo %date%
C:
cd "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\"
devenv /Rebuild Debug "D:\New SysFreight Source 801\SysFreight\SysFreightMain\SysFreight.vbproj"