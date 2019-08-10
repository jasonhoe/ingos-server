FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Ingos.Api/Ingos.Api.csproj", "src/Ingos.Api/"]
COPY ["src/01_Infrastructure/Ingos.Api.Core/Ingos.Api.Core.csproj", "src/01_Infrastructure/Ingos.Api.Core/"]
COPY ["src/03_Application/Ingos.Application/Ingos.Application.csproj", "src/03_Application/Ingos.Application/"]
COPY ["src/02_Domain/Ingos.Domain/Ingos.Domain.csproj", "src/02_Domain/Ingos.Domain/"]
COPY ["src/02_Domain/Ingos.Aggregate/Ingos.Aggregate.csproj", "src/02_Domain/Ingos.Aggregate/"]
COPY ["src/02_Domain/Ingos.Repository/Ingos.Repository.csproj", "src/02_Domain/Ingos.Repository/"]
COPY ["src/01_Infrastructure/Ingos.EntityFrameworkCore/Ingos.EntityFrameworkCore.csproj", "src/01_Infrastructure/Ingos.EntityFrameworkCore/"]
RUN dotnet restore "src/Ingos.Api/Ingos.Api.csproj"
COPY . .
WORKDIR "/src/src/Ingos.Api"
RUN dotnet build "Ingos.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Ingos.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Ingos.Api.dll"]