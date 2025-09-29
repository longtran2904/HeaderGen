#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public ref struct ArgIterator
    {
        public ArgIterator(RuntimeArgumentHandle arglist);
        [CLSCompliant(False)]
        public ArgIterator(RuntimeArgumentHandle arglist, void* ptr);

        [CLSCompliant(False)]
        public TypedReference GetNextArg();
        [CLSCompliant(False)]
        public TypedReference GetNextArg(RuntimeTypeHandle rth);
        public void End();
        public int GetRemainingCount();
        public RuntimeTypeHandle GetNextArgType();
        public override int GetHashCode();
        public override bool Equals(object o);
    }
}
