#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public class MeshPreview : IDisposable
    {
        public MeshPreview(Mesh target);

        public Mesh mesh { get; set; }

        public void Dispose();
        public Texture2D RenderStaticPreview(int width, int height);
        public void OnPreviewGUI(Rect rect, GUIStyle background);
        public void OnPreviewSettings();
        public static string GetInfoString(Mesh mesh);
    }
}
