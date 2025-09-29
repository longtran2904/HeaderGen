#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public sealed class MethodInvoker
    {

        public static MethodInvoker Create(MethodBase method);
        public object Invoke(object obj);
        public object Invoke(object obj, object arg1);
        public object Invoke(object obj, object arg1, object arg2);
        public object Invoke(object obj, object arg1, object arg2, object arg3);
        public object Invoke(object obj, object arg1, object arg2, object arg3, object arg4);
        public object Invoke(object obj, Span<object> arguments);
    }
}
