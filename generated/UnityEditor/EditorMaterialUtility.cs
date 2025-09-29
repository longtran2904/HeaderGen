#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/Graphics/EditorMaterialUtility.bindings.h")]
    [NativeHeader("Runtime/Shaders/MaterialIsBackground.h")]
    [NativeHeader("Runtime/Shaders/Material.h")]
    [StaticAccessor("Material", StaticAccessorType.DoubleColon)]
    public sealed class EditorMaterialUtility
    {
        public EditorMaterialUtility();

        [FreeFunction("EditorMaterialUtilityBindings::ResetDefaultTextures")]
        public static void ResetDefaultTextures([NotNull("ArgumentNullException")] Material material, bool overrideSetTextures);
        [FreeFunction]
        public static bool IsBackgroundMaterial([NotNull("ArgumentNullException")] Material material);
        [FreeFunction("EditorMaterialUtilityBindings::SetShaderDefaults")]
        public static void SetShaderDefaults([NotNull("ArgumentNullException")] Shader shader, string[] name, Texture[] textures);
        [FreeFunction("EditorMaterialUtilityBindings::SetShaderNonModifiableDefaults")]
        public static void SetShaderNonModifiableDefaults([NotNull("ArgumentNullException")] Shader shader, string[] name, Texture[] textures);
    }
}
