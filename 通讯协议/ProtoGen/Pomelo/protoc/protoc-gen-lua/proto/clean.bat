@echo off

del /Q/S *.proto
del /Q/S *.lua
if exist .\lua rmdir /Q/S .\lua\