#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
    public static class Lightmapping
    {

        [RequiredByNativeCode]
        public static void SetDelegate(RequestLightsDelegate del);
        [RequiredByNativeCode]
        public static RequestLightsDelegate GetDelegate();
        [RequiredByNativeCode]
        public static void ResetDelegate();
        public delegate void RequestLightsDelegate(Light[] requests, NativeArray<LightDataGI> lightsOutput);
    }
}
