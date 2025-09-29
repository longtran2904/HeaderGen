#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    [UsedByNativeCode]
    public struct TakeInfo
    {
        public string name;
        public string defaultClipName;
        public float startTime;
        public float stopTime;
        public float bakeStartTime;
        public float bakeStopTime;
        public float sampleRate;
    }
}
