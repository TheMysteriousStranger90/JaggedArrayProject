FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["JaggedArrayProject/JaggedArrayProject.csproj", "JaggedArrayProject/"]
RUN dotnet restore "JaggedArrayProject/JaggedArrayProject.csproj"
COPY . .
WORKDIR "/src/JaggedArrayProject"
RUN dotnet build "JaggedArrayProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JaggedArrayProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JaggedArrayProject.dll"]
