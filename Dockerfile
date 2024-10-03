# Use the official .NET SDK image to build the application (targeting .NET 8)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the project file (adjust path to InventoryManagementSystem folder)
COPY InventoryManagementSystem/*.csproj ./InventoryManagementSystem/

# Restore any dependencies
RUN dotnet restore InventoryManagementSystem/InventoryManagementSystem.csproj

# Copy the entire source code to the container
COPY . .

# Build the project
RUN dotnet publish InventoryManagementSystem/InventoryManagementSystem.csproj -c Release -o out

# Use the official .NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set environment variables if needed
ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Production

# Expose the API port
EXPOSE 5000

# Run the app
ENTRYPOINT ["dotnet", "InventoryManagementSystem.dll"]
