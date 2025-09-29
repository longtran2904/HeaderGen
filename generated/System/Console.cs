#region System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Console.dll
#endregion

using System.IO;
using System.Runtime.Versioning;
using System.Text;

namespace System
{
    public static class Console
    {

        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static TextReader In { get; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static Encoding InputEncoding { get; set; }
        public static Encoding OutputEncoding { get; set; }
        public static bool KeyAvailable { get; }
        public static TextWriter Out { get; }
        public static TextWriter Error { get; }
        public static bool IsInputRedirected { get; }
        public static bool IsOutputRedirected { get; }
        public static bool IsErrorRedirected { get; }
        public static int CursorSize { get; set; }
        [SupportedOSPlatform("windows")]
        public static bool NumberLock { get; }
        [SupportedOSPlatform("windows")]
        public static bool CapsLock { get; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleColor BackgroundColor { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleColor ForegroundColor { get; set; }
        public static int BufferWidth { get; set; }
        public static int BufferHeight { get; set; }
        public static int WindowLeft { get; set; }
        public static int WindowTop { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int WindowWidth { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int WindowHeight { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int LargestWindowWidth { get; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int LargestWindowHeight { get; }
        public static bool CursorVisible { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int CursorLeft { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static int CursorTop { get; set; }
        public static string Title { get; set; }
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static bool TreatControlCAsInput { get; set; }

        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static event ConsoleCancelEventHandler CancelKeyPress;

        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleKeyInfo ReadKey();
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static ConsoleKeyInfo ReadKey(bool intercept);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void ResetColor();
        [SupportedOSPlatform("windows")]
        public static void SetBufferSize(int width, int height);
        [SupportedOSPlatform("windows")]
        public static void SetWindowPosition(int left, int top);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void SetWindowSize(int width, int height);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static (int Left, int Top) GetCursorPosition();
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void Beep();
        [SupportedOSPlatform("windows")]
        public static void Beep(int frequency, int duration);
        [SupportedOSPlatform("windows")]
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);
        [SupportedOSPlatform("windows")]
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void Clear();
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void SetCursorPosition(int left, int top);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static Stream OpenStandardInput();
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static Stream OpenStandardInput(int bufferSize);
        public static Stream OpenStandardOutput();
        public static Stream OpenStandardOutput(int bufferSize);
        public static Stream OpenStandardError();
        public static Stream OpenStandardError(int bufferSize);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("tvos")]
        public static void SetIn(TextReader newIn);
        public static void SetOut(TextWriter newOut);
        public static void SetError(TextWriter newError);
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static int Read();
        [UnsupportedOSPlatform("android")]
        [UnsupportedOSPlatform("browser")]
        public static string ReadLine();
        public static void WriteLine();
        public static void WriteLine(bool value);
        public static void WriteLine(char value);
        public static void WriteLine(char[] buffer);
        public static void WriteLine(char[] buffer, int index, int count);
        public static void WriteLine(decimal value);
        public static void WriteLine(double value);
        public static void WriteLine(float value);
        public static void WriteLine(int value);
        [CLSCompliant(False)]
        public static void WriteLine(uint value);
        public static void WriteLine(long value);
        [CLSCompliant(False)]
        public static void WriteLine(ulong value);
        public static void WriteLine(object value);
        public static void WriteLine(string value);
        public static void WriteLine(string format, object arg0);
        public static void WriteLine(string format, object arg0, object arg1);
        public static void WriteLine(string format, object arg0, object arg1, object arg2);
        public static void WriteLine(string format, params object[] arg);
        public static void Write(string format, object arg0);
        public static void Write(string format, object arg0, object arg1);
        public static void Write(string format, object arg0, object arg1, object arg2);
        public static void Write(string format, params object[] arg);
        public static void Write(bool value);
        public static void Write(char value);
        public static void Write(char[] buffer);
        public static void Write(char[] buffer, int index, int count);
        public static void Write(double value);
        public static void Write(decimal value);
        public static void Write(float value);
        public static void Write(int value);
        [CLSCompliant(False)]
        public static void Write(uint value);
        public static void Write(long value);
        [CLSCompliant(False)]
        public static void Write(ulong value);
        public static void Write(object value);
        public static void Write(string value);
    }
}
