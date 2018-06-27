@echo off
echo ---------------------gen pomelo files--------------------------------
cd ..\proto

set pomelo_java_dir=E:\mmoarpg\mmoarpg-proto\src\main\java
if exist %pomelo_java_dir% rmdir /S/Q %pomelo_java_dir%\
mkdir %pomelo_java_dir%

for /f "delims=" %%i in ('dir /b/a "*.proto"') do (
	if %%i NEQ loginHandler.proto (
		..\protoc\protoc -I=. --java_out=%pomelo_java_dir% %%i
	)
)

echo -----------------------all done ------------------------------------

@pause