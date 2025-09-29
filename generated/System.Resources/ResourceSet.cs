#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.IO;

namespace System.Resources
{
    public class ResourceSet : IDisposable, IEnumerable
    {

        protected IResourceReader Reader;

        protected ResourceSet();
        public ResourceSet(string fileName);
        public ResourceSet(Stream stream);
        public ResourceSet(IResourceReader reader);

        public virtual void Close();
        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public virtual Type GetDefaultReader();
        public virtual Type GetDefaultWriter();
        public virtual IDictionaryEnumerator GetEnumerator();
        public virtual string GetString(string name);
        public virtual string GetString(string name, bool ignoreCase);
        public virtual object GetObject(string name);
        public virtual object GetObject(string name, bool ignoreCase);
        protected virtual void ReadResources();
    }
}
