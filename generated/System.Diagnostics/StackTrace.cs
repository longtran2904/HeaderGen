#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Diagnostics
{
    public class StackTrace
    {

        public const int METHODS_TO_SKIP = 0;

        public StackTrace();
        public StackTrace(bool fNeedFileInfo);
        public StackTrace(int skipFrames);
        public StackTrace(int skipFrames, bool fNeedFileInfo);
        public StackTrace(Exception e);
        public StackTrace(Exception e, bool fNeedFileInfo);
        public StackTrace(Exception e, int skipFrames);
        public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo);
        public StackTrace(StackFrame frame);
        public StackTrace(IEnumerable<StackFrame> frames);

        public virtual int FrameCount { get; }

        public virtual StackFrame GetFrame(int index);
        public virtual StackFrame[] GetFrames();
        public override string ToString();
    }
}
