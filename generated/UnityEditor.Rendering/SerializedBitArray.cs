#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;

namespace UnityEditor.Rendering
{
    public abstract class SerializedBitArray : ISerializedBitArray
    {
        protected SerializedProperty m_SerializedProperty;
        protected static Action<SerializedProperty, int, bool> SetBitAtIndexForAllTargetsImmediate;
        protected static Func<SerializedProperty, int> HasMultipleDifferentValuesBitwise;

        public uint capacity { get; }

        protected SerializedProperty[] GetOrInitializeSerializedProperties();
        public bool HasBitMultipleDifferentValue(uint bitIndex);
        protected abstract bool HasBitMultipleDifferentValue_Internal(uint bitIndex);
        protected bool HasBitMultipleDifferentValue_For64Bits(string propertyPath, SerializedProperty serializedProperty, uint bitIndex);
        public bool GetBitAt(uint bitIndex);
        protected abstract bool GetBitAt_Internal(uint bitIndex);
        public void SetBitAt(uint bitIndex, bool value);
        protected abstract void SetBitAt_Internal(uint bitIndex, bool value);
        protected void ResyncSerialization();
        public void Update();
    }
}
