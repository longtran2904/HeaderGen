#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditor.Callbacks
{
    [RequiredByNativeCode]
    public sealed class OnOpenAssetAttribute : CallbackOrderAttribute
    {

        public OnOpenAssetAttribute();
        public OnOpenAssetAttribute(OnOpenAssetAttributeMode attributeMode);
        public OnOpenAssetAttribute(int callbackOrder);
        public OnOpenAssetAttribute(int callbackOrder, OnOpenAssetAttributeMode attributeMode);
    }
}
