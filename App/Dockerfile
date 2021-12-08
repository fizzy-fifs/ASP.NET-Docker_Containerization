FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

COPY bin/Release/net5.0/publish/ DockerAppDemo/
WORKDIR /DockerAppDemo
ENTRYPOINT ["dotnet", "App.dll", "--urls", "http://0.0.0.0:5000"]