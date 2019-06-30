FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["NuRenVideoManagement/NuRenVideoManagement.csproj", "NuRenVideoManagement/"]
RUN dotnet restore "NuRenVideoManagement/NuRenVideoManagement.csproj"
COPY . .
WORKDIR "/src/NuRenVideoManagement"
RUN dotnet build "NuRenVideoManagement.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NuRenVideoManagement.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NuRenVideoManagement.dll"] 