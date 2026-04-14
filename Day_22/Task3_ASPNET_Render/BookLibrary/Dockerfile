FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файл проекта и восстанавливаем зависимости
COPY BookLibrary.csproj .
RUN dotnet restore

# Копируем весь код и собираем приложение
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Образ для запуска
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Переменные окружения для Render
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "BookLibrary.dll"]