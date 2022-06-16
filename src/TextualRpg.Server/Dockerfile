#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TextualRpg.Server/TextualRpg.Server.csproj", "TextualRpg.Server/"]
RUN dotnet restore "TextualRpg.Server/TextualRpg.Server.csproj"
COPY . .
WORKDIR "/src/TextualRpg.Server"
RUN dotnet build "TextualRpg.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TextualRpg.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TextualRpg.Server.dll"]