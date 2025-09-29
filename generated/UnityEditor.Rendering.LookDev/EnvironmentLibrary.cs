#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering.LookDev
{
    [CoreRPHelpURL("Environment-Library", "com.unity.render-pipelines.core")]
    [DefaultMember("Item")]
    public class EnvironmentLibrary : ScriptableObject
    {

        public EnvironmentLibrary();

        public Environment this[int index] { get; }
        public int Count { get; }

        public Environment Add();
        public void Remove(int index);
        public Environment Duplicate(int fromIndex);
        public int IndexOf(Environment environment);
    }
}
