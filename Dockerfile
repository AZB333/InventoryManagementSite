# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the .csproj first (better caching)
COPY InventoryManagement/*.csproj ./InventoryManagement/
RUN dotnet restore ./InventoryManagement/InventoryManagement.csproj

# Copy everything else
COPY . .
WORKDIR /src/InventoryManagement
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5257
ENTRYPOINT ["dotnet", "InventoryManagement.dll"]
