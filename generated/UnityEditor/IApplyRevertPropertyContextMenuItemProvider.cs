#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public interface IApplyRevertPropertyContextMenuItemProvider
    {

        bool TryGetRevertMethodForFieldName(SerializedProperty property, out Action<SerializedProperty> revertMethod);
        bool TryGetApplyMethodForFieldName(SerializedProperty property, out Action<SerializedProperty> applyMethod);
        string GetSourceTerm();
        string GetSourceName(Component comp);
    }
}
