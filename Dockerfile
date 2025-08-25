# Etapa de build
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

#Imagen para compilar
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .

# Restaurar y publicar solo tu app
RUN dotnet restore s16electiva2/HolaMundoApp/HolaMundoApp.csproj
RUN dotnet publish s16electiva2/HolaMundoApp/HolaMundoApp.csproj -c Release -o /app/publish

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "HolaMundoApp.dll"]

