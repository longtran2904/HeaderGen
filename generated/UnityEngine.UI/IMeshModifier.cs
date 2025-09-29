#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    public interface IMeshModifier
    {

        [Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
        void ModifyMesh(Mesh mesh);
        void ModifyMesh(VertexHelper verts);
    }
}
