#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Posts/Posts.API/Posts.API.csproj", "Posts/Posts.API/"]
COPY ["Posts/Posts.BLL/Posts.BLL.csproj", "Posts/Posts.BLL/"]
COPY ["Posts/Posts.DAL/Posts.DAL.csproj", "Posts/Posts.DAL/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
RUN dotnet restore "Posts/Posts.API/Posts.API.csproj"
COPY . .
WORKDIR "/src/Posts/Posts.API"
RUN dotnet build "Posts.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Posts.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Posts.API.dll"]