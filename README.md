dotnet ef migrations add "InitDatabase" --project src\Infrastructure --startup-project src\WebAPI --output-dir Migrations

dotnet ef database update --project src\Infrastructure --startup-project src\WebAPI
