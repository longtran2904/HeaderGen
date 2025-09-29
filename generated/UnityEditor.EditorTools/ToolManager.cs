#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.EditorTools
{
    public static class ToolManager
    {
        public static Type activeContextType { get; }
        public static Type activeToolType { get; }

        public static event Action activeToolChanging;
        public static event Action activeToolChanged;
        public static event Action activeContextChanging;
        public static event Action activeContextChanged;

        public static void SetActiveContext(Type context);
        public static void SetActiveContext<T>() where T : EditorToolContext;
        public static void SetActiveTool<T>() where T : EditorTool;
        public static void SetActiveTool(Type type);
        public static void SetActiveTool(EditorTool tool);
        public static void RestorePreviousTool();
        public static void RestorePreviousPersistentTool();
        public static bool IsActiveTool(EditorTool tool);
        public static bool IsActiveContext(EditorToolContext context);
    }
}
