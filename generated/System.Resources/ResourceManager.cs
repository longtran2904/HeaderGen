#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.IO;
using System.Reflection;

namespace System.Resources
{
    public class ResourceManager
    {
        protected string BaseNameField;
        protected Assembly MainAssembly;
        public static readonly int MagicNumber;
        public static readonly int HeaderVersionNumber;

        protected ResourceManager();
        public ResourceManager(string baseName, Assembly assembly);
        public ResourceManager(string baseName, Assembly assembly, Type usingResourceSet);
        public ResourceManager(Type resourceSource);

        public virtual string BaseName { get; }
        public virtual bool IgnoreCase { get; set; }
        public virtual Type ResourceSetType { get; }
        protected UltimateResourceFallbackLocation FallbackLocation { get; set; }

        public virtual void ReleaseAllResources();
        public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet);
        protected virtual string GetResourceFileName(CultureInfo culture);
        public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents);
        protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents);
        protected static Version GetSatelliteContractVersion(Assembly a);
        protected static CultureInfo GetNeutralResourcesLanguage(Assembly a);
        public virtual string GetString(string name);
        public virtual string GetString(string name, CultureInfo culture);
        public virtual object GetObject(string name);
        public virtual object GetObject(string name, CultureInfo culture);
        public UnmanagedMemoryStream GetStream(string name);
        public UnmanagedMemoryStream GetStream(string name, CultureInfo culture);
    }
}
