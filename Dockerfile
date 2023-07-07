FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet clean
RUN dotnet restore

# Copy everything else and build
COPY . ./

# In development, you want to run `dotnet watch run`
ENTRYPOINT ["dotnet", "watch", "run", "--no-restore"]

# Expose the port that your app runs on
EXPOSE 5124
