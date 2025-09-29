#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;

namespace UnityEditor.ShaderGraph.Internal
{
    public abstract class AbstractShaderProperty : ShaderInput
    {
        protected AbstractShaderProperty();

        public abstract PropertyType propertyType { get; }
        [Obsolete("AbstractShaderProperty.gpuInstanced is no longer used")]
        public bool gpuInstanced { get; set; }
        public ConcretePrecision concretePrecision { get; }
        public bool hidden { get; set; }

        public virtual string GetPropertyTypeString();
    }
}
