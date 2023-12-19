#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DetectiveHelper.Api/DetectiveHelper.Api.csproj", "DetectiveHelper.Api/"]
RUN dotnet restore "DetectiveHelper.Api/DetectiveHelper.Api.csproj"
COPY . .
WORKDIR "/src/DetectiveHelper.Api"
RUN dotnet build "DetectiveHelper.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DetectiveHelper.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DetectiveHelper.Api.dll"]