#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/SerializedProperty.h")]
    [NativeHeader("Editor/Src/Utility/SerializedProperty.bindings.h")]
    public class SerializedProperty : IDisposable
    {

        ~SerializedProperty();

        public SerializedObject serializedObject { get; }
        public UnityEngine.Object exposedReferenceValue { get; set; }
        public bool hasMultipleDifferentValues { get; }
        public string displayName { get; }
        public string name { get; }
        public string type { get; }
        public string arrayElementType { get; }
        public string tooltip { get; }
        public int depth { get; }
        public string propertyPath { get; }
        public bool editable { get; }
        public bool isAnimated { get; }
        public bool isExpanded { get; set; }
        public bool hasChildren { get; }
        public bool hasVisibleChildren { get; }
        public bool isInstantiatedPrefab { get; }
        public bool prefabOverride { get; set; }
        public bool isDefaultOverride { get; }
        public SerializedPropertyType propertyType { get; }
        public int intValue { get; set; }
        public long longValue { get; set; }
        public bool boolValue { get; set; }
        public float floatValue { get; set; }
        public double doubleValue { get; set; }
        public string stringValue { get; set; }
        public Color colorValue { get; set; }
        public AnimationCurve animationCurveValue { get; set; }
        public UnityEngine.Object objectReferenceValue { get; set; }
        public object managedReferenceValue { get; set; }
        public long managedReferenceId { get; set; }
        public string managedReferenceFullTypename { get; }
        public string managedReferenceFieldTypename { get; }
        public int objectReferenceInstanceIDValue { get; set; }
        public int enumValueIndex { get; set; }
        public int enumValueFlag { get; set; }
        public string[] enumNames { get; }
        public string[] enumDisplayNames { get; }
        public Vector2 vector2Value { get; set; }
        public Vector3 vector3Value { get; set; }
        public Vector4 vector4Value { get; set; }
        public Vector2Int vector2IntValue { get; set; }
        public Vector3Int vector3IntValue { get; set; }
        public Quaternion quaternionValue { get; set; }
        public Rect rectValue { get; set; }
        public RectInt rectIntValue { get; set; }
        public Bounds boundsValue { get; set; }
        public BoundsInt boundsIntValue { get; set; }
        public Hash128 hash128Value { get; set; }
        public bool isArray { get; }
        public int arraySize { get; set; }
        public int minArraySize { get; }
        public bool isFixedBuffer { get; }
        public int fixedBufferSize { get; }

        public SerializedProperty Copy();
        public SerializedProperty FindPropertyRelative(string relativePropertyPath);
        public IEnumerator GetEnumerator();
        public SerializedProperty GetArrayElementAtIndex(int index);
        public bool NextVisible(bool enterChildren);
        public void ClearArray();
        [ThreadAndSerializationSafe]
        public void Dispose();
        public static bool EqualContents(SerializedProperty x, SerializedProperty y);
        public static bool DataEquals(SerializedProperty x, SerializedProperty y);
        public bool Next(bool enterChildren);
        public void Reset();
        public int CountRemaining();
        public int CountInProperty();
        public bool DuplicateCommand();
        public bool DeleteCommand();
        public SerializedProperty GetEndProperty();
        public SerializedProperty GetEndProperty(bool includeInvisible);
        public void InsertArrayElementAtIndex(int index);
        public void DeleteArrayElementAtIndex(int index);
        public bool MoveArrayElement(int srcIndex, int dstIndex);
        public SerializedProperty GetFixedBufferElementAtIndex(int index);
    }
}
