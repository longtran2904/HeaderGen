#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public static class EditorSnapSettings
    {

        public static bool gridSnapEnabled { get; set; }
        public static Vector3 move { get; set; }
        public static float rotate { get; set; }
        public static float scale { get; set; }

        public static event Action gridSnapEnabledChanged;

        public static void ResetSnapSettings();
    }
}
