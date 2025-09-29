#region UnityEngine.ClusterInputModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClusterInputModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeConditional("ENABLE_CLUSTERINPUT")]
    [NativeHeader("Modules/ClusterInput/ClusterInput.h")]
    public class ClusterInput
    {

        public ClusterInput();

        public static float GetAxis(string name);
        public static bool GetButton(string name);
        [NativeConditional("ENABLE_CLUSTERINPUT", "Vector3f(0.0f, 0.0f, 0.0f)")]
        public static Vector3 GetTrackerPosition(string name);
        [NativeConditional("ENABLE_CLUSTERINPUT", "Quartenion::identity")]
        public static Quaternion GetTrackerRotation(string name);
        public static void SetAxis(string name, float value);
        public static void SetButton(string name, bool value);
        public static void SetTrackerPosition(string name, Vector3 value);
        public static void SetTrackerRotation(string name, Quaternion value);
        public static bool AddInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);
        public static bool EditInput(string name, string deviceName, string serverUrl, int index, ClusterInputType type);
        public static bool CheckConnectionToServer(string name);
    }
}
