#region UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/UI/Canvas.h")]
    [StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
    public static class UISystemProfilerApi
    {

        public static void BeginSample(SampleType type);
        public static void EndSample(SampleType type);
        public static void AddMarker(string name, Object obj);
        public enum SampleType
        {

            Layout = 0,
            Render = 1
        }
    }
}
