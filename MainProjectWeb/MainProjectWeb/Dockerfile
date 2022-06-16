#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MainProjectWeb/MainProjectWeb.csproj", "MainProjectWeb/"]
RUN dotnet restore "MainProjectWeb/MainProjectWeb.csproj"
COPY . .
WORKDIR "/src/MainProjectWeb"
RUN dotnet build "MainProjectWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MainProjectWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MainProjectWeb.dll"]