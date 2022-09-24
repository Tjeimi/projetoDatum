@ECHO OFF
dotnet build
ECHO "TENTANDO PARAR O SERVIDOR BASE CASO ESTEJA RODANDO"
taskkill /IM "ServerBase.exe" /F
robocopy %~dp0bin\Debug\net6.0\ %~dp0\..\ServerBin\ServerBase\ /MOVE
cd ..\ServerBin\ServerBase
start cmd /c "ServerBase.exe"