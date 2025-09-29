#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public static class GridPaletteUtility
    {

        public static GameObject CreateNewPaletteAtCurrentFolder(string name, GridLayout.CellLayout layout, GridPalette.CellSizing cellSizing, Vector3 cellSize, GridLayout.CellSwizzle swizzle);
        public static GameObject CreateNewPaletteAtCurrentFolder(string name, GridLayout.CellLayout layout, GridPalette.CellSizing cellSizing, Vector3 cellSize, GridLayout.CellSwizzle swizzle, TransparencySortMode sortMode, Vector3 sortAxis);
        public static GameObject CreateNewPalette(string folderPath, string name, GridLayout.CellLayout layout, GridPalette.CellSizing cellSizing, Vector3 cellSize, GridLayout.CellSwizzle swizzle);
        public static GameObject CreateNewPalette(string folderPath, string name, GridLayout.CellLayout layout, GridPalette.CellSizing cellSizing, Vector3 cellSize, GridLayout.CellSwizzle swizzle, TransparencySortMode sortMode, Vector3 sortAxis);
    }
}
