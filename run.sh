#!/bin/bash
node ./generator/generateAll.js
rm .openapi-generator/FILES
rm linebotsdkx.sln
dotnet new sln
dotnet sln linebotsdkx.sln add src/**/*.csproj