#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Sprites
{
    public interface ISpritePhysicsOutlineDataProvider
    {

        List<Vector2[]> GetOutlines(GUID guid);
        void SetOutlines(GUID guid, List<Vector2[]> data);
        float GetTessellationDetail(GUID guid);
        void SetTessellationDetail(GUID guid, float value);
    }
}
