#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public struct StylePropertyNameCollection : IEnumerable, IEnumerable<StylePropertyName>
    {

        public Enumerator GetEnumerator();
        public bool Contains(StylePropertyName stylePropertyName);
        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<StylePropertyName>
        {

            public StylePropertyName Current { get; }

            public bool MoveNext();
            public void Reset();
            public void Dispose();
        }
    }
}
