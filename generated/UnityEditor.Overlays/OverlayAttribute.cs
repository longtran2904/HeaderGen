#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Overlays
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class OverlayAttribute : Attribute
    {

        public OverlayAttribute(Type editorWindowType, string id, string displayName, string ussName, bool defaultDisplay = False);
        public OverlayAttribute(Type editorWindowType, string id, string displayName, bool defaultLayout = False);
        public OverlayAttribute(Type editorWindowType, string displayName, bool defaultLayout = False);

        public Type editorWindowType { get; }
        public string id { get; }
        public string displayName { get; }
        public string ussName { get; }
        public bool defaultDisplay { get; }
    }
}
