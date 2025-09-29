#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public struct UQueryState<T> : IEnumerable, IEnumerable<T>, IEquatable<UQueryState<T>> where T : VisualElement
    {

        public UQueryState<T> RebuildOn(VisualElement element);
        public T First();
        public T Last();
        public void ToList(List<T> results);
        public List<T> ToList();
        public T AtIndex(int index);
        public void ForEach(Action<T> funcCall);
        public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall);
        public List<T2> ForEach<T2>(Func<T, T2> funcCall);
        public Enumerator GetEnumerator();
        public bool Equals(UQueryState<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(UQueryState<T> state1, UQueryState<T> state2);
        public static bool operator !=(UQueryState<T> state1, UQueryState<T> state2);
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T>
        {

            public T Current { get; }

            public bool MoveNext();
            public void Reset();
            public void Dispose();
        }
    }
}
