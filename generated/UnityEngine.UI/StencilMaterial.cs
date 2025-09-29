#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
    public static class StencilMaterial
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Material.Add instead.", True)]
        public static Material Add(Material baseMat, int stencilID);
        public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask);
        public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask);
        public static void Remove(Material customMat);
        public static void ClearAll();
    }
}
