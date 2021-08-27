#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Bookmark/Bookmark.API/Bookmark.API.csproj", "Bookmark/Bookmark.API/"]
COPY ["Bookmark/Bookmark.BLL/Bookmark.BLL.csproj", "Bookmark/Bookmark.BLL/"]
COPY ["Bookmark/Bookmark.DAL/Bookmark.DAL.csproj", "Bookmark/Bookmark.DAL/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
RUN dotnet restore "Bookmark/Bookmark.API/Bookmark.API.csproj"
COPY . .
WORKDIR "/src/Bookmark/Bookmark.API"
RUN dotnet build "Bookmark.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bookmark.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bookmark.API.dll"]