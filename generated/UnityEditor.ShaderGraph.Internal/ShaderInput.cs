#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEditor.ShaderGraph.Serialization;

namespace UnityEditor.ShaderGraph.Internal
{
    public abstract class ShaderInput : JsonObject
    {

        protected ShaderInput();

        public string displayName { get; set; }
        public string referenceName { get; }
        public virtual string referenceNameForEditing { get; }
        public virtual bool allowedInSubGraph { get; }
        public virtual bool allowedInMainGraph { get; }

        public override void OnBeforeDeserialize();
        public virtual string GetOldDefaultReferenceName();
        public bool IsUsingOldDefaultRefName();
        public bool IsUsingNewDefaultRefName();
    }
}
