@echo off

for /f "delims=" %%i in ('dir /b/a "*.proto"') do protogen -i:%%i -o:.\%%~ni.cs


@pause