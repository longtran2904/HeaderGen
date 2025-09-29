#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.Build.Reporting;

namespace UnityEditor.Build
{
    public interface IPreprocessBuildWithReport : IOrderedCallback
    {
        void OnPreprocessBuild(BuildReport report);
    }
}
