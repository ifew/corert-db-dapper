# Example C# .NET Core Runtime (CoreRT) with connect MySQL via Dapper Library

## WARNING

This example result "not supported on this platform", and I will wait for support

```bash
Unhandled Exception: System.PlatformNotSupportedException: Dynamic code generation is not supported on this platform.
   at System.Reflection.Emit.ReflectionEmitThrower.ThrowPlatformNotSupportedException() + 0x38
   at Dapper.SqlMapper.GetTypeDeserializerImpl(Type, IDataReader, Int32, Int32, Boolean) + 0xb5
   at Dapper.SqlMapper.TypeDeserializerCache.GetReader(IDataReader, Int32, Int32, Boolean) + 0x154
   at Dapper.SqlMapper.TypeDeserializerCache.GetReader(Type, IDataReader, Int32, Int32, Boolean) + 0x16c
   at Dapper.SqlMapper.GetDeserializer(Type, IDataReader, Int32, Int32, Boolean) + 0x14f
   at Dapper.SqlMapper.<QueryImpl>d__138`1.MoveNext() + 0x263
   at System.Collections.Generic.List`1..ctor(IEnumerable`1) + 0x10c
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1) + 0x43
   at Dapper.SqlMapper.Query[T](IDbConnection, String, Object, IDbTransaction, Boolean, Nullable`1, Nullable`1) + 0x1c6
   at Member.Program.Main(String[]) + 0x13f
   at corert-db-dapper!<BaseAddress>+0xaaf183

```

## Preparing

1. Import Database from database.sql
2. Edit config database "configDB" in Program.cs

## NOTE

I think it's bug from Dapper or System.Data.SqlClient, Because I can use only runtime netcoreapp3.0 on Linux and MySqlConnector library. can't on MacOS, netcoreapp2.2 and official MySQL Connector 


## Command for run
```bash
$ sh run.sh [Runtime]
```

Example for MacOS
```bash
$ sh run.sh osx-64
```

Example for Linux
```bash
$ sh run.sh linux-64
```

Example for Windows
```bash
$ sh run.sh win-64
```

## System Require for Linux

- `sudo apt-get install clang-3.9`
- `sudo apt-get install libunwind-dev`
- `sudo apt-get install libcurl4-openssl-dev`
- `sudo apt-get install zlib1g-dev`
- `sudo apt-get install libkrb5-dev`
- `export CppCompilerAndLinker=clang-3.9`