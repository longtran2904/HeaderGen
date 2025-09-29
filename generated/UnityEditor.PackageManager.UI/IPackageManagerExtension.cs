#region UnityEditor.PackageManagerUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.PackageManagerUIModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.PackageManager.UI
{
    public interface IPackageManagerExtension
    {

        VisualElement CreateExtensionUI();
        void OnPackageSelectionChange(PackageInfo packageInfo);
        void OnPackageAddedOrUpdated(PackageInfo packageInfo);
        void OnPackageRemoved(PackageInfo packageInfo);
    }
}
