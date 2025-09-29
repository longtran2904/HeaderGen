#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public enum ProceduralPropertyType
    {

        Boolean = 0,
        Float = 1,
        Vector2 = 2,
        Vector3 = 3,
        Vector4 = 4,
        Color3 = 5,
        Color4 = 6,
        Enum = 7,
        Texture = 8,
        String = 9
    }
}
