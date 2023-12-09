param(
    [string]$appName
)

# Reemplazar el nombre del proyecto en WebAPI.csproj
(Get-Content "src/WebAPI/WebAPI.csproj") -replace 'WebAPI', $appName | Set-Content "src/WebAPI/WebAPI.csproj"

# Reemplazar el ENTRYPOINT en el Dockerfile
(Get-Content "Dockerfile") -replace 'ENTRYPOINT \["dotnet", "WebAPI.dll"\]', ('ENTRYPOINT ["dotnet", "{0}.dll"]' -f $appName) | Set-Content "Dockerfile"

(Get-Content "./EasyCA.Template.sln") -replace 'EasyCA.Template', $appName | Set-Content "EasyCA.Template.sln"

Remove-Item -Path "src/WebAPI/bin" -Force -Recurse
Remove-Item -Path "src/WebAPI/obj" -Force -Recurse
Remove-Item -Path "src/Application/bin" -Force -Recurse
Remove-Item -Path "src/Application/obj" -Force -Recurse
Remove-Item -Path "src/Domain/bin" -Force -Recurse
Remove-Item -Path "src/Domain/obj" -Force -Recurse
Remove-Item -Path "src/Infrastructure/bin" -Force -Recurse
Remove-Item -Path "src/Infrastructure/obj" -Force -Recurse
