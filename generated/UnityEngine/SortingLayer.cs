#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/BaseClasses/TagManager.h")]
    public struct SortingLayer
    {
        public int id { get; }
        public string name { get; }
        public int value { get; }
        public static SortingLayer[] layers { get; }

        [FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
        public static int GetLayerValueFromID(int id);
        [FreeFunction("GetTagManager().GetSortingLayerValueFromName")]
        public static int GetLayerValueFromName(string name);
        [FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
        public static int NameToID(string name);
        [FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
        public static string IDToName(int id);
        [FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
        public static bool IsValid(int id);
    }
}
