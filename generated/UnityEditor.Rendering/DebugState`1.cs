#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public class DebugState<T> : DebugState
    {

        [SerializeField]
        protected T m_Value;

        public DebugState();

        public virtual T value { get; set; }

        public override object GetValue();
        public override void SetValue(object value, DebugUI.IValueField field);
        public override int GetHashCode();
    }
}
