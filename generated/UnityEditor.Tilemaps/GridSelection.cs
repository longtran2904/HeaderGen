#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.Tilemaps
{
    [HelpURL("https://docs.unity3d.com/Manual/TilemapPainting-SelectionTool.html#GridSelect")]
    [MovedFrom(True, "UnityEditor", "UnityEditor", null)]
    public class GridSelection : ScriptableObject
    {

        public static string kUpdateGridSelection;

        public GridSelection();

        public static bool active { get; }
        public static BoundsInt position { get; set; }
        public static GameObject target { get; }
        public static Grid grid { get; }

        public static event Action gridSelectionChanged;

        public static void Select(UnityEngine.Object target, BoundsInt bounds);
        public static void Clear();
    }
}
