# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

ENV ASPNETCORE_Environment=Production

WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WebServer/*.csproj ./WebServer/
RUN dotnet restore

# copy everything else and build app
COPY WebServer/. ./WebServer/
WORKDIR /source/WebServer
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "WebServer.dll"]