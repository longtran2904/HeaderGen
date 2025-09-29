#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public class ExceptionHandlingClause
    {
        protected ExceptionHandlingClause();

        public virtual ExceptionHandlingClauseOptions Flags { get; }
        public virtual int TryOffset { get; }
        public virtual int TryLength { get; }
        public virtual int HandlerOffset { get; }
        public virtual int HandlerLength { get; }
        public virtual int FilterOffset { get; }
        public virtual Type CatchType { get; }

        public override string ToString();
    }
}
