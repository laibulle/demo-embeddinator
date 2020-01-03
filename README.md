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

You have to create a bridge to swift code

https://developer.apple.com/documentation/swift/imported_c_and_objective-c_apis/importing_objective-c_into_swift

```
//
//  SampleEmbeddinatorIOS-Bridging-Header.h
//  SampleEmbeddinatorIOS
//
//  Created by Guillaume Bailleul on 03/01/2020.
//  Copyright © 2020 Guillaume Bailleul. All rights reserved.
//

#ifndef SampleEmbeddinatorIOS_Bridging_Header_h
#define SampleEmbeddinatorIOS_Bridging_Header_h



#endif /* SampleEmbeddinatorIOS_Bridging_Header_h */
```

__Limitations__

https://docs.microsoft.com/en-us/xamarin/tools/dotnet-embedding/limitations
