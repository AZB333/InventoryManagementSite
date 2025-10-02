# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy project files and restore
COPY *.sln .
COPY InventoryManagement/*.csproj ./InventoryManagement/
RUN dotnet restore ./InventoryManagement/InventoryManagement.csproj

# Copy everything else and publish
COPY . .
WORKDIR /src/InventoryManagement
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "InventoryManagement.dll"]
