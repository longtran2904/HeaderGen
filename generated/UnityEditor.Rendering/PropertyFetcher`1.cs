#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Linq.Expressions;

namespace UnityEditor.Rendering
{
    public sealed class PropertyFetcher<T> : IDisposable
    {

        public readonly SerializedObject obj;

        public PropertyFetcher(SerializedObject obj);

        public SerializedProperty Find(string str);
        public SerializedProperty Find<TValue>(Expression<Func<T, TValue>> expr);
        public void Dispose();
    }
}
