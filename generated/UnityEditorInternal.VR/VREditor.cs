#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor;
using UnityEngine.Bindings;

namespace UnityEditorInternal.VR
{
    [NativeHeader("Modules/VREditor/VREditor.bindings.h")]
    public sealed class VREditor
    {
        public VREditor();

        public static bool GetVREnabledOnTargetGroup(BuildTargetGroup targetGroup);
        public static void SetVREnabledOnTargetGroup(BuildTargetGroup targetGroup, bool value);
        [NativeMethod("SetVREnabledDevicesOnTargetGroup")]
        public static void NativeSetVREnabledDevicesOnTargetGroup(BuildTargetGroup targetGroup, string[] devices);
        public static void SetVREnabledDevicesOnTargetGroup(BuildTargetGroup targetGroup, string[] devices);
    }
}
