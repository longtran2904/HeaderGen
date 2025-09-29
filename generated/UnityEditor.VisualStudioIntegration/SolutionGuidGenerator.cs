#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.ComponentModel;

namespace UnityEditor.VisualStudioIntegration
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class SolutionGuidGenerator
    {

        public static string GuidForProject(string projectName);
        public static string GuidForSolution(string projectName, string sourceFileExtension);
    }
}
