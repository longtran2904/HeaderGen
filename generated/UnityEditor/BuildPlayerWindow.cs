#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using JetBrains.Annotations;
using System;

namespace UnityEditor
{
    public class BuildPlayerWindow : EditorWindow
    {

        public BuildPlayerWindow();

        [UsedImplicitly]
        public static void ShowBuildPlayerWindow();
        public static string GetPlaybackEngineDownloadURL(string moduleName);
        public static void RegisterGetBuildPlayerOptionsHandler(Func<BuildPlayerOptions, BuildPlayerOptions> func);
        public static void RegisterBuildPlayerHandler(Action<BuildPlayerOptions> func);
        public class BuildMethodException : Exception
        {

            public BuildMethodException();
            public BuildMethodException(string message);
        }
        public static class DefaultBuildMethods
        {

            public static void BuildPlayer(BuildPlayerOptions options);
            public static BuildPlayerOptions GetBuildPlayerOptions(BuildPlayerOptions defaultBuildPlayerOptions);
        }
    }
}
