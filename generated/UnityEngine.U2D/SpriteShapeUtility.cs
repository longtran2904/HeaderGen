#region UnityEngine.SpriteShapeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SpriteShapeModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
    [MovedFrom("UnityEngine.Experimental.U2D")]
    [NativeHeader("Modules/SpriteShape/Public/SpriteShapeUtility.h")]
    public class SpriteShapeUtility
    {
        public SpriteShapeUtility();

        [FreeFunction("SpriteShapeUtility::Generate")]
        [NativeThrows]
        public static int[] Generate(Mesh mesh, SpriteShapeParameters shapeParams, ShapeControlPoint[] points, SpriteShapeMetaData[] metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);
        [FreeFunction("SpriteShapeUtility::GenerateSpriteShape")]
        [NativeThrows]
        public static void GenerateSpriteShape(SpriteShapeRenderer renderer, SpriteShapeParameters shapeParams, ShapeControlPoint[] points, SpriteShapeMetaData[] metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);
    }
}
