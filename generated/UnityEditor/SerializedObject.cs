#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/SerializedObject.bindings.h")]
    [NativeHeader("Editor/Src/Utility/SerializedObjectCache.h")]
    [NativeHeader("Editor/Src/Utility/SerializedProperty.h")]
    public class SerializedObject : IDisposable
    {
        public SerializedObject(UnityEngine.Object obj);
        public SerializedObject(UnityEngine.Object obj, UnityEngine.Object context);
        public SerializedObject(UnityEngine.Object[] objs);
        public SerializedObject(UnityEngine.Object[] objs, UnityEngine.Object context);

        ~SerializedObject();

        public UnityEngine.Object targetObject { get; }
        public UnityEngine.Object[] targetObjects { get; }
        [NativeProperty("ContextObject")]
        public UnityEngine.Object context { get; }
        public bool hasModifiedProperties { get; }
        public bool isEditingMultipleObjects { get; }
        public int maxArraySizeForMultiEditing { get; set; }
        public bool forceChildVisibility { get; set; }

        [ThreadAndSerializationSafe]
        public void Dispose();
        public SerializedProperty GetIterator();
        public SerializedProperty FindProperty(string propertyPath);
        public bool ApplyModifiedProperties();
        public void SetIsDifferentCacheDirty();
        public void Update();
        [NativeName("UpdateIfRequiredOrScript")]
        [Obsolete("UpdateIfDirtyOrScript has been deprecated. Use UpdateIfRequiredOrScript instead.", False)]
        public void UpdateIfDirtyOrScript();
        public bool UpdateIfRequiredOrScript();
        public bool ApplyModifiedPropertiesWithoutUndo();
        public void CopyFromSerializedProperty(SerializedProperty prop);
        public bool CopyFromSerializedPropertyIfDifferent(SerializedProperty prop);
    }
}
