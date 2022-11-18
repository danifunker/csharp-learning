FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /source

COPY *.sln .
COPY WebApplication1/*.csproj ./WebApplication1/
RUN dotnet restore

RUN dotnet build

ENTRYPOINT ["dotnet", "WebApplication1.dll"]
