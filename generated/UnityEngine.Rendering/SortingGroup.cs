#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class SortingGroup : Behaviour
    {
        public SortingGroup();

        public string sortingLayerName { get; set; }
        public int sortingLayerID { get; set; }
        public int sortingOrder { get; set; }

        [StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
        public static void UpdateAllSortingGroups();
    }
}
