#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class VolumeParameter<T> : VolumeParameter, IEquatable<VolumeParameter<T>>
    {
        [SerializeField]
        protected T m_Value;

        public VolumeParameter();
        protected VolumeParameter(T value, bool overrideState);

        public virtual T value { get; set; }

        public virtual void Interp(T from, T to, float t);
        public void Override(T x);
        public override void SetValue(VolumeParameter parameter);
        public override int GetHashCode();
        public override string ToString();
        public bool Equals(VolumeParameter<T> other);
        public override bool Equals(object obj);

        public static bool operator ==(VolumeParameter<T> lhs, T rhs);
        public static bool operator !=(VolumeParameter<T> lhs, T rhs);

        public static explicit operator T(VolumeParameter<T> prop);
    }
}
