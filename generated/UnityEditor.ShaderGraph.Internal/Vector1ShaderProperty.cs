#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.ShaderGraph.Internal
{
    [BlackboardInputInfo(0, "Float")]
    [FormerName("UnityEditor.ShaderGraph.FloatShaderProperty")]
    [FormerName("UnityEditor.ShaderGraph.Vector1ShaderProperty")]
    public sealed class Vector1ShaderProperty : AbstractShaderProperty<float>
    {
        public override PropertyType propertyType { get; }
        public override float value { get; set; }
        public FloatType floatType { get; set; }
        public Vector2 rangeValues { get; set; }
        public EnumType enumType { get; set; }
        public Type cSharpEnumType { get; set; }
        public List<string> enumNames { get; set; }
        public List<int> enumValues { get; set; }
        public override int latestVersion { get; }

        public override void OnAfterDeserialize(string json);
    }
}
