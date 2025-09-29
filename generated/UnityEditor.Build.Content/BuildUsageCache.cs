#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/BuildUsageCache.h")]
    [UsedByNativeCode]
    public class BuildUsageCache : IDisposable
    {
        public BuildUsageCache();

        ~BuildUsageCache();

        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
