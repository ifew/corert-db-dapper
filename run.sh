#!/bin/bash
RUNTIME=$1

echo $1
dotnet restore
dotnet publish -r $RUNTIME -c release
bin/release/netcoreapp2.2/$RUNTIME/publish/corert-db-dapper