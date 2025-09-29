#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class EnumFlagsField : BaseMaskField<Enum>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public EnumFlagsField(Enum defaultValue);
        public EnumFlagsField(Enum defaultValue, bool includeObsoleteValues);
        public EnumFlagsField(string label, Enum defaultValue);
        public EnumFlagsField();
        public EnumFlagsField(string label, Enum defaultValue, bool includeObsoleteValues);
        public EnumFlagsField(string label);

        public void Init(Enum defaultValue, bool includeObsoleteValues = False);
        public class UxmlFactory : UxmlFactory<EnumFlagsField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Enum>.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
