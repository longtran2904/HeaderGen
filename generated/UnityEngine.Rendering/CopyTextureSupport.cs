#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum CopyTextureSupport
    {

        None = 0,
        Basic = 1,
        Copy3D = 2,
        DifferentTypes = 4,
        TextureToRT = 8,
        RTToTexture = 16
    }
}
