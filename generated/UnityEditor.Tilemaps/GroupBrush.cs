#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomGridBrush(True, False, False, "Group Brush")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/GroupBrush.html")]
    public class GroupBrush : GridBrush
    {
        public GroupBrush();

        public Vector3Int gap { get; set; }
        public Vector3Int limit { get; set; }

        public override void Pick(GridLayout grid, GameObject brushTarget, BoundsInt position, Vector3Int pickStart);
    }
}
