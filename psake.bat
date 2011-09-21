@echo off

SET DIR=%~dp0%packages\psake.4.0.1.0\tools\

if '%1'=='/?' goto usage
if '%1'=='-?' goto usage
if '%1'=='?' goto usage
if '%1'=='/help' goto usage
if '%1'=='help' goto usage

powershell -NoProfile -ExecutionPolicy unrestricted -Command "& '%DIR%psake.ps1' %*"

goto :eof
:usage
powershell -NoProfile -ExecutionPolicy unrestricted -Command "& '%DIR%psake-help.ps1'"