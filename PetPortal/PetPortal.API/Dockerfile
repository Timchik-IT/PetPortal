FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PetPortal.API/PetPortal.API.csproj", "PetPortal.API/"]
COPY ["PetPortal.DataAccess/PetPortal.DataAccess.csproj", "PetPortal.DataAccess/"]
RUN dotnet restore "PetPortal.API/PetPortal.API.csproj"
COPY . .
WORKDIR "/src/PetPortal.API"
RUN dotnet build "PetPortal.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PetPortal.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PetPortal.API.dll"]
