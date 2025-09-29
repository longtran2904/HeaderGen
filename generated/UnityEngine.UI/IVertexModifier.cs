#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.UI
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use IMeshModifier instead", True)]
    public interface IVertexModifier
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
        void ModifyVertices(List<UIVertex> verts);
    }
}
