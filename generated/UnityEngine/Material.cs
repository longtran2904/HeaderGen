#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    [NativeHeader("Runtime/Shaders/Material.h")]
    public class Material : Object
    {
        public Material(Shader shader);
        [RequiredByNativeCode]
        public Material(Material source);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
        public Material(string contents);

        public Shader shader { get; set; }
        public Color color { get; set; }
        public Texture mainTexture { get; set; }
        public Vector2 mainTextureOffset { get; set; }
        public Vector2 mainTextureScale { get; set; }
        public int renderQueue { get; set; }
        public LocalKeyword[] enabledKeywords { get; set; }
        public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
        public bool doubleSidedGI { get; set; }
        [NativeProperty("EnableInstancingVariants")]
        public bool enableInstancing { get; set; }
        public int passCount { get; }
        public string[] shaderKeywords { get; set; }

        [Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", False)]
        public static Material Create(string scriptContents);
        [NativeName("HasPropertyFromScript")]
        public bool HasProperty(int nameID);
        public bool HasProperty(string name);
        public bool HasFloat(string name);
        public bool HasFloat(int nameID);
        public bool HasInt(string name);
        public bool HasInt(int nameID);
        public bool HasInteger(string name);
        public bool HasInteger(int nameID);
        public bool HasTexture(string name);
        public bool HasTexture(int nameID);
        public bool HasMatrix(string name);
        public bool HasMatrix(int nameID);
        public bool HasVector(string name);
        public bool HasVector(int nameID);
        public bool HasColor(string name);
        public bool HasColor(int nameID);
        public bool HasBuffer(string name);
        public bool HasBuffer(int nameID);
        public bool HasConstantBuffer(string name);
        public bool HasConstantBuffer(int nameID);
        public void EnableKeyword(string keyword);
        public void DisableKeyword(string keyword);
        public bool IsKeywordEnabled(string keyword);
        public void EnableKeyword(in LocalKeyword keyword);
        public void DisableKeyword(in LocalKeyword keyword);
        public void SetKeyword(in LocalKeyword keyword, bool value);
        public bool IsKeywordEnabled(in LocalKeyword keyword);
        [FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
        public void SetShaderPassEnabled(string passName, bool enabled);
        [FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = True)]
        public bool GetShaderPassEnabled(string passName);
        public string GetPassName(int pass);
        public int FindPass(string passName);
        public void SetOverrideTag(string tag, string val);
        public string GetTag(string tag, bool searchFallbacks, string defaultValue);
        public string GetTag(string tag, bool searchFallbacks);
        [FreeFunction("MaterialScripting::Lerp", HasExplicitThis = True)]
        [NativeThrows]
        public void Lerp(Material start, Material end, float t);
        [FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
        public bool SetPass(int pass);
        [FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
        public void CopyPropertiesFromMaterial(Material mat);
        [FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = True)]
        public void CopyMatchingPropertiesFromMaterial(Material mat);
        public int ComputeCRC();
        [FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = True)]
        public string[] GetTexturePropertyNames();
        [FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = True)]
        public int[] GetTexturePropertyNameIDs();
        public void GetTexturePropertyNames(List<string> outNames);
        public void GetTexturePropertyNameIDs(List<int> outNames);
        public void SetInt(string name, int value);
        public void SetInt(int nameID, int value);
        public void SetFloat(string name, float value);
        public void SetFloat(int nameID, float value);
        public void SetInteger(string name, int value);
        public void SetInteger(int nameID, int value);
        public void SetColor(string name, Color value);
        public void SetColor(int nameID, Color value);
        public void SetVector(string name, Vector4 value);
        public void SetVector(int nameID, Vector4 value);
        public void SetMatrix(string name, Matrix4x4 value);
        public void SetMatrix(int nameID, Matrix4x4 value);
        public void SetTexture(string name, Texture value);
        public void SetTexture(int nameID, Texture value);
        public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element);
        public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element);
        public void SetBuffer(string name, ComputeBuffer value);
        public void SetBuffer(int nameID, ComputeBuffer value);
        public void SetBuffer(string name, GraphicsBuffer value);
        public void SetBuffer(int nameID, GraphicsBuffer value);
        public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size);
        public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size);
        public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size);
        public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size);
        public void SetFloatArray(string name, List<float> values);
        public void SetFloatArray(int nameID, List<float> values);
        public void SetFloatArray(string name, float[] values);
        public void SetFloatArray(int nameID, float[] values);
        public void SetColorArray(string name, List<Color> values);
        public void SetColorArray(int nameID, List<Color> values);
        public void SetColorArray(string name, Color[] values);
        public void SetColorArray(int nameID, Color[] values);
        public void SetVectorArray(string name, List<Vector4> values);
        public void SetVectorArray(int nameID, List<Vector4> values);
        public void SetVectorArray(string name, Vector4[] values);
        public void SetVectorArray(int nameID, Vector4[] values);
        public void SetMatrixArray(string name, List<Matrix4x4> values);
        public void SetMatrixArray(int nameID, List<Matrix4x4> values);
        public void SetMatrixArray(string name, Matrix4x4[] values);
        public void SetMatrixArray(int nameID, Matrix4x4[] values);
        public int GetInt(string name);
        public int GetInt(int nameID);
        public float GetFloat(string name);
        public float GetFloat(int nameID);
        public int GetInteger(string name);
        public int GetInteger(int nameID);
        public Color GetColor(string name);
        public Color GetColor(int nameID);
        public Vector4 GetVector(string name);
        public Vector4 GetVector(int nameID);
        public Matrix4x4 GetMatrix(string name);
        public Matrix4x4 GetMatrix(int nameID);
        public Texture GetTexture(string name);
        public Texture GetTexture(int nameID);
        public float[] GetFloatArray(string name);
        public float[] GetFloatArray(int nameID);
        public Color[] GetColorArray(string name);
        public Color[] GetColorArray(int nameID);
        public Vector4[] GetVectorArray(string name);
        public Vector4[] GetVectorArray(int nameID);
        public Matrix4x4[] GetMatrixArray(string name);
        public Matrix4x4[] GetMatrixArray(int nameID);
        public void GetFloatArray(string name, List<float> values);
        public void GetFloatArray(int nameID, List<float> values);
        public void GetColorArray(string name, List<Color> values);
        public void GetColorArray(int nameID, List<Color> values);
        public void GetVectorArray(string name, List<Vector4> values);
        public void GetVectorArray(int nameID, List<Vector4> values);
        public void GetMatrixArray(string name, List<Matrix4x4> values);
        public void GetMatrixArray(int nameID, List<Matrix4x4> values);
        public void SetTextureOffset(string name, Vector2 value);
        public void SetTextureOffset(int nameID, Vector2 value);
        public void SetTextureScale(string name, Vector2 value);
        public void SetTextureScale(int nameID, Vector2 value);
        public Vector2 GetTextureOffset(string name);
        public Vector2 GetTextureOffset(int nameID);
        public Vector2 GetTextureScale(string name);
        public Vector2 GetTextureScale(int nameID);
    }
}
