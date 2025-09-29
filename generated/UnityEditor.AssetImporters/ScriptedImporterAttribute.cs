#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [AttributeUsage(AttributeTargets.Class, Inherited = False)]
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    public class ScriptedImporterAttribute : Attribute
    {

        [Obsolete("Use overrideFileExtensions instead to specify this importer is an override for those file extensions")]
        public bool AutoSelect;
        public bool AllowCaching;

        public ScriptedImporterAttribute(int version, string ext);
        public ScriptedImporterAttribute(int version, string ext, int importQueueOffset);
        public ScriptedImporterAttribute(int version, string[] exts);
        public ScriptedImporterAttribute(int version, string[] exts, string[] overrideExts);
        public ScriptedImporterAttribute(int version, string[] exts, int importQueueOffset);
        public ScriptedImporterAttribute(int version, string[] exts, string[] overrideExts, int importQueueOffset);

        public int version { get; }
        public int importQueuePriority { get; }
        public string[] fileExtensions { get; }
        public string[] overrideFileExtensions { get; }
    }
}
