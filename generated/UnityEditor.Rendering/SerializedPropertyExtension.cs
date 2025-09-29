#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;

namespace UnityEditor.Rendering
{
    public static class SerializedPropertyExtension
    {
        public static bool IsTargetAlive(this SerializedProperty property);
        public static T GetEnumValue<T>(this SerializedProperty property) where T : Enum;
        public static string GetEnumName<T>(this SerializedProperty property) where T : Enum;
        public static void SetEnumValue<T>(this SerializedProperty property, T value) where T : Enum;
        public static T GetInline<T>(this SerializedProperty serializedProperty) where T : struct;
        public static void SetInline<T>(this SerializedProperty serializedProperty, T value) where T : struct;
    }
}
