#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Article/Article.API/Article.API.csproj", "Article/Article.API/"]
COPY ["Article/Article.BLL/Article.BLL.csproj", "Article/Article.BLL/"]
COPY ["Article/Article.DAL/Article.DAL.csproj", "Article/Article.DAL/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
RUN dotnet restore "Article/Article.API/Article.API.csproj"
COPY . .
WORKDIR "/src/Article/Article.API"
RUN dotnet build "Article.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Article.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Article.API.dll"]