#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor.AI
{
    [NativeHeader("Modules/AIEditor/Visualization/NavMeshVisualizationSettings.bindings.h")]
    [StaticAccessor("NavMeshVisualizationSettingsScriptBindings", StaticAccessorType.DoubleColon)]
    public static class NavMeshEditorHelpers
    {

        public static void OpenAgentSettings(int agentTypeID);
        public static void OpenAreaSettings();
        public static void DrawAgentDiagram(Rect rect, float agentRadius, float agentHeight, float agentClimb, float agentSlope);
        [ExcludeFromDocs]
        public static void DrawBuildDebug(NavMeshData navMeshData);
        public static void DrawBuildDebug(NavMeshData navMeshData, [DefaultValue("NavMeshBuildDebugFlags.All")] NavMeshBuildDebugFlags flags);
    }
}
