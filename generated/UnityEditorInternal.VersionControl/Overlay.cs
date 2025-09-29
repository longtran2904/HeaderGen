#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.VersionControl;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{
    public class Overlay
    {

        public Overlay();

        public static Rect GetOverlayRect(Rect itemRect);
        public static void DrawOverlay(Asset asset, Asset metaAsset, Rect itemRect);
        public static void DrawOverlay(Asset asset, Rect itemRect);
    }
}
