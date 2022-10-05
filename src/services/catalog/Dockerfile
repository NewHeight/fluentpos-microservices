FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source

COPY ./src/services/catalog/src/ .

RUN dotnet restore ./Catalog.API/Catalog.API.csproj
RUN dotnet build -c Release --no-restore ./Catalog.API/Catalog.API.csproj

WORKDIR /source/Catalog.API/

RUN dotnet publish -c Release --no-build -o /app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build  /app ./

ENTRYPOINT ["dotnet", "FluentPOS.Services.Catalog.API.dll"]