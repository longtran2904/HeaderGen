#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
    public static class CustomRenderTextureManager
    {

        public static event Action<CustomRenderTexture> textureLoaded;
        public static event Action<CustomRenderTexture> textureUnloaded;
        public static event Action<CustomRenderTexture, int> updateTriggered;
        public static event Action<CustomRenderTexture> initializeTriggered;

        [FreeFunction(Name = "CustomRenderTextureManagerScripting::GetAllCustomRenderTextures", HasExplicitThis = False)]
        public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures);
    }
}
