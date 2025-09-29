#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class ReloadAttribute : Attribute
    {

        public readonly Package package;
        public readonly string[] paths;

        public ReloadAttribute(string[] paths, Package package = Package.Root);
        public ReloadAttribute(string path, Package package = Package.Root);
        public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root);
        public enum Package
        {

            Builtin = 0,
            Root = 1
        }
    }
}
