#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;

namespace UnityEditor.ShaderGraph.Drawing
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SGPropertyDrawerAttribute : Attribute
    {

        public SGPropertyDrawerAttribute(Type propertyType);

        public Type propertyType { get; }
    }
}
