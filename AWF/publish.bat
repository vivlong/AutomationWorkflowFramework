@echo off
echo %date%
C:
cd "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\"
devenv /deploy Debug "D:\New SysFreight Source 801\SysFreight.sln"
pause