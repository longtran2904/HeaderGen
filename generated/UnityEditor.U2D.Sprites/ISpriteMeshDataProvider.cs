#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.U2D.Sprites
{
    public interface ISpriteMeshDataProvider
    {
        Vertex2DMetaData[] GetVertices(GUID guid);
        void SetVertices(GUID guid, Vertex2DMetaData[] vertices);
        int[] GetIndices(GUID guid);
        void SetIndices(GUID guid, int[] indices);
        Vector2Int[] GetEdges(GUID guid);
        void SetEdges(GUID guid, Vector2Int[] edges);
    }
}
