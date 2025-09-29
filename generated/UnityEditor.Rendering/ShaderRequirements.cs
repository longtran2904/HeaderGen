#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Rendering
{
    [Flags]
    public enum ShaderRequirements
    {

        None = 0,
        BaseShaders = 1,
        Interpolators10 = 2,
        Interpolators32 = 4,
        MRT4 = 8,
        MRT8 = 16,
        Derivatives = 32,
        SampleLOD = 64,
        FragCoord = 128,
        FragClipDepth = 256,
        Interpolators15Integers = 512,
        Texture2DArray = 1024,
        Instancing = 2048,
        Geometry = 4096,
        CubeArray = 8192,
        Compute = 16384,
        RandomWrite = 32768,
        TessellationCompute = 65536,
        TessellationShaders = 131072,
        SparseTexelResident = 262144,
        FramebufferFetch = 524288,
        MSAATextureSamples = 1048576,
        SetRTArrayIndexFromAnyShader = 2097152
    }
}
