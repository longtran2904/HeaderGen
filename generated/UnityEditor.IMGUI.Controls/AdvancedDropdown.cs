#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public abstract class AdvancedDropdown
    {
        public AdvancedDropdown(AdvancedDropdownState state);

        protected Vector2 minimumSize { get; set; }

        public void Show(Rect rect);
        protected abstract AdvancedDropdownItem BuildRoot();
        protected virtual void ItemSelected(AdvancedDropdownItem item);
    }
}
