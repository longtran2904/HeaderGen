#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/SketchUpEditor/SketchUpImporter.h")]
    public sealed class SketchUpImporter : ModelImporter
    {
        public SketchUpImporter();

        public double latitude { get; }
        public double longitude { get; }
        public double northCorrection { get; }

        public SketchUpImportScene[] GetScenes();
        public SketchUpImportCamera GetDefaultCamera();
    }
}
