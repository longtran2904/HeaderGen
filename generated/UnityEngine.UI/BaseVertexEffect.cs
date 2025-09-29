#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.UI
{
    [Obsolete("Use BaseMeshEffect instead", True)]
    public abstract class BaseVertexEffect
    {

        protected BaseVertexEffect();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
        public abstract void ModifyVertices(List<UIVertex> vertices);
    }
}
