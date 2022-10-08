FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /source

COPY . .

RUN dotnet restore ./Host/Host.csproj
RUN dotnet build -c Release --no-restore ./Host/Host.csproj

WORKDIR /source/Host/

RUN dotnet publish -c Release --no-build -o /app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build  /app ./

ENTRYPOINT ["dotnet", "FluentPOS.Gateway.Host.dll"]