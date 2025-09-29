#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Build
{
    public interface IFilterBuildAssemblies : IOrderedCallback
    {

        string[] OnFilterAssemblies(BuildOptions buildOptions, string[] assemblies);
    }
}
