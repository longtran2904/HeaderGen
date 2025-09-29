#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public struct CameraProjectionCache
    {

        public CameraProjectionCache(Camera camera);

        public Vector2 WorldToScreenPoint(Vector3 worldPoint);
        public Vector2 WorldToGUIPoint(Vector3 worldPoint);
        public Vector2 GUIToScreenPoint(Vector2 guiPoint);
        public Vector2 ScreenToGUIPoint(Vector2 screenPoint);
    }
}
