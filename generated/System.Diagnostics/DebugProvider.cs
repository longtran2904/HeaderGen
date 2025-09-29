#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    public class DebugProvider
    {
        public DebugProvider();

        public virtual void Fail(string message, string detailMessage);
        public virtual void Write(string message);
        public virtual void WriteLine(string message);
        public virtual void OnIndentLevelChanged(int indentLevel);
        public virtual void OnIndentSizeChanged(int indentSize);
        public static void FailCore(string stackTrace, string message, string detailMessage, string errorSource);
        public static void WriteCore(string message);
    }
}
