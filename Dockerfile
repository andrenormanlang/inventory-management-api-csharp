# Use the official .NET SDK image for building the application (targeting .NET 8)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy the project file and restore any dependencies (via NuGet)
COPY *.csproj ./
RUN dotnet restore

# Copy the entire source code and build the project
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image for running the app (targeting .NET 8)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Production

# Expose the API port
EXPOSE 5000

# Run the app
ENTRYPOINT ["dotnet", "InventoryManagementSystem.dll"]
