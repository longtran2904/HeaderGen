#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Internal;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [Obsolete("GUIElement has been removed.", True)]
    public sealed class GUIElement
    {

        public GUIElement();

        [Obsolete("GUIElement has been removed.", True)]
        public bool HitTest(Vector3 screenPosition);
        [Obsolete("GUIElement has been removed.", True)]
        public bool HitTest(Vector3 screenPosition, [DefaultValue("null")] Camera camera);
        [Obsolete("GUIElement has been removed.", True)]
        public Rect GetScreenRect([DefaultValue("null")] Camera camera);
        [Obsolete("GUIElement has been removed.", True)]
        public Rect GetScreenRect();
    }
}
