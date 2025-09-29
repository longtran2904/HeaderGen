#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/ProfilerProperty.h")]
    [NativeHeader("Runtime/Interfaces/IUISystem.h")]
    public class ProfilerProperty : IDisposable
    {

        public ProfilerProperty();

        ~ProfilerProperty();

        [NativeMethod("FunctionName")]
        public string propertyName { get; }
        public bool HasChildren { get; }
        public bool onlyShowGPUSamples { get; set; }
        public int[] instanceIDs { get; }
        public int depth { get; }
        public string propertyPath { get; }
        public string frameFPS { get; }
        public string frameTime { get; }
        public string frameGpuTime { get; }
        public bool frameDataReady { get; }

        [NativeMethod("CleanupProperty")]
        public void Cleanup();
        [NativeMethod("GetNext")]
        public bool Next(bool enterChildren);
        public void SetRoot(int frame, int profilerSortColumn, int viewType);
        public void ResetToRoot();
        public void InitializeDetailProperty(ProfilerProperty source);
        public string GetTooltip(int column);
        [NativeMethod("GetProfilerColumn")]
        public string GetColumn(int column);
        [NativeMethod("GetProfilerColumnAsSingle")]
        public float GetColumnAsSingle(int colum);
        public AudioProfilerGroupInfo[] GetAudioProfilerGroupInfo();
        public AudioProfilerDSPInfo[] GetAudioProfilerDSPInfo();
        public AudioProfilerClipInfo[] GetAudioProfilerClipInfo();
        public string GetAudioProfilerNameByOffset(int offset);
        public UISystemProfilerInfo[] GetUISystemProfilerInfo();
        public string GetUISystemProfilerNameByOffset(int offset);
        public EventMarker[] GetUISystemEventMarkers();
        public string GetUISystemEventMarkerNameByOffset(int offset);
        public int[] GetUISystemBatchInstanceIDs();
        [NativeMethod("ReleaseTexture")]
        [StaticAccessor("GetIUISystem()", StaticAccessorType.Arrow)]
        public static void ReleaseUISystemProfilerRender(Texture2D t);
        public static Texture2D UISystemProfilerRender(int frameIndex, int renderDataIndex, int renderDataCount, bool renderOverdraw);
        public void Dispose();
    }
}
