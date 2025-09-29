#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Editor/Src/Animation/BlendTreePreviewUtility.h")]
    public class BlendTreePreviewUtility
    {
        public BlendTreePreviewUtility();

        public static void GetRootBlendTreeChildWeights([NotNull("NullExceptionObject")] Animator animator, int layerIndex, int stateHash, out float[] weightArray);
        public static void CalculateRootBlendTreeChildWeights([NotNull("NullExceptionObject")] Animator animator, int layerIndex, int stateHash, out float[] weightArray, float blendX, float blendY);
        public static void CalculateBlendTexture(Animator animator, int layerIndex, int stateHash, Texture2D blendTexture, Texture2D[] weightTextures, Rect rect);
        protected static void CalculateBlendTexture([NotNull("NullExceptionObject")] Animator animator, int layerIndex, int stateHash, Texture2D blendTexture, Texture2D[] weightTextures, float minX, float minY, float maxX, float maxY);
    }
}
