#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AI
{
    [MovedFrom("UnityEditor")]
    [NativeHeader("Modules/AIEditor/Builder/NavMeshBuilderEditor.bindings.h")]
    [StaticAccessor("NavMeshBuilderEditorBindings", StaticAccessorType.DoubleColon)]
    public sealed class NavMeshBuilder
    {

        public NavMeshBuilder();

        public static UnityEngine.Object navMeshSettingsObject { get; }
        public static bool isRunning { get; }

        public static void BuildNavMesh();
        public static void BuildNavMeshAsync();
        [StaticAccessor("NavMeshBuilder", StaticAccessorType.DoubleColon)]
        public static void ClearAllNavMeshes();
        [StaticAccessor("NavMeshBuilder", StaticAccessorType.DoubleColon)]
        public static void Cancel();
        public static void BuildNavMeshForMultipleScenes(string[] paths);
        public static void CollectSourcesInStage(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, Scene stageProxy, List<NavMeshBuildSource> results);
        public static void CollectSourcesInStage(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, Scene stageProxy, List<NavMeshBuildSource> results);
    }
}
