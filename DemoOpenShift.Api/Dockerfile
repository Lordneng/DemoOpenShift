#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DemoOpenShift.Api/DemoOpenShift.Api.csproj", "DemoOpenShift.Api/"]
COPY ["DemoOpenShift.Services/DemoOpenShift.Services.csproj", "DemoOpenShift.Services/"]
RUN dotnet restore "DemoOpenShift.Api/DemoOpenShift.Api.csproj"
COPY . .
WORKDIR "/src/DemoOpenShift.Api"
RUN dotnet build "DemoOpenShift.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoOpenShift.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoOpenShift.Api.dll"]