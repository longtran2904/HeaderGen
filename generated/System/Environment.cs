#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;

namespace System
{
    public static class Environment
    {
        public static int CurrentManagedThreadId { get; }
        public static int ExitCode { get; set; }
        public static int TickCount { get; }
        public static long TickCount64 { get; }
        public static int ProcessorCount { get; }
        public static bool IsPrivilegedProcess { get; }
        public static bool HasShutdownStarted { get; }
        public static string CommandLine { get; }
        public static string CurrentDirectory { get; set; }
        public static int ProcessId { get; }
        public static string ProcessPath { get; }
        public static bool Is64BitProcess { get; }
        public static bool Is64BitOperatingSystem { get; }
        public static string NewLine { get; }
        public static OperatingSystem OSVersion { get; }
        public static Version Version { get; }
        public static string StackTrace { get; }
        public static int SystemPageSize { get; }
        public static string UserName { get; }
        public static string UserDomainName { get; }
        public static string MachineName { get; }
        public static string SystemDirectory { get; }
        public static bool UserInteractive { get; }
        public static long WorkingSet { get; }

        public static void Exit(int exitCode);
        public static void FailFast(string message);
        public static void FailFast(string message, Exception exception);
        public static string GetEnvironmentVariable(string variable);
        public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target);
        public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target);
        public static void SetEnvironmentVariable(string variable, string value);
        public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target);
        public static string[] GetCommandLineArgs();
        public static string ExpandEnvironmentVariables(string name);
        public static string GetFolderPath(SpecialFolder folder);
        public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option);
        public static string[] GetLogicalDrives();
        public static IDictionary GetEnvironmentVariables();

        public enum SpecialFolder
        {
            ApplicationData = 26,
            CommonApplicationData = 35,
            LocalApplicationData = 28,
            Cookies = 33,
            Desktop = 0,
            Favorites = 6,
            History = 34,
            InternetCache = 32,
            Programs = 2,
            MyComputer = 17,
            MyMusic = 13,
            MyPictures = 39,
            MyVideos = 14,
            Recent = 8,
            SendTo = 9,
            StartMenu = 11,
            Startup = 7,
            System = 37,
            Templates = 21,
            DesktopDirectory = 16,
            Personal = 5,
            MyDocuments = 5,
            ProgramFiles = 38,
            CommonProgramFiles = 43,
            AdminTools = 48,
            CDBurning = 59,
            CommonAdminTools = 47,
            CommonDocuments = 46,
            CommonMusic = 53,
            CommonOemLinks = 58,
            CommonPictures = 54,
            CommonStartMenu = 22,
            CommonPrograms = 23,
            CommonStartup = 24,
            CommonDesktopDirectory = 25,
            CommonTemplates = 45,
            CommonVideos = 55,
            Fonts = 20,
            NetworkShortcuts = 19,
            PrinterShortcuts = 27,
            UserProfile = 40,
            CommonProgramFilesX86 = 44,
            ProgramFilesX86 = 42,
            Resources = 56,
            LocalizedResources = 57,
            SystemX86 = 41,
            Windows = 36
        }
        public enum SpecialFolderOption
        {
            None = 0,
            Create = 32768,
            DoNotVerify = 16384
        }
    }
}
