# HeaderGen

HeaderGen is a small C# library for generating header-like files that list a type’s members and their signatures. It’s inspired by Visual Studio’s metadata view: given a compiled .NET assembly, it produces the same API surface you’d see when you press “Go To Definition” on a symbol without source code.

## Usage
`HeaderGen.cs` is the main library. It consists of a small `Utils` helper class, and the `HeaderGen` class contains all the necessary API with comments.
`DLLTest.cs` is just a collection of all the edge cases I found.
`Program.cs` is a small sample program that iterates through all the current domain's assemblies, plus the `DLLTest` assembly, and puts all the result files into the `generated` folder.
