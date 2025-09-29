#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class GridPalette : ScriptableObject
    {

        [SerializeField]
        public CellSizing cellSizing;

        public GridPalette();

        public TransparencySortMode transparencySortMode { get; set; }
        public Vector3 transparencySortAxis { get; set; }
        public enum CellSizing
        {

            Automatic = 0,
            Manual = 100
        }
    }
}
