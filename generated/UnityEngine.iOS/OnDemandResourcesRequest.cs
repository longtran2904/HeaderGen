#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.iOS
{
    [NativeHeader("Runtime/Export/iOS/OnDemandResources.h")]
    [UsedByNativeCode]
    public sealed class OnDemandResourcesRequest : AsyncOperation, IDisposable
    {

        ~OnDemandResourcesRequest();

        public string error { get; }
        public float loadingPriority { get; set; }

        public string GetResourcePath(string resourceName);
        public void Dispose();
    }
}
