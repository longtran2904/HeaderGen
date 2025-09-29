#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;

namespace UnityEditor.Graphs
{
    public class TypeSelector
    {
        public Type selectedType;
        public TypeKind selectedTypeKind;

        public TypeSelector();
        public TypeSelector(string[] types);
        public TypeSelector(bool onlyComponents);

        public bool DoGUI();
        public bool DoTypeKindGUI();
        public static Type GetFinalType(TypeKind typeKind, Type baseType);
        public static Type GetBaseType(TypeKind typeKind, Type finalType);
        public static TypeKind GetTypeKind(Type dataType);
        public static string DotNetTypeNiceName(Type t);

        public enum TypeKind
        {
            Simple = 0,
            List = 1,
            Array = 2
        }
    }
}
