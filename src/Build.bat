@echo off
pushd %~dp0
call :build-project Import\Import.csproj %*
call :build-project Hive\Hive.csproj %*
call :build-project Bumblebee\Bumblebee.csproj %*
popd
goto:eof

:build-project %1=project-path %*=options
call :banner Building %1
msbuild /nologo %*
goto:eof

:banner %*=output
echo.
echo [4m     %*     [0m
echo.
goto:eof