#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [StaticAccessor("SpriteUtilityBindings", StaticAccessorType.DoubleColon)]
    public sealed class InternalSpriteUtility
    {
        public InternalSpriteUtility();

        public static Rect[] GenerateAutomaticSpriteRectangles([NotNull("ArgumentNullException")] Texture2D texture, int minRectSize, int extrudeSize);
        public static Rect[] GenerateGridSpriteRectangles([NotNull("ArgumentNullException")] Texture2D texture, Vector2 offset, Vector2 size, Vector2 padding, bool keepEmptyRects);
        public static Rect[] GenerateGridSpriteRectangles(Texture2D texture, Vector2 offset, Vector2 size, Vector2 padding);
    }
}
