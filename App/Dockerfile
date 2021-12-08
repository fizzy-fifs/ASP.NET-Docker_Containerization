FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

#Copy from current directory to container: app
COPY https://github.com/fizzy-fifs/ASP.NET-Docker_Containerization.git app/

#Install all dependencies
RUN ["dotnet", "publish"]

COPY bin/Release/net5.0/publish/ DockerAppDemo/
WORKDIR /DockerAppDemo
ENTRYPOINT ["dotnet", "App.dll", "--urls", "http://0.0.0.0:5000"]

RUN docker run -dp 5000:5000 --name app aspnet-example-image