#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = False, Inherited = False)]
    public sealed class LibraryImportAttribute : Attribute
    {

        public LibraryImportAttribute(string libraryName);

        public string LibraryName { get; }
        public string EntryPoint { get; set; }
        public StringMarshalling StringMarshalling { get; set; }
        public Type StringMarshallingCustomType { get; set; }
        public bool SetLastError { get; set; }
    }
}
