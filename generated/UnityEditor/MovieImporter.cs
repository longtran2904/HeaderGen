#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("MovieImporter is removed. Use VideoClipImporter instead.", True)]
    public class MovieImporter
    {
        public MovieImporter();

        public float quality { get; set; }
        public bool linearTexture { get; set; }
        public float duration { get; }
    }
}
