#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class FloatField : TextValueField<float>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public FloatField();
        public FloatField(int maxLength);
        public FloatField(string label, int maxLength = -1);

        protected override string ValueToString(float v);
        protected override float StringToValue(string str);
        public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue);
        public class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<float, UxmlFloatAttributeDescription>
        {

            public UxmlTraits();
        }
    }
}
