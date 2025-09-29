#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(CodegenOptions.Custom, "MonoPackageInfo", Header = "Editor/Src/PackageUtility.h")]
    public struct PackageInfo
    {

        public string packagePath;
        public string jsonInfo;
        public string iconURL;
    }
}
