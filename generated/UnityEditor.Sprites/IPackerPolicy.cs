#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Sprites
{
    public interface IPackerPolicy
    {
        bool AllowSequentialPacking { get; }

        void OnGroupAtlases(BuildTarget target, PackerJob job, int[] textureImporterInstanceIDs);
        int GetVersion();
    }
}
