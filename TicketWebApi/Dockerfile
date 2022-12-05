#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TicketWebApi/TicketWebApi.csproj", "TicketWebApi/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["IoC/IoC.csproj", "IoC/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Shared/Shared.csproj", "Shared/"]
COPY ["Persistence/Persistence.csproj", "Persistence/"]
COPY ["Presenters/Presenters.csproj", "Presenters/"]
RUN dotnet restore "TicketWebApi/TicketWebApi.csproj"
COPY . .
WORKDIR "/src/TicketWebApi"
RUN dotnet build "TicketWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TicketWebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TicketWebApi.dll"]