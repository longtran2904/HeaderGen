#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;

namespace UnityEditor.Rendering
{
    public sealed class SerializedDataParameter
    {

        public SerializedProperty overrideState { get; }
        public SerializedProperty value { get; }
        public Attribute[] attributes { get; }
        public Type referenceType { get; }
        public string displayName { get; }

        public T GetAttribute<T>() where T : Attribute;
        public T GetObjectRef<T>();
    }
}
