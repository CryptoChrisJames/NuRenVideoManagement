FROM microsoft/dotnet:2.1-sdk AS build
COPY . .
RUN dotnet restore "NuRenVideoManagement/NuRenVideoManagement.csproj"

WORKDIR src/NuRenVideoManagement
RUN dotnet build -c Debug
RUN dotnet publish -c Debug -o /app

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS final
COPY --from=build /app .

ENTRYPOINT ["dotnet", "NuRenVideoManagement.dll"]