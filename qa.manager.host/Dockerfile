#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["qa.manager.host/qa.manager.host.csproj", "qa.manager.host/"]
RUN dotnet restore "qa.manager.host/qa.manager.host.csproj"
COPY . .
WORKDIR "/src/qa.manager.host"
RUN dotnet build "qa.manager.host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "qa.manager.host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "qa.manager.host.dll"]