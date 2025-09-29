#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
    [NativeHeader("Runtime/Shaders/RayTracingAccelerationStructure.h")]
    [NativeHeader("Runtime/Shaders/RayTracingShader.h")]
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    public sealed class RayTracingShader : Object
    {
        public float maxRecursionDepth { get; }

        [FreeFunction(Name = "RayTracingShaderScripting::SetFloat", HasExplicitThis = True)]
        public void SetFloat(int nameID, float val);
        [FreeFunction(Name = "RayTracingShaderScripting::SetInt", HasExplicitThis = True)]
        public void SetInt(int nameID, int val);
        [FreeFunction(Name = "RayTracingShaderScripting::SetVector", HasExplicitThis = True)]
        public void SetVector(int nameID, Vector4 val);
        [FreeFunction(Name = "RayTracingShaderScripting::SetMatrix", HasExplicitThis = True)]
        public void SetMatrix(int nameID, Matrix4x4 val);
        [FreeFunction(Name = "RayTracingShaderScripting::SetVectorArray", HasExplicitThis = True)]
        public void SetVectorArray(int nameID, Vector4[] values);
        [FreeFunction(Name = "RayTracingShaderScripting::SetMatrixArray", HasExplicitThis = True)]
        public void SetMatrixArray(int nameID, Matrix4x4[] values);
        [NativeMethod(Name = "RayTracingShaderScripting::SetTexture", IsFreeFunction = True, HasExplicitThis = True)]
        public void SetTexture(int nameID, [NotNull("ArgumentNullException")] Texture texture);
        [NativeMethod(Name = "RayTracingShaderScripting::SetBuffer", IsFreeFunction = True, HasExplicitThis = True)]
        public void SetBuffer(int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer);
        [NativeMethod(Name = "RayTracingShaderScripting::SetAccelerationStructure", IsFreeFunction = True, HasExplicitThis = True)]
        public void SetAccelerationStructure(int nameID, [NotNull("ArgumentNullException")] RayTracingAccelerationStructure accelerationStructure);
        public void SetShaderPass(string passName);
        [NativeMethod(Name = "RayTracingShaderScripting::SetTextureFromGlobal", IsFreeFunction = True, HasExplicitThis = True)]
        public void SetTextureFromGlobal(int nameID, int globalTextureNameID);
        [NativeName("DispatchRays")]
        public void Dispatch(string rayGenFunctionName, int width, int height, int depth, Camera camera = null);
        public void SetBuffer(int nameID, GraphicsBuffer buffer);
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
        public void SetTexture(string name, Texture texture);
        public void SetBuffer(string name, ComputeBuffer buffer);
        public void SetBuffer(string name, GraphicsBuffer buffer);
        public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size);
        public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size);
        public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size);
        public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size);
        public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure);
        public void SetTextureFromGlobal(string name, string globalTextureName);
    }
}
