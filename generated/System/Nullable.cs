#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class Nullable
    {

        public static int Compare<T>(T? n1, T? n2) where T : struct;
        public static bool Equals<T>(T? n1, T? n2) where T : struct;
        public static Type GetUnderlyingType(Type nullableType);
        public static ref readonly T GetValueRefOrDefaultRef<T>(in T? nullable) where T : struct;
    }
}
