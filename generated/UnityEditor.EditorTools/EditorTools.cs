#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.EditorTools
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("EditorTools has been deprecated. Use ToolManager instead (UnityUpgradable) -> ToolManager")]
    public static class EditorTools
    {
        public static Type activeToolType { get; }

        public static event Action activeToolChanging;
        public static event Action activeToolChanged;

        public static void SetActiveTool<T>() where T : EditorTool;
        public static void SetActiveTool(Type type);
        public static void SetActiveTool(EditorTool tool);
        public static void RestorePreviousTool();
        public static void RestorePreviousPersistentTool();
        public static bool IsActiveTool(EditorTool tool);
    }
}
