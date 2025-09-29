#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/ObjectNames.bindings.h")]
    public sealed class ObjectNames
    {
        public ObjectNames();

        [FreeFunction("NicifyVariableName_Internal")]
        public static string NicifyVariableName(string name);
        [FreeFunction("GetClassName_Internal")]
        public static string GetClassName([NotNull("NullExceptionObject")] UnityEngine.Object obj);
        [FreeFunction]
        public static string GetDragAndDropTitle(UnityEngine.Object obj);
        [FreeFunction("SetObjectNameSmart")]
        public static void SetNameSmart(UnityEngine.Object obj, string name);
        [FreeFunction("GetUniqueName_Internal")]
        public static string GetUniqueName(string[] existingNames, string name);
        public static string GetInspectorTitle(UnityEngine.Object obj);
        [Obsolete("Please use NicifyVariableName instead")]
        public static string MangleVariableName(string name);
        [Obsolete("Please use GetInspectorTitle instead")]
        public static string GetPropertyEditorTitle(UnityEngine.Object obj);
    }
}
