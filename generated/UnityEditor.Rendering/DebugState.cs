#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public abstract class DebugState : ScriptableObject
    {

        [SerializeField]
        protected string m_QueryPath;

        protected DebugState();

        public string queryPath { get; }

        public abstract object GetValue();
        public abstract void SetValue(object value, DebugUI.IValueField field);
        public virtual void OnEnable();
    }
}
