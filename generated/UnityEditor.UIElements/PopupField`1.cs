#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.UIElements
{
    public class PopupField<T> : BasePopupField<T, T>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public PopupField();
        public PopupField(string label = null);
        public PopupField(List<T> choices, T defaultValue, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
        public PopupField(string label, List<T> choices, T defaultValue, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
        public PopupField(List<T> choices, int defaultIndex, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);
        public PopupField(string label, List<T> choices, int defaultIndex, Func<T, string> formatSelectedValueCallback = null, Func<T, string> formatListItemCallback = null);

        public virtual Func<T, string> formatSelectedValueCallback { get; set; }
        public virtual Func<T, string> formatListItemCallback { get; set; }
        public override T value { get; set; }
        public int index { get; set; }

        public override void SetValueWithoutNotify(T newValue);
    }
}
