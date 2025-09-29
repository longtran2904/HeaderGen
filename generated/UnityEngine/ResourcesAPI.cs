#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public class ResourcesAPI
    {

        protected internal ResourcesAPI();

        public static ResourcesAPI overrideAPI { get; set; }

        protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance);
        protected internal virtual Shader FindShaderByName(string name);
        protected internal virtual Object Load(string path, Type systemTypeInstance);
        protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance);
        protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance);
        protected internal virtual void UnloadAsset(Object assetToUnload);
    }
}
