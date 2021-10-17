FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["workWithDataBase.csproj", "./"]
RUN dotnet restore "workWithDataBase.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "workWithDataBase.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "workWithDataBase.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "workWithDataBase.dll"]
