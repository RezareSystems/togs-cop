FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY */**.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish infrastructure/Rezare.TogsCop.Api/Rezare.TogsCop.Api.csproj -c Release -o ./out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "Rezare.TogsCop.Api.dll"]