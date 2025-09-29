#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;

namespace UnityEditor.ShaderGraph.Drawing
{
    [AttributeUsage(AttributeTargets.Property)]
    public class InspectableAttribute : Attribute
    {
        public InspectableAttribute(string labelName, object defaultValue, string customStyleName = "");

        public string labelName { get; }
        public object defaultValue { get; }
        public string customStyleName { get; }
    }
}
