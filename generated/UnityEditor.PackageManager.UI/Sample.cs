#region UnityEditor.PackageManagerUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.PackageManagerUIModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.PackageManager.UI
{
    public struct Sample
    {

        public string displayName { get; }
        public string description { get; }
        public string resolvedPath { get; }
        public string importPath { get; }
        public bool interactiveImport { get; }
        public bool isImported { get; }

        public static IEnumerable<Sample> FindByPackage(string packageName, string packageVersion);
        public bool Import(ImportOptions options = ImportOptions.None);
        [Flags]
        public enum ImportOptions
        {

            None = 0,
            OverridePreviousImports = 1,
            HideImportWindow = 2
        }
    }
}
