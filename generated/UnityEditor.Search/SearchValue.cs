#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Search
{
    public readonly struct SearchValue
    {

        public readonly ValueType type;
        public readonly double number;
        public readonly string text;
        public static SearchValue invalid;

        public SearchValue(bool v);
        public SearchValue(float number);
        public SearchValue(double number);
        public SearchValue(string text);
        public SearchValue(Color color);
        public SearchValue(object v);

        public bool boolean { get; }
        public bool valid { get; }

        public override string ToString();
        public static SearchValue ConvertPropertyValue(in SerializedProperty sp);
        public static void SetupEngine<T>(QueryEngine<T> queryEngine);
        public enum ValueType
        {

            Nil = 0,
            Bool = 1,
            Number = 2,
            Text = 3,
            Color = 4,
            Enum = 5,
            Object = 6,
            Vector2 = 7,
            Vector3 = 8,
            Vector4 = 9
        }
    }
}
