#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.ShaderGraph.Serialization
{
    public class JsonObject : ISerializationCallbackReceiver
    {

        [SerializeField]
        protected int m_SGVersion;
        protected internal VersionChange onBeforeVersionChange;
        protected internal Action onAfterVersionChange;
        public static readonly string emptyObjectId;

        public JsonObject();

        public virtual int latestVersion { get; }
        public virtual int sgVersion { get; protected set; }
        public string objectId { get; }
        public bool objectIdIsEmpty { get; }

        public virtual T CastTo<T>() where T : JsonObject;
        public virtual string Serialize();
        public virtual void Deserailize(string typeInfo, string jsonData);
        public virtual void OnBeforeSerialize();
        public virtual void OnBeforeDeserialize();
        public virtual void OnAfterDeserialize();
        public virtual void OnAfterDeserialize(string json);
        public virtual void OnAfterMultiDeserialize(string json);
        protected internal delegate void VersionChange(int newVersion);
    }
}
