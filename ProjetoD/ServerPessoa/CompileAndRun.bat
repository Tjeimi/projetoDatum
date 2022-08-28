@ECHO OFF
dotnet build
for %%f in ("%~dp0bin\Debug\net6.0\*.exe") do set "file=%%~nxf"
for %%f in ("%~dp0bin\Debug\net6.0\*.exe") do set "fileWithPath=%%f"
taskkill /IM "%file%" /F
start /B "%fileWithPath%"
