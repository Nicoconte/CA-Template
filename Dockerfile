FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /app

COPY ./*.sln .
COPY src/WebAPI/*.csproj ./src/WebAPI/
COPY src/Infrastructure/*.csproj ./src/Infrastructure/
COPY src/Domain/*.csproj ./src/Domain/

RUN dotnet restore

COPY . .

WORKDIR /app/src/WebAPI
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "WebAPI.dll"]