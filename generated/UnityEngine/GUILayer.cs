#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [Obsolete("GUILayer has been removed.", True)]
    public sealed class GUILayer
    {

        public GUILayer();

        [Obsolete("GUILayer has been removed.", True)]
        public GUIElement HitTest(Vector3 screenPosition);
    }
}
