#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;

namespace UnityEditor.Rendering
{
    public struct EditorPrefBoolFlags<T> : IEquatable<T>, IEquatable<EditorPrefBoolFlags<T>> where T : IConvertible, struct
    {

        public EditorPrefBoolFlags(string key);

        public T value { get; set; }
        public uint rawValue { get; set; }

        public bool Equals(T other);
        public bool Equals(EditorPrefBoolFlags<T> other);
        public bool HasFlag(T v);
        public void SetFlag(T f, bool v);

        public static EditorPrefBoolFlags<T> operator |(EditorPrefBoolFlags<T> l, T r);
        public static EditorPrefBoolFlags<T> operator &(EditorPrefBoolFlags<T> l, T r);
        public static EditorPrefBoolFlags<T> operator ^(EditorPrefBoolFlags<T> l, T r);

        public static explicit operator T(EditorPrefBoolFlags<T> v);
    }
}
