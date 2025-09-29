#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    public enum SelectionMode
    {
        Unfiltered = 0,
        TopLevel = 1,
        Deep = 2,
        ExcludePrefab = 4,
        Editable = 8,
        Assets = 16,
        DeepAssets = 32,
        [Obsolete("'OnlyUserModifiable' is obsolete. Use 'Editable' instead. (UnityUpgradeable) -> Editable", True)]
        OnlyUserModifiable = 8
    }
}
