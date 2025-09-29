#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public abstract class VolumeParameter
    {
        [SerializeField]
        protected bool m_OverrideState;
        public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";

        protected VolumeParameter();

        public virtual bool overrideState { get; set; }

        public T GetValue<T>();
        public abstract void SetValue(VolumeParameter parameter);
        protected internal virtual void OnEnable();
        protected internal virtual void OnDisable();
        public static bool IsObjectParameter(Type type);
        public virtual void Release();
    }
}
