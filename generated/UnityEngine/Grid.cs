#region UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GridModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
    [NativeType(Header = "Modules/Grid/Public/Grid.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class Grid : GridLayout
    {
        public Grid();

        public Vector3 cellSize { get; set; }
        public Vector3 cellGap { get; set; }
        public CellLayout cellLayout { get; set; }
        public CellSwizzle cellSwizzle { get; set; }

        public Vector3 GetCellCenterLocal(Vector3Int position);
        public Vector3 GetCellCenterWorld(Vector3Int position);
        [FreeFunction("GridBindings::CellSwizzle")]
        public static Vector3 Swizzle(CellSwizzle swizzle, Vector3 position);
        [FreeFunction("GridBindings::InverseCellSwizzle")]
        public static Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position);
    }
}
