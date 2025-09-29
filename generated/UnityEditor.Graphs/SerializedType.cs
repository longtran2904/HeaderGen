#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;

namespace UnityEditor.Graphs
{
    public class SerializedType
    {
        public SerializedType();

        public static Type GenericType(Type t);
        public static bool IsListType(Type t);
        public static string GetFullName(Type t);
        public static string ToString(Type t);
        public static Type FromString(string serializedTypeString);
        public static bool IsGeneric(string serializedTypeString);
        public static bool IsBaseTypeGeneric(string serializedTypeString);
        public static string SetGenericArgumentType(string serializedTypeString, Type type);
        public static string ResetGenericArgumentType(string serializedTypeString);
        public static bool CanAssignFromGenericType(string serializedTypeString, Type t);
    }
}
