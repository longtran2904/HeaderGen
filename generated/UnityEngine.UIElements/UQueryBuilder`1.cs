#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> where T : VisualElement
    {
        public UQueryBuilder(VisualElement visualElement);

        public UQueryBuilder<T> Class(string classname);
        public UQueryBuilder<T> Name(string id);
        public UQueryBuilder<T2> Descendents<T2>(string name = null, params string[] classNames) where T2 : VisualElement;
        public UQueryBuilder<T2> Descendents<T2>(string name = null, string classname = null) where T2 : VisualElement;
        public UQueryBuilder<T2> Children<T2>(string name = null, params string[] classes) where T2 : VisualElement;
        public UQueryBuilder<T2> Children<T2>(string name = null, string className = null) where T2 : VisualElement;
        public UQueryBuilder<T2> OfType<T2>(string name = null, params string[] classes) where T2 : VisualElement;
        public UQueryBuilder<T2> OfType<T2>(string name = null, string className = null) where T2 : VisualElement;
        public UQueryBuilder<T> Where(Func<T, bool> selectorPredicate);
        public UQueryBuilder<T> Active();
        public UQueryBuilder<T> NotActive();
        public UQueryBuilder<T> Visible();
        public UQueryBuilder<T> NotVisible();
        public UQueryBuilder<T> Hovered();
        public UQueryBuilder<T> NotHovered();
        public UQueryBuilder<T> Checked();
        public UQueryBuilder<T> NotChecked();
        [Obsolete("Use Checked() instead")]
        public UQueryBuilder<T> Selected();
        [Obsolete("Use NotChecked() instead")]
        public UQueryBuilder<T> NotSelected();
        public UQueryBuilder<T> Enabled();
        public UQueryBuilder<T> NotEnabled();
        public UQueryBuilder<T> Focused();
        public UQueryBuilder<T> NotFocused();
        public UQueryState<T> Build();
        public T First();
        public T Last();
        public List<T> ToList();
        public void ToList(List<T> results);
        public T AtIndex(int index);
        public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall);
        public List<T2> ForEach<T2>(Func<T, T2> funcCall);
        public void ForEach(Action<T> funcCall);
        public bool Equals(UQueryBuilder<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(UQueryBuilder<T> builder1, UQueryBuilder<T> builder2);
        public static bool operator !=(UQueryBuilder<T> builder1, UQueryBuilder<T> builder2);

        public static implicit operator T(UQueryBuilder<T> s);
    }
}
