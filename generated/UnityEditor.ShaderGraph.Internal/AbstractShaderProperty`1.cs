#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

namespace UnityEditor.ShaderGraph.Internal
{
    public abstract class AbstractShaderProperty<T> : AbstractShaderProperty
    {
        protected AbstractShaderProperty();

        public virtual T value { get; set; }
    }
}
