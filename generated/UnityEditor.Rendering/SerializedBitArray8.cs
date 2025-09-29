#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public sealed class SerializedBitArray8 : SerializedBitArray
    {
        public SerializedBitArray8(SerializedProperty serializedProperty);

        protected override bool HasBitMultipleDifferentValue_Internal(uint bitIndex);
        protected override bool GetBitAt_Internal(uint bitIndex);
        protected override void SetBitAt_Internal(uint bitIndex, bool value);
    }
}
