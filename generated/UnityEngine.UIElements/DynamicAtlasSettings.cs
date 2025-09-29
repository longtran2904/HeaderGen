#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class DynamicAtlasSettings
    {

        public DynamicAtlasSettings();

        public int minAtlasSize { get; set; }
        public int maxAtlasSize { get; set; }
        public int maxSubTextureSize { get; set; }
        public DynamicAtlasFilters activeFilters { get; set; }
        public static DynamicAtlasFilters defaultFilters { get; }
        public DynamicAtlasCustomFilter customFilter { get; set; }
        public static DynamicAtlasSettings defaults { get; }
    }
}
