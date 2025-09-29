#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(CodegenOptions.Custom, "MonoEditorCurveBinding")]
    public struct EditorCurveBinding : IEquatable<EditorCurveBinding>
    {

        public string path;
        public string propertyName;

        public bool isPPtrCurve { get; }
        public bool isDiscreteCurve { get; }
        public Type type { get; set; }

        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(EditorCurveBinding other);
        public static EditorCurveBinding FloatCurve(string inPath, Type inType, string inPropertyName);
        public static EditorCurveBinding PPtrCurve(string inPath, Type inType, string inPropertyName);
        public static EditorCurveBinding DiscreteCurve(string inPath, Type inType, string inPropertyName);

        public static bool operator ==(EditorCurveBinding lhs, EditorCurveBinding rhs);
        public static bool operator !=(EditorCurveBinding lhs, EditorCurveBinding rhs);
    }
}
