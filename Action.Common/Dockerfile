FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Action.Common/Action.Common.csproj", "Action.Common/"]
RUN dotnet restore "Action.Common/Action.Common.csproj"
COPY . .
WORKDIR "/src/Action.Common"
RUN dotnet build "Action.Common.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Action.Common.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Action.Common.dll"]
