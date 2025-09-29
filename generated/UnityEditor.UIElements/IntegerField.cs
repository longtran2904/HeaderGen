#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class IntegerField : TextValueField<int>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public IntegerField();
        public IntegerField(int maxLength);
        public IntegerField(string label, int maxLength = -1);

        protected override string ValueToString(int v);
        protected override int StringToValue(string str);
        public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue);

        public class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<int, UxmlIntAttributeDescription>
        {
            public UxmlTraits();
        }
    }
}
