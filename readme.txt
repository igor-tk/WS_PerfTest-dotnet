Command to publish:

dotnet publish -c release -r win-x64 -p:PublishSingleFile=true --self-contained true

Command to run:

.\WS_PerfTest.exe --urls http://0.0.0.0:8181 --contentroot . --Logging:LogLevel:Microsoft=Warning