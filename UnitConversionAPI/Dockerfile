#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["UnitConversionAPI/UnitConversionAPI.csproj", "UnitConversionAPI/"]
RUN dotnet restore "UnitConversionAPI/UnitConversionAPI.csproj"
COPY . .
WORKDIR "/src/UnitConversionAPI"
RUN dotnet build "UnitConversionAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UnitConversionAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UnitConversionAPI.dll"]