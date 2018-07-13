# WsWawiOrderList - ASP.NET Core 2.0 Server

WAWI - Auftragsliste

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/WsWawiOrderList
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
