#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.IO;

namespace System.Resources
{
    public sealed class ResourceReader : IDisposable, IEnumerable, IResourceReader
    {

        public ResourceReader(string fileName);
        public ResourceReader(Stream stream);

        public void GetResourceData(string resourceName, out string resourceType, out byte[] resourceData);
        public void Close();
        public void Dispose();
        public IDictionaryEnumerator GetEnumerator();
    }
}
