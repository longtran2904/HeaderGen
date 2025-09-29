#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class LongField : TextValueField<long>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public LongField();
        public LongField(int maxLength);
        public LongField(string label, int maxLength = -1);

        protected override string ValueToString(long v);
        protected override long StringToValue(string str);
        public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue);

        public class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<long, UxmlLongAttributeDescription>
        {
            public UxmlTraits();
        }
    }
}
