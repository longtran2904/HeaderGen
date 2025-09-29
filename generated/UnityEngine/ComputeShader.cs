#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Shaders/ComputeShader.h")]
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    [UsedByNativeCode]
    public sealed class ComputeShader : Object
    {
        public LocalKeywordSpace keywordSpace { get; }
        public string[] shaderKeywords { get; set; }
        public LocalKeyword[] enabledKeywords { get; set; }

        [NativeMethod(Name = "ComputeShaderScripting::FindKernel", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
        [RequiredByNativeCode]
        public int FindKernel(string name);
        [FreeFunction(Name = "ComputeShaderScripting::HasKernel", HasExplicitThis = True)]
        public bool HasKernel(string name);
        [FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = True)]
        public void SetFloat(int nameID, float val);
        [FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
        public void SetInt(int nameID, int val);
        [FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = True)]
        public void SetVector(int nameID, Vector4 val);
        [FreeFunction(Name = "ComputeShaderScripting::SetValue<Matrix4x4f>", HasExplicitThis = True)]
        public void SetMatrix(int nameID, Matrix4x4 val);
        [FreeFunction(Name = "ComputeShaderScripting::SetArray<Vector4f>", HasExplicitThis = True)]
        public void SetVectorArray(int nameID, Vector4[] values);
        [FreeFunction(Name = "ComputeShaderScripting::SetArray<Matrix4x4f>", HasExplicitThis = True)]
        public void SetMatrixArray(int nameID, Matrix4x4[] values);
        [NativeMethod(Name = "ComputeShaderScripting::SetTexture", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
        public void SetTexture(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] Texture texture, int mipLevel);
        [NativeMethod(Name = "ComputeShaderScripting::SetTextureFromGlobal", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
        public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID);
        public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer);
        public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer);
        [NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
        public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z);
        [NativeName("DispatchComputeShader")]
        public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        [FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
        public void EnableKeyword(string keyword);
        [FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
        public void DisableKeyword(string keyword);
        [FreeFunction("ComputeShaderScripting::IsKeywordEnabled", HasExplicitThis = True)]
        public bool IsKeywordEnabled(string keyword);
        public void EnableKeyword(in LocalKeyword keyword);
        public void DisableKeyword(in LocalKeyword keyword);
        public void SetKeyword(in LocalKeyword keyword, bool value);
        public bool IsKeywordEnabled(in LocalKeyword keyword);
        [FreeFunction("ComputeShaderScripting::IsSupported", HasExplicitThis = True)]
        public bool IsSupported(int kernelIndex);
        public void SetFloat(string name, float val);
        public void SetInt(string name, int val);
        public void SetVector(string name, Vector4 val);
        public void SetMatrix(string name, Matrix4x4 val);
        public void SetVectorArray(string name, Vector4[] values);
        public void SetMatrixArray(string name, Matrix4x4[] values);
        public void SetFloats(string name, params float[] values);
        public void SetFloats(int nameID, params float[] values);
        public void SetInts(string name, params int[] values);
        public void SetInts(int nameID, params int[] values);
        public void SetBool(string name, bool val);
        public void SetBool(int nameID, bool val);
        public void SetTexture(int kernelIndex, int nameID, Texture texture);
        public void SetTexture(int kernelIndex, string name, Texture texture);
        public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel);
        public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, RenderTextureSubElement element);
        public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, RenderTextureSubElement element);
        public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName);
        public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer);
        public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer);
        public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size);
        public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size);
        public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size);
        public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size);
        public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, [DefaultValue("0")] uint argsOffset);
        [ExcludeFromDocs]
        public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer);
        public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, [DefaultValue("0")] uint argsOffset);
        [ExcludeFromDocs]
        public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer);
    }
}
