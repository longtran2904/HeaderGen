#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public abstract class BaseAnimValueNonAlloc<T> : BaseAnimValue<T> where T : IEquatable<T>
    {

        protected BaseAnimValueNonAlloc(T value);
        protected BaseAnimValueNonAlloc(T value, UnityAction callback);

        protected override bool AreEqual(T a, T b);
    }
}
