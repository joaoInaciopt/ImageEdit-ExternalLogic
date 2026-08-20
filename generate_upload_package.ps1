Set-ExecutionPolicy -Scope CurrentUser Unrestricted
dotnet publish ImageEdit.csproj -c Release -r linux-x64 --self-contained false -f net10.0
Compress-Archive -Path .\bin\Release\net10.0\linux-x64\publish\* -DestinationPath ExternalLibrary.zip