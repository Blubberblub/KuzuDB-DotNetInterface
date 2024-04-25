# KuzuDB-net
.Net DLL Wrapper for the KuzuDB .lib

This project uses SWIG (www.swig.org) to automatically generate C# wrapper code to operate over the Kuzu database .lib file.

# Tested on
- Windows 11
- Visual Studio Community 22 with "Desktop Development with C++" package
- Kuzu v.0.3.2
- SWIG version 4.2.1
- cmake 3.29.2
- ninja 1.12.0

# How this works

1. Get newest version of Kuzu C/C++ libs (see last tested versions above)
- Download the c/c++ windows lib from https://github.com/kuzudb/kuzu/releases/
- put the files(.h, .dll, .lib, etc.) in KuzuFiles folder

2. Use SWIG for generating class files and wrapper
- Install swig (see last tested versions above).
- Generate c# classes and kuzu_wrap.cpp by using the provided SWIG interface file and the following command

```cmd
swig -c++ -csharp -IKuzuFiles/ -outdir "KuzuFiles/generated_classes/" -o wrapperlib/kuzu_wrap.cpp SWIG-InputFile/kuzu.i
```

2. Build kuzunet.dll
- check that you have Visual Studio with C++ dev package, cmake and kuzu as described above
- build kuzunet.dll using cmake and ninja in the wrapperlib folder

```cmd
cd wrapperlib
mkdir build
cd build
cmake -G Ninja .. -DCMAKE_BUILD_TYPE=Release
ninja
```

3. Use files in project
TODO: add files and their origin locations that have to be added to project


# Folders Are
- KuzuDB-Net
    - Contains a C# project to create the DLL
        - Wrapper files output from SWIG are included in this project, to generate the DLL.
    - Contains a VB.Net project to test the DLL

- KuzuFiles
    - Contains copies of the Kuzu files (.h, .hpp, .lib)

- SWIG-Input File
    - Contains the .i (input file) used in the SWIG command to generate the C# wrapper files

# Precompiled DLLs Are In:
- DotNetInterface/KuzuDB-net/KuzuDB-Net/bin/Debug/

# Test Program is in
- KuzuDB-DotNetInterface/KuzuDB-net/KuzuDB-TestAndExplore

# Collaboration Welcome
Want to chip in? Sing out to contribute to this project.

# Usage (VB.Net)
Imports kuzunet

Put the following files in your .exe directory:
kuzu_shared.dll
KuzuDB.dll
kuzunet.dll
libkuzu.lib
