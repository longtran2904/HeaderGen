#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Diagnostics
{
    public class StackFrame
    {

        public const int OFFSET_UNKNOWN = -1;

        public StackFrame();
        public StackFrame(bool needFileInfo);
        public StackFrame(int skipFrames);
        public StackFrame(int skipFrames, bool needFileInfo);
        public StackFrame(string fileName, int lineNumber);
        public StackFrame(string fileName, int lineNumber, int colNumber);

        public virtual MethodBase GetMethod();
        public virtual int GetNativeOffset();
        public virtual int GetILOffset();
        public virtual string GetFileName();
        public virtual int GetFileLineNumber();
        public virtual int GetFileColumnNumber();
        public override string ToString();
    }
}
