#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/HierarchyProperty.bindings.h")]
    public sealed class HierarchyProperty : IHierarchyProperty
    {

        public HierarchyProperty(HierarchyType hierarchyType);
        public HierarchyProperty(HierarchyType hierarchyType, bool forceImport);
        public HierarchyProperty(string rootPath);
        public HierarchyProperty(string rootPath, bool forceImport);
        public HierarchyProperty(HierarchyType hierarchyType, string rootPath, bool forceImport);

        ~HierarchyProperty();

        public int instanceID { get; }
        public UnityEngine.Object pptrValue { get; }
        public string name { get; }
        public bool hasChildren { get; }
        public int depth { get; }
        public int[] ancestors { get; }
        public int row { get; }
        public int colorCode { get; }
        public string guid { get; }
        public bool alphaSorted { get; set; }
        public bool showSceneHeaders { get; set; }
        public bool isSceneHeader { get; }
        public bool isValid { get; }
        public bool isMainRepresentation { get; }
        public bool hasFullPreviewImage { get; }
        public IconDrawStyle iconDrawStyle { get; }
        public bool isFolder { get; }
        public GUID[] dynamicDependencies { get; }
        public Texture2D icon { get; }

        [FreeFunction("HierarchyPropertyBindings::SetCustomScenes", HasExplicitThis = True)]
        public void SetCustomScenes([NotNull("ArgumentNullException")] int[] sceneHandles);
        [FreeFunction("HierarchyPropertyBindings::SetSubScenes", HasExplicitThis = True)]
        public void SetSubScenes([NotNull("ArgumentNullException")] SceneHierarchyHooks.SubSceneInfo[] subScenes);
        public void Reset();
        [FreeFunction("HierarchyPropertyBindings::GetScene", ThrowsException = True, HasExplicitThis = True)]
        public Scene GetScene();
        [FreeFunction("HierarchyPropertyBindings::IsExpanded", HasExplicitThis = True)]
        public bool IsExpanded([Unmarshalled] int[] expanded);
        [FreeFunction("HierarchyPropertyBindings::Next", HasExplicitThis = True)]
        public bool Next([Unmarshalled] int[] expanded);
        [FreeFunction("HierarchyPropertyBindings::NextWithDepthCheck", HasExplicitThis = True)]
        public bool NextWithDepthCheck([Unmarshalled] int[] expanded, int minDepth);
        [FreeFunction("HierarchyPropertyBindings::Previous", HasExplicitThis = True)]
        public bool Previous([Unmarshalled] int[] expanded);
        public bool Parent();
        [FreeFunction("HierarchyPropertyBindings::Find", HasExplicitThis = True)]
        public bool Find(int instanceID, [Unmarshalled] int[] expanded);
        [FreeFunction("HierarchyPropertyBindings::Skip", HasExplicitThis = True)]
        public bool Skip(int count, [Unmarshalled] int[] expanded);
        [FreeFunction("HierarchyPropertyBindings::CountRemaining", HasExplicitThis = True)]
        public int CountRemaining([Unmarshalled] int[] expanded);
        public int GetInstanceIDIfImported();
        public void SetSearchFilter(string searchString, int mode);
        [FreeFunction("HierarchyPropertyBindings::FindAllAncestors", HasExplicitThis = True)]
        public int[] FindAllAncestors(int[] instanceIDs);
        [FreeFunction("HierarchyPropertyBindings::ClearSceneObjectsFilter")]
        public static void ClearSceneObjectsFilter();
        [FreeFunction("HierarchyPropertyBindings::FilterSingleSceneObject")]
        public static void FilterSingleSceneObject(int instanceID, bool otherVisibilityState);
    }
}
