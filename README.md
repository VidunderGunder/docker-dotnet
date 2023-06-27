# Docker DotNet

Me getting familiar with Docker

## 🚀 Getting Started

Install [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)

```bash
dotnet run
```

Go to http://localhost:5124/deez

## 🐳 Docker

Install [Docker](https://www.docker.com/)

```bash
docker build -t dotnet .
```

```bash
docker run -p 5124:80 dotnet
```
