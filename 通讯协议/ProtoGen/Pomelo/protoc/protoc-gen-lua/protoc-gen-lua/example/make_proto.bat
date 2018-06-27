for %%i in (*.proto) do (  
    protoc --lua_out=./ --plugin=protoc-gen-lua="E:/workspace_git/pvzas-client-lua/tools/protoc-gen-lua/protoc-gen-lua/plugin/build.bat" %%i  
)  