FROM microsoft/dotnet:1.0.3-sdk-projectjson

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

WORKDIR /app/WsWawiOrderList
COPY . /app/WsWawiOrderList

EXPOSE 5000/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]
