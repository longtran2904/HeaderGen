#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom.Compiler
{
    public static class Executor
    {
        public static void ExecWait(string cmd, TempFileCollection tempFiles);
        public static int ExecWaitWithCapture(nint userToken, string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName);
        public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName);
        public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName);
        public static int ExecWaitWithCapture(nint userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName);
    }
}
