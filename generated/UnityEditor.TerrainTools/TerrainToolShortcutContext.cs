#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.ShortcutManagement;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public class TerrainToolShortcutContext : IShortcutToolContext
    {
        public void SelectPaintTool<T>() where T : TerrainPaintTool<T>;
    }
}
