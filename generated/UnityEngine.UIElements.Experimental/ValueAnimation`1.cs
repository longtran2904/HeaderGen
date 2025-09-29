#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements.Experimental
{
    public sealed class ValueAnimation<T> : IValueAnimation, IValueAnimationUpdate
    {
        public ValueAnimation();

        public int durationMs { get; set; }
        public Func<float, float> easingCurve { get; set; }
        public bool isRunning { get; }
        public Action onAnimationCompleted { get; set; }
        public bool autoRecycle { get; set; }
        public Action<VisualElement, T> valueUpdated { get; set; }
        public Func<VisualElement, T> initialValue { get; set; }
        public Func<T, T, float, T> interpolator { get; set; }
        public T from { get; set; }
        public T to { get; set; }

        public void Start();
        public void Stop();
        public void Recycle();
        public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator);
        public ValueAnimation<T> Ease(Func<float, float> easing);
        public ValueAnimation<T> OnCompleted(Action callback);
        public ValueAnimation<T> KeepAlive();
    }
}
