FROM mcr.microsoft.com/dotnet/sdk:6.0.408-focal-amd64
RUN mkdir source
WORKDIR /source
RUN dotnet new console
# RUN dotnet publish /containerize.csproj -c release -o /app