FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet build "NuRenVideoManagement.csproj" -c Release -o /app
RUN dotnet publish "NuRenVideoManagement.csproj" -c Release -o /app
WORKDIR /app
COPY --from=base /app .
ENTRYPOINT ["dotnet", "NuRenVideoManagement.dll"]