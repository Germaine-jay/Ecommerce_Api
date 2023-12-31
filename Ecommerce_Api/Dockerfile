#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Ecommerce_Api/Ecommerce_Api.csproj", "Ecommerce_Api/"]
COPY ["Ecommerce.Data/Ecommerce.Data.csproj", "Ecommerce.Data/"]
COPY ["Ecommerce.Models/Ecommerce.Models.csproj", "Ecommerce.Models/"]
COPY ["Ecommerce.Migrations/Ecommerce.Migrations.csproj", "Ecommerce.Migrations/"]
COPY ["Ecommerce.Services/Ecommerce.Services.csproj", "Ecommerce.Services/"]
RUN dotnet restore "Ecommerce_Api/Ecommerce_Api.csproj"
COPY . .
WORKDIR "/src/Ecommerce_Api"
RUN dotnet build "Ecommerce_Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ecommerce_Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce_Api.dll"]