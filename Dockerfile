# download .net6
FROM mcr.microsoft.com/dotnet/sdk:6.0.408-focal-amd64

# create project folder
RUN mkdir source

# go to source and create C# project 
WORKDIR /source
RUN dotnet new console

# copy all file from src to source
COPY . /source

# go to source/bin and change file name from "libhcnetsdk.so" to "HCNetSDK.dll"
WORKDIR /source/bin
RUN mv libhcnetsdk.so HCNetSDK.dll

# go to source then remove Dockerfile and README.md
WORKDIR /source
RUN rm Dockerfile
RUN rm README.md

# RUN dotnet publish /containerize.csproj -c release -o /app