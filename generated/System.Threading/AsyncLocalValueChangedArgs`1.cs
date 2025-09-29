#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public readonly struct AsyncLocalValueChangedArgs<T>
    {

        public T PreviousValue { get; }
        public T CurrentValue { get; }
        public bool ThreadContextChanged { get; }
    }
}
