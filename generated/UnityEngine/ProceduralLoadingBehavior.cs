#region UnityEngine.SubstanceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubstanceModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Built-in support for Substance Designer materials has been removed from Unity. To continue using Substance Designer materials, you will need to install Allegorithmic's external importer from the Asset Store.", True)]
    public enum ProceduralLoadingBehavior
    {
        DoNothing = 0,
        Generate = 1,
        BakeAndKeep = 2,
        BakeAndDiscard = 3,
        Cache = 4,
        DoNothingAndCache = 5
    }
}
