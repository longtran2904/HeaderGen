#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public struct Nullable<T> where T : struct
    {
        public Nullable(T value);

        public bool HasValue { get; }
        public T Value { get; }

        public T GetValueOrDefault();
        public T GetValueOrDefault(T defaultValue);
        public override bool Equals(object other);
        public override int GetHashCode();
        public override string ToString();

        public static implicit operator T?(T value);
        public static explicit operator T(T? value);
    }
}
