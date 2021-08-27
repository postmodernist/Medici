#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ImageAlbum/ImageAlbum.API/ImageAlbum.API.csproj", "ImageAlbum/ImageAlbum.API/"]
COPY ["ImageAlbum/ImageAlbum.Application/ImageAlbum.Application.csproj", "ImageAlbum/ImageAlbum.Application/"]
COPY ["ImageAlbum/ImageAlbum.Domain/ImageAlbum.Domain.csproj", "ImageAlbum/ImageAlbum.Domain/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
COPY ["ImageAlbum/ImageAlbum.Infrastructure/ImageAlbum.Infrastructure.csproj", "ImageAlbum/ImageAlbum.Infrastructure/"]
RUN dotnet restore "ImageAlbum/ImageAlbum.API/ImageAlbum.API.csproj"
COPY . .
WORKDIR "/src/ImageAlbum/ImageAlbum.API"
RUN dotnet build "ImageAlbum.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ImageAlbum.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ImageAlbum.API.dll"]