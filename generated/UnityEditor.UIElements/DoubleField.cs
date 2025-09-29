#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class DoubleField : TextValueField<double>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public DoubleField();
        public DoubleField(int maxLength);
        public DoubleField(string label, int maxLength = -1);

        protected override string ValueToString(double v);
        protected override double StringToValue(string str);
        public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue);
        public class UxmlFactory : UxmlFactory<DoubleField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<double, UxmlDoubleAttributeDescription>
        {

            public UxmlTraits();
        }
    }
}
