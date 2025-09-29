#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

namespace UnityEditor.Build
{
    public interface IPreprocessComputeShaders : IOrderedCallback
    {

        void OnProcessComputeShader(ComputeShader shader, string kernelName, IList<ShaderCompilerData> data);
    }
}
