#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public abstract class BaseAnimValue<T> : ISerializationCallbackReceiver
    {

        public float speed;
        [NonSerialized]
        public UnityEvent valueChanged;

        protected BaseAnimValue(T value);
        protected BaseAnimValue(T value, UnityAction callback);

        public bool isAnimating { get; }
        protected float lerpPosition { get; }
        protected T start { get; }
        public T target { get; set; }
        public T value { get; set; }

        protected virtual bool AreEqual(T a, T b);
        protected void BeginAnimating(T newTarget, T newStart);
        protected void StopAnim(T newValue);
        protected abstract T GetValue();
    }
}
