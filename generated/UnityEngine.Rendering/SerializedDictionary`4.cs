#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver
    {

        protected SerializedDictionary();

        public abstract SK SerializeKey(K key);
        public abstract SV SerializeValue(V value);
        public abstract K DeserializeKey(SK serializedKey);
        public abstract V DeserializeValue(SV serializedValue);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
