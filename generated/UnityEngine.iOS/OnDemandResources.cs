#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.iOS
{
    [NativeHeader("Runtime/Export/iOS/OnDemandResources.h")]
    public static class OnDemandResources
    {

        public static bool enabled { get; }

        public static OnDemandResourcesRequest PreloadAsync(string[] tags);
    }
}
