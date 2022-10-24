#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WebApplication24/WebApplication24.csproj", "WebApplication24/"]
RUN dotnet restore "WebApplication24/WebApplication24.csproj"
COPY . .
WORKDIR "/src/WebApplication24"
RUN dotnet build "WebApplication24.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplication24.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplication24.dll"]