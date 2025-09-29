#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    public class ProbeReferenceVolume
    {

        public Action<ExtraDataActionInput> retrieveExtraDataAction;

        public ProbeVolumeSHBands shBands { get; }
        public ProbeVolumeTextureMemoryBudget memoryBudget { get; }
        public static ProbeReferenceVolume instance { get; }
        public Color[] subdivisionDebugColors { get; }

        public void SetNumberOfCellsLoadedPerFrame(int numberOfCells);
        public void Initialize(in ProbeVolumeSystemParameters parameters);
        public void SetEnableStateFromSRP(bool srpEnablesPV);
        public void Cleanup();
        public int GetVideoMemoryCost();
        public void PerformPendingOperations(bool loadAllCells = False);
        public void SortPendingCells(Vector3 cameraPosition);
        public RuntimeResources GetRuntimeResources();
        public bool DataHasBeenLoaded();
        public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters);
        public void RenderDebug(Camera camera);
        public struct RuntimeResources
        {

            public ComputeBuffer index;
            public ComputeBuffer cellIndices;
            public Texture3D L0_L1rx;
            public Texture3D L1_G_ry;
            public Texture3D L1_B_rz;
            public Texture3D L2_0;
            public Texture3D L2_1;
            public Texture3D L2_2;
            public Texture3D L2_3;
        }
        public struct ExtraDataActionInput
        {
        }
    }
}
