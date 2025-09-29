#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    [NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
    [NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
    [NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
    [NativeHeader("Runtime/Shaders/ComputeShader.h")]
    [NativeHeader("Runtime/Misc/ResourceManager.h")]
    [NativeHeader("Runtime/Shaders/Shader.h")]
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    public sealed class Shader : Object
    {
        [Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", False)]
        public static ShaderHardwareTier globalShaderHardwareTier { get; set; }
        [NativeProperty("MaxChunksRuntimeOverride")]
        public static int maximumChunksOverride { get; set; }
        [NativeProperty("MaximumShaderLOD")]
        public int maximumLOD { get; set; }
        [NativeProperty("GlobalMaximumShaderLOD")]
        public static int globalMaximumLOD { get; set; }
        public bool isSupported { get; }
        public static string globalRenderPipeline { get; set; }
        public static GlobalKeyword[] enabledGlobalKeywords { get; }
        public static GlobalKeyword[] globalKeywords { get; }
        public LocalKeywordSpace keywordSpace { get; }
        public int renderQueue { get; }
        public int passCount { get; }
        public int subshaderCount { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("SetGlobalTexGenMode is not supported anymore. Use programmable shaders to achieve the same effect.", True)]
        public static void SetGlobalTexGenMode(string propertyName, TexGenMode mode);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("SetGlobalTextureMatrixName is not supported anymore. Use programmable shaders to achieve the same effect.", True)]
        public static void SetGlobalTextureMatrixName(string propertyName, string matrixName);
        public static Shader Find(string name);
        [FreeFunction("ShaderScripting::EnableKeyword")]
        public static void EnableKeyword(string keyword);
        [FreeFunction("ShaderScripting::DisableKeyword")]
        public static void DisableKeyword(string keyword);
        [FreeFunction("ShaderScripting::IsKeywordEnabled")]
        public static bool IsKeywordEnabled(string keyword);
        public static void EnableKeyword(in GlobalKeyword keyword);
        public static void DisableKeyword(in GlobalKeyword keyword);
        public static void SetKeyword(in GlobalKeyword keyword, bool value);
        public static bool IsKeywordEnabled(in GlobalKeyword keyword);
        [FreeFunction]
        public static void WarmupAllShaders();
        [FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
        public static int PropertyToID(string name);
        public Shader GetDependency(string name);
        [FreeFunction(Name = "ShaderScripting::GetPassCountInSubshader", HasExplicitThis = True)]
        public int GetPassCountInSubshader(int subshaderIndex);
        public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName);
        public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName);
        public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName);
        public static void SetGlobalInt(string name, int value);
        public static void SetGlobalInt(int nameID, int value);
        public static void SetGlobalFloat(string name, float value);
        public static void SetGlobalFloat(int nameID, float value);
        public static void SetGlobalInteger(string name, int value);
        public static void SetGlobalInteger(int nameID, int value);
        public static void SetGlobalVector(string name, Vector4 value);
        public static void SetGlobalVector(int nameID, Vector4 value);
        public static void SetGlobalColor(string name, Color value);
        public static void SetGlobalColor(int nameID, Color value);
        public static void SetGlobalMatrix(string name, Matrix4x4 value);
        public static void SetGlobalMatrix(int nameID, Matrix4x4 value);
        public static void SetGlobalTexture(string name, Texture value);
        public static void SetGlobalTexture(int nameID, Texture value);
        public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element);
        public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element);
        public static void SetGlobalBuffer(string name, ComputeBuffer value);
        public static void SetGlobalBuffer(int nameID, ComputeBuffer value);
        public static void SetGlobalBuffer(string name, GraphicsBuffer value);
        public static void SetGlobalBuffer(int nameID, GraphicsBuffer value);
        public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size);
        public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size);
        public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size);
        public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size);
        public static void SetGlobalFloatArray(string name, List<float> values);
        public static void SetGlobalFloatArray(int nameID, List<float> values);
        public static void SetGlobalFloatArray(string name, float[] values);
        public static void SetGlobalFloatArray(int nameID, float[] values);
        public static void SetGlobalVectorArray(string name, List<Vector4> values);
        public static void SetGlobalVectorArray(int nameID, List<Vector4> values);
        public static void SetGlobalVectorArray(string name, Vector4[] values);
        public static void SetGlobalVectorArray(int nameID, Vector4[] values);
        public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values);
        public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values);
        public static void SetGlobalMatrixArray(string name, Matrix4x4[] values);
        public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values);
        public static int GetGlobalInt(string name);
        public static int GetGlobalInt(int nameID);
        public static float GetGlobalFloat(string name);
        public static float GetGlobalFloat(int nameID);
        public static int GetGlobalInteger(string name);
        public static int GetGlobalInteger(int nameID);
        public static Vector4 GetGlobalVector(string name);
        public static Vector4 GetGlobalVector(int nameID);
        public static Color GetGlobalColor(string name);
        public static Color GetGlobalColor(int nameID);
        public static Matrix4x4 GetGlobalMatrix(string name);
        public static Matrix4x4 GetGlobalMatrix(int nameID);
        public static Texture GetGlobalTexture(string name);
        public static Texture GetGlobalTexture(int nameID);
        public static float[] GetGlobalFloatArray(string name);
        public static float[] GetGlobalFloatArray(int nameID);
        public static Vector4[] GetGlobalVectorArray(string name);
        public static Vector4[] GetGlobalVectorArray(int nameID);
        public static Matrix4x4[] GetGlobalMatrixArray(string name);
        public static Matrix4x4[] GetGlobalMatrixArray(int nameID);
        public static void GetGlobalFloatArray(string name, List<float> values);
        public static void GetGlobalFloatArray(int nameID, List<float> values);
        public static void GetGlobalVectorArray(string name, List<Vector4> values);
        public static void GetGlobalVectorArray(int nameID, List<Vector4> values);
        public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values);
        public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values);
        public int GetPropertyCount();
        public int FindPropertyIndex(string propertyName);
        public string GetPropertyName(int propertyIndex);
        public int GetPropertyNameId(int propertyIndex);
        public ShaderPropertyType GetPropertyType(int propertyIndex);
        public string GetPropertyDescription(int propertyIndex);
        public ShaderPropertyFlags GetPropertyFlags(int propertyIndex);
        public string[] GetPropertyAttributes(int propertyIndex);
        public float GetPropertyDefaultFloatValue(int propertyIndex);
        public Vector4 GetPropertyDefaultVectorValue(int propertyIndex);
        public Vector2 GetPropertyRangeLimits(int propertyIndex);
        public TextureDimension GetPropertyTextureDimension(int propertyIndex);
        public string GetPropertyTextureDefaultName(int propertyIndex);
        public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex);
    }
}
