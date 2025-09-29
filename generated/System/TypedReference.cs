#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System
{
    [CLSCompliant(False)]
    public ref struct TypedReference
    {

        public static object ToObject(TypedReference value);
        public static TypedReference MakeTypedReference(object target, FieldInfo[] flds);
        public override int GetHashCode();
        public override bool Equals(object o);
        public static Type GetTargetType(TypedReference value);
        public static RuntimeTypeHandle TargetTypeToken(TypedReference value);
        public static void SetTypedReference(TypedReference target, object value);
    }
}
