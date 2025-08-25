# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copiar archivos de proyecto y restaurar dependencias
COPY HolaMundoApp/*.csproj ./HolaMundoApp/
RUN dotnet restore HolaMundoApp/HolaMundoApp.csproj

# Copiar el resto de los archivos y compilar
COPY HolaMundoApp/. ./HolaMundoApp/
WORKDIR /app/HolaMundoApp
RUN dotnet publish -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/HolaMundoApp/out ./

# Cambia 'HolaMundoApp.dll' por el nombre correcto si tu proyecto principal tiene otro nombre
ENTRYPOINT ["dotnet", "HolaMundoApp.dll"]
