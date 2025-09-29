#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V>
    {

        public SerializedDictionary();

        public override K SerializeKey(K key);
        public override V SerializeValue(V val);
        public override K DeserializeKey(K key);
        public override V DeserializeValue(V val);
    }
}
