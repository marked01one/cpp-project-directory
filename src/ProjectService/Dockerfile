FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /app
EXPOSE 80

# Copy all .csproj files and restore as distinct layers
COPY project-directory.sln project-directory.sln
COPY src/ProjectService/ProjectService.csproj src/ProjectService/ProjectService.csproj

# Restore package dependencies
RUN dotnet restore project-directory.sln

# Copy the app folders over
COPY src/ProjectService src/ProjectService
WORKDIR /app/src/ProjectService
RUN dotnet publish -c Release -o /app/src/out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/src/out .
ENTRYPOINT [ "dotnet", "ProjectService.dll" ]