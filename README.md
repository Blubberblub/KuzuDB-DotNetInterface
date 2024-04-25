# KuzuDB-net
.Net DLL Wrapper for the KuzuDB .lib

This project uses SWIG (www.swig.org) to automatically generate C# wrapper code to operate over the Kuzu database .lib file.

# Folders structure

- KuzuFiles
    - Kuzu files (.h, .dll, .lib, etc.) should be added here (see: How to make this work)
    - the generated_classes subfolder will hold the generated C# wrapper classes

- SWIG-Input File
    - Contains the SWIG interface file for SWIG to generate the C# wrapper files and kuzu_wrap.cpp

- wrapperlib
    - Will contain the files to build kuzunet.dll

- KuzuDB-Net
    - Contains a C# project to create the DLL
    - Contains a VB.Net project to test the DLL

# Tested setup

The code in this repo was tested with the following setup:
- Windows 11
- Visual Studio Community 22 with "Desktop Development with C++" package and .NET Framework 4.8
- Kuzu v.0.3.2
- SWIG version 4.2.1
- cmake 3.29.2
- ninja 1.12.0

# How to make this work

## 1. Get newest version of Kuzu C/C++ libs (see last tested versions above)
- Download the c/c++ windows lib from https://github.com/kuzudb/kuzu/releases/
- put the files(.h, .dll, .lib, etc.) in KuzuFiles folder

## 2. Use SWIG to generate class files and wrapper
- Install swig (see last tested versions above).
- Generate c# classes and kuzu_wrap.cpp by using the provided SWIG interface file and the following command

```cmd
swig -c++ -csharp -IKuzuFiles/ -outdir "KuzuFiles/generated_classes/" -o wrapperlib/kuzu_wrap.cpp SWIG-InputFile/kuzu.i
```

## 2. Build kuzunet.dll
- check that you have Visual Studio with C++ dev package, as well as cmake and kuzu as described above
- build kuzunet.dll using cmake and ninja in the wrapperlib folder with following commands:

```cmd
cd wrapperlib
mkdir build
cd build
cmake -G Ninja .. -DCMAKE_BUILD_TYPE=Release
ninja
```

## 3. Test in Demo Project
In the KuzuDB-net folder is a KuzuDB-TestAndExplorer.sln file. It includes two things:
- The C# project to build the datbase .dll
- A small VB project to test the outcome

For testing you need to:
- open the sln file
- add all the files from KuzuFiles/generated_classes to the projects WrapperFiles folder
- add kuzu_shared.dll (from KuzuFiles) and kuzunet.dll (from wrapperlib/build) to the KuzuNet-DB project
- make sure the KuzuDB-TestAndExplorer project has the KuzuDB-Net project as reference (if not add it)
- build the solution

# General Usage (VB.Net)

Put the following files in your .exe directory:
kuzu_shared.dll
KuzuDB.dll
kuzunet.dll
libkuzu.lib

```VB
Imports kuzunet
```