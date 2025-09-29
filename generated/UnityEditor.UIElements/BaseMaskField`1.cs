#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.UIElements
{
    public abstract class BaseMaskField<TChoice> : BasePopupField<TChoice, string>
    {
        public override List<string> choices { get; set; }
        public virtual List<int> choicesMasks { get; set; }

        public override void SetValueWithoutNotify(TChoice newValue);
    }
}
