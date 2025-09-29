#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public static class Snapping
    {

        public static float Snap(float val, float snap);
        public static Vector2 Snap(Vector2 val, Vector2 snap);
        public static Vector3 Snap(Vector3 val, Vector3 snap, SnapAxis axis = SnapAxis.All);
    }
}
