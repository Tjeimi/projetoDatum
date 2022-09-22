@ECHO OFF
dotnet build
robocopy %~dp0bin\Debug\net6.0\ %~dp0\..\ServerBin\ServerBase\ /MOVE