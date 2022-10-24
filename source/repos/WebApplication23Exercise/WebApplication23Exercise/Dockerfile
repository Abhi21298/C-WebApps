#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WebApplication23Exercise/WebApplication23Exercise.csproj", "WebApplication23Exercise/"]
RUN dotnet restore "WebApplication23Exercise/WebApplication23Exercise.csproj"
COPY . .
WORKDIR "/src/WebApplication23Exercise"
RUN dotnet build "WebApplication23Exercise.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication23Exercise.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication23Exercise.dll"]