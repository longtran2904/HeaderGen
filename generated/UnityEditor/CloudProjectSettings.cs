#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public class CloudProjectSettings
    {
        public CloudProjectSettings();

        public static string userId { get; }
        public static string userName { get; }
        public static string accessToken { get; }
        public static string projectId { get; }
        public static string projectName { get; }
        public static string organizationId { get; }
        public static string organizationName { get; }

        public static void RefreshAccessToken(Action<bool> refresh);
    }
}
