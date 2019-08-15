FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["infrastructure/Rezare.TogsCop.Api/Rezare.TogsCop.Api.csproj", "infrastructure/Rezare.TogsCop.Api/"]
COPY ["core/Rezare.TogsCop.Api.Services/Rezare.TogsCop.Api.Services.csproj", "core/Rezare.TogsCop.Api.Services/"]
COPY ["core/Rezare.TogsCop.Integration.WorkFlowMax/Rezare.TogsCop.Integration.WorkFlowMax.csproj", "core/Rezare.TogsCop.Integration.WorkFlowMax/"]
COPY ["core/Rezare.TogsCop.Integration.Toggl/Rezare.TogsCop.Integration.Toggl.csproj", "core/Rezare.TogsCop.Integration.Toggl/"]
RUN dotnet restore "infrastructure/Rezare.TogsCop.Api/Rezare.TogsCop.Api.csproj"
COPY . .
WORKDIR "/src/infrastructure/Rezare.TogsCop.Api"
RUN dotnet build "Rezare.TogsCop.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Rezare.TogsCop.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Rezare.TogsCop.Api.dll"]