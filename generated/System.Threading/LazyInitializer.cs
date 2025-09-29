#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public static class LazyInitializer
    {

        public static T EnsureInitialized<T>(ref T target) where T : class;
        public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class;
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock);
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory);
        public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class;
    }
}
