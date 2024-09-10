FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

MAINTAINER Vlad Fedorovich <sskef@outlook.com>

ENV TZ=Europe/Moscow

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["AchieveClubFrontend.csproj", "."]
RUN dotnet restore "./AchieveClubFrontend.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AchieveClubFrontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AchieveClubFrontend.csproj" -c Release -o /app/publish

FROM nginx:stable-alpine AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY nginx.conf /etc/nginx/nginx.conf

RUN chown -R nginx:nginx /app

CMD ["nginx", "-g", "daemon off;"]
