#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.CodeDom;

namespace UnityEditor.Graphs
{
    public class Property
    {

        public Property();
        public Property(string typeString, string name);
        public Property(Type type, string name);

        public Type type { get; set; }
        public string typeString { get; }
        public bool isGeneric { get; }
        public bool hasValue { get; }
        public bool hasDefaultValue { get; }
        public string name { get; set; }
        public bool isIList { get; }
        public bool isSceneReferenceType { get; }
        public int elementCount { get; }
        public Type elementType { get; }
        public string stringValue { get; }
        public CodeExpression codeExpression { get; }
        public object value { get; set; }

        public static bool IsSceneReferenceType(Type t);
        public void SetGenericArgumentType(Type type);
        public void ResetGenericArgumentType();
        public static bool ValidPropertyType(Type type);
        public static object ConvertFromString(Type toType, string str);
        public void ChangeDataType(Type newDataType);
        public static object ConvertActualValueIfPossible(object value, Type toType);
        public static bool ConvertableUnityObjects(Type t1, Type t2);
    }
}
