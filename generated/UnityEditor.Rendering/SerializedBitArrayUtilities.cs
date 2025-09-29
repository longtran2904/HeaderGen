#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public static class SerializedBitArrayUtilities
    {

        public static SerializedBitArray8 ToSerializeBitArray8(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray8(this SerializedProperty serializedProperty, out SerializedBitArray8 serializedBitArray);
        public static SerializedBitArray16 ToSerializeBitArray16(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray16(this SerializedProperty serializedProperty, out SerializedBitArray16 serializedBitArray);
        public static SerializedBitArray32 ToSerializeBitArray32(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray32(this SerializedProperty serializedProperty, out SerializedBitArray32 serializedBitArray);
        public static SerializedBitArray64 ToSerializeBitArray64(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray64(this SerializedProperty serializedProperty, out SerializedBitArray64 serializedBitArray);
        public static SerializedBitArray128 ToSerializeBitArray128(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray128(this SerializedProperty serializedProperty, out SerializedBitArray128 serializedBitArray);
        public static SerializedBitArray256 ToSerializeBitArray256(this SerializedProperty serializedProperty);
        public static bool TryGetSerializeBitArray256(this SerializedProperty serializedProperty, out SerializedBitArray256 serializedBitArray);
    }
}
