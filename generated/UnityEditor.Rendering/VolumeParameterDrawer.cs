#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public abstract class VolumeParameterDrawer
    {
        protected VolumeParameterDrawer();

        public virtual bool IsAutoProperty();
        public abstract bool OnGUI(SerializedDataParameter parameter, GUIContent title);
    }
}
