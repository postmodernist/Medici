#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FileStorage/FileStorage.API/FileStorage.API.csproj", "FileStorage/FileStorage.API/"]
COPY ["FileStorage/FileStorage.BLL/FileStorage.BLL.csproj", "FileStorage/FileStorage.BLL/"]
COPY ["FileStorage/FileStorage.DAL/FileStorage.DAL.csproj", "FileStorage/FileStorage.DAL/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
RUN dotnet restore "FileStorage/FileStorage.API/FileStorage.API.csproj"
COPY . .
WORKDIR "/src/FileStorage/FileStorage.API"
RUN dotnet build "FileStorage.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FileStorage.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FileStorage.API.dll"]