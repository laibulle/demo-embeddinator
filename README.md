#

## Project setup 

Follow this guide to install Embeddinator-4000

https://docs.microsoft.com/en-us/xamarin/tools/dotnet-embedding/get-started/install/install

```bash
~/.nuget/packages/embeddinator-4000/0.4.0/tools/objcgen bin/Debug/netstandard2.1/demo-embeddinator.dll --target=framework --platform=iOS --outdir=output -c --debug
```

- add `$(PROJECT_DIR)/../demo-embeddinator/output` in  __Framework Search Paths__ in __Build settings__
- drag `demo-embeddinator/output/demo-embeddinator.framweork` in project
- set to `Embed and sign` in __Framework, Libraries, and Embedded Content__

__Limitations__

https://docs.microsoft.com/en-us/xamarin/tools/dotnet-embedding/limitations
