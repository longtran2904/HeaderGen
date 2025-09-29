#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace UnityEditorInternal
{
    public class GenerateIconsWithMipLevels
    {

        public GenerateIconsWithMipLevels();

        public static void GenerateAllIconsWithMipLevels();
        public static bool VerifyIconPath(string assetPath, bool logError);
        public static void GenerateSelectedIconsWithMips();
        public static void GenerateIconWithMipLevels(string assetPath, Dictionary<int, Texture2D> mipTextures, FileInfo fileInfo);
        public static int MipLevelForAssetPath(string assetPath, string separator);
    }
}
