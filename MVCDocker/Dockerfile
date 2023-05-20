FROM mcr.microsoft.com/dotnet/aspnet:7.0 
WORKDIR /app
COPY . .
RUN dotnet restore 
RUN dotnet publish MVCDocker.csproj -c Realese -o out
WORKDIR out 
ENV ASPNETCORE_URLS="http://*:4500"
ENTRYPOINT ["dotnet","DockerApi.dll"]