#region UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GridModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
    [NativeType(Header = "Modules/Grid/Public/Grid.h")]
    [RequireComponent(typeof(Transform))]
    public class GridLayout : Behaviour
    {

        public GridLayout();

        public Vector3 cellSize { get; }
        public Vector3 cellGap { get; }
        public CellLayout cellLayout { get; }
        public CellSwizzle cellSwizzle { get; }

        [FreeFunction("GridLayoutBindings::GetBoundsLocal", HasExplicitThis = True)]
        public Bounds GetBoundsLocal(Vector3Int cellPosition);
        public Bounds GetBoundsLocal(Vector3 origin, Vector3 size);
        [FreeFunction("GridLayoutBindings::CellToLocal", HasExplicitThis = True)]
        public Vector3 CellToLocal(Vector3Int cellPosition);
        [FreeFunction("GridLayoutBindings::LocalToCell", HasExplicitThis = True)]
        public Vector3Int LocalToCell(Vector3 localPosition);
        [FreeFunction("GridLayoutBindings::CellToLocalInterpolated", HasExplicitThis = True)]
        public Vector3 CellToLocalInterpolated(Vector3 cellPosition);
        [FreeFunction("GridLayoutBindings::LocalToCellInterpolated", HasExplicitThis = True)]
        public Vector3 LocalToCellInterpolated(Vector3 localPosition);
        [FreeFunction("GridLayoutBindings::CellToWorld", HasExplicitThis = True)]
        public Vector3 CellToWorld(Vector3Int cellPosition);
        [FreeFunction("GridLayoutBindings::WorldToCell", HasExplicitThis = True)]
        public Vector3Int WorldToCell(Vector3 worldPosition);
        [FreeFunction("GridLayoutBindings::LocalToWorld", HasExplicitThis = True)]
        public Vector3 LocalToWorld(Vector3 localPosition);
        [FreeFunction("GridLayoutBindings::WorldToLocal", HasExplicitThis = True)]
        public Vector3 WorldToLocal(Vector3 worldPosition);
        [FreeFunction("GridLayoutBindings::GetLayoutCellCenter", HasExplicitThis = True)]
        public Vector3 GetLayoutCellCenter();
        public enum CellLayout
        {

            Rectangle = 0,
            Hexagon = 1,
            Isometric = 2,
            IsometricZAsY = 3
        }
        public enum CellSwizzle
        {

            XYZ = 0,
            XZY = 1,
            YXZ = 2,
            YZX = 3,
            ZXY = 4,
            ZYX = 5
        }
    }
}
