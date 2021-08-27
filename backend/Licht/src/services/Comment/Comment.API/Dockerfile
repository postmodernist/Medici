#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Comment/Comment.API/Comment.API.csproj", "Comment/Comment.API/"]
COPY ["Comment/Comment.BLL/Comment.BLL.csproj", "Comment/Comment.BLL/"]
COPY ["LichtDataPack/LichtDataPack/LichtDataPack.csproj", "LichtDataPack/LichtDataPack/"]
COPY ["Comment/Comment.DAL/Comment.DAL.csproj", "Comment/Comment.DAL/"]
RUN dotnet restore "Comment/Comment.API/Comment.API.csproj"
COPY . .
WORKDIR "/src/Comment/Comment.API"
RUN dotnet build "Comment.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Comment.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Comment.API.dll"]