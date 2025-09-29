#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public class MethodBody
    {

        protected MethodBody();

        public virtual int LocalSignatureMetadataToken { get; }
        public virtual IList<LocalVariableInfo> LocalVariables { get; }
        public virtual int MaxStackSize { get; }
        public virtual bool InitLocals { get; }
        public virtual IList<ExceptionHandlingClause> ExceptionHandlingClauses { get; }

        public virtual byte[] GetILAsByteArray();
    }
}
