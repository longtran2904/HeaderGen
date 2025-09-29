#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public sealed class ProceduralPropertyDescription
    {

        public string name;
        public string label;
        public string group;
        public ProceduralPropertyType type;
        public bool hasRange;
        public float minimum;
        public float maximum;
        public float step;
        public string[] enumOptions;
        public string[] componentLabels;

        public ProceduralPropertyDescription();
    }
}
