#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
    [NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
    [NativeHeader("Runtime/Graphics/Mesh/SpriteRenderer.h")]
    public static class SpriteRendererDataAccessExtensions
    {
        public static void DeactivateDeformableBuffer([NotNull("ArgumentNullException")] this SpriteRenderer renderer);
    }
}
