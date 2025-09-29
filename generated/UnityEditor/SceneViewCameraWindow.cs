#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public class SceneViewCameraWindow : PopupWindowContent
    {
        public SceneViewCameraWindow(SceneView sceneView);

        public static event Action<SceneView> additionalSettingsGui;

        public override Vector2 GetWindowSize();
        public override void OnGUI(Rect rect);
    }
}
