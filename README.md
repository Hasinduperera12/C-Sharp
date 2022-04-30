# C#
C Sharp Microsoft programming language (C# )

## Downlode dotnet 
https://dotnet.microsoft.com/en-us/download

## Check dotnet version
```
dotnet --version
```
## Project setup
```
dotnet new console
dotnet build --output ./build_output
dotnet ./build_output/my_app.dll
```
## Run C# programme
```
dotnet run
```
## Synopsis
```
dotnet [--version] [--info] [--list-runtimes] [--list-sdks]

dotnet -h|--help
```

## To run a command (requires SDK installation):
```
dotnet <COMMAND> [-d|--diagnostics] [-h|--help] [--verbosity <LEVEL>]
    [command-options] [arguments]
```

## To run an application:
```
dotnet [--additionalprobingpath <PATH>] [--additional-deps <PATH>]
    [--fx-version <VERSION>]  [--roll-forward <SETTING>]
    <PATH_TO_APPLICATION> [arguments]

dotnet exec [--additionalprobingpath] [--additional-deps <PATH>]
    [--fx-version <VERSION>]  [--roll-forward <SETTING>]
    <PATH_TO_APPLICATION> [arguments]
```

#### More dotnet command information https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet
