#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public class BasePrefabBrush : GridBrush
    {

        public Vector3 m_Anchor;

        public BasePrefabBrush();

        protected List<GameObject> GetObjectsInCell(GridLayout grid, Transform parent, Vector3Int position);
        protected void InstantiatePrefabInCell(GridLayout grid, GameObject brushTarget, Vector3Int position, GameObject prefab, Quaternion rotation = null);
    }
}
