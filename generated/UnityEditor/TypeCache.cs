#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Runtime/Mono/TypeCache.h")]
    public static class TypeCache
    {
        [ThreadSafe]
        public static TypeCollection GetTypesWithAttribute(Type attrType);
        [ThreadSafe]
        public static MethodCollection GetMethodsWithAttribute(Type attrType);
        [ThreadSafe]
        public static FieldInfoCollection GetFieldsWithAttribute(Type attrType);
        public static TypeCollection GetTypesWithAttribute<T>() where T : Attribute;
        public static MethodCollection GetMethodsWithAttribute<T>() where T : Attribute;
        public static FieldInfoCollection GetFieldsWithAttribute<T>() where T : Attribute;
        public static TypeCollection GetTypesDerivedFrom<T>();
        public static TypeCollection GetTypesDerivedFrom(Type parentType);

        [DefaultMember("Item")]
        public struct TypeCollection : ICollection, ICollection<Type>, IEnumerable, IEnumerable<Type>, IList, IList<Type>
        {
            public Type this[int index] { get; set; }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public bool IsFixedSize { get; }
            public bool IsSynchronized { get; }

            public bool Contains(Type item);
            public bool Contains(object item);
            public Enumerator GetEnumerator();
            public void CopyTo(Type[] array, int arrayIndex);
            public void CopyTo(Array array, int arrayIndex);
            public int IndexOf(Type item);
            public int IndexOf(object item);

            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Type>
            {
                public Type Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
        [DefaultMember("Item")]
        public struct MethodCollection : ICollection, ICollection<MethodInfo>, IEnumerable, IEnumerable<MethodInfo>, IList, IList<MethodInfo>
        {
            public MethodInfo this[int index] { get; set; }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public bool IsFixedSize { get; }
            public bool IsSynchronized { get; }

            public bool Contains(MethodInfo item);
            public bool Contains(object item);
            public Enumerator GetEnumerator();
            public void CopyTo(MethodInfo[] array, int arrayIndex);
            public void CopyTo(Array array, int arrayIndex);
            public int IndexOf(MethodInfo item);
            public int IndexOf(object item);

            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<MethodInfo>
            {
                public MethodInfo Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
        [DefaultMember("Item")]
        public struct FieldInfoCollection : ICollection, ICollection<FieldInfo>, IEnumerable, IEnumerable<FieldInfo>, IList, IList<FieldInfo>
        {
            public FieldInfo this[int index] { get; set; }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public bool IsFixedSize { get; }
            public bool IsSynchronized { get; }

            public bool Contains(FieldInfo item);
            public bool Contains(object item);
            public Enumerator GetEnumerator();
            public void CopyTo(FieldInfo[] array, int arrayIndex);
            public void CopyTo(Array array, int arrayIndex);
            public int IndexOf(FieldInfo item);
            public int IndexOf(object item);

            public struct Enumerator : IDisposable, IEnumerator, IEnumerator<FieldInfo>
            {
                public FieldInfo Current { get; }

                public void Dispose();
                public bool MoveNext();
            }
        }
    }
}
