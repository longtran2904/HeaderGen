#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public abstract class TMP_Asset : ScriptableObject
    {

        public int hashCode;
        public Material material;
        public int materialHashCode;

        protected TMP_Asset();

        public int instanceID { get; }
    }
}
