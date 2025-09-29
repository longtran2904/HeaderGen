#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor
{
    public class ShaderData
    {

        public int ActiveSubshaderIndex { get; }
        public int SubshaderCount { get; }
        public int SerializedSubshaderCount { get; }
        public Shader SourceShader { get; }
        public Subshader ActiveSubshader { get; }

        public Subshader GetSubshader(int index);
        public Subshader GetSerializedSubshader(int index);
        public class Subshader
        {

            public int PassCount { get; }
            public int LevelOfDetail { get; }

            public ShaderTagId FindTagValue(ShaderTagId tagName);
            public Pass GetPass(int passIndex);
        }
        public class Pass
        {

            public string SourceCode { get; }
            public string Name { get; }

            public ShaderTagId FindTagValue(ShaderTagId tagName);
            public bool HasShaderStage(ShaderType shaderType);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, bool forExternalTool);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, GraphicsTier tier);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, GraphicsTier tier, bool forExternalTool);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords, bool forExternalTool);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords, GraphicsTier tier);
            public VariantCompileInfo CompileVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords, GraphicsTier tier, bool forExternalTool);
            public PreprocessedVariant PreprocessVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, bool stripLineDirectives);
            public PreprocessedVariant PreprocessVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, GraphicsTier tier, bool stripLineDirectives);
            public PreprocessedVariant PreprocessVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords, bool stripLineDirectives);
            public PreprocessedVariant PreprocessVariant(ShaderType shaderType, string[] keywords, ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, BuiltinShaderDefine[] platformKeywords, GraphicsTier tier, bool stripLineDirectives);
        }
        public struct PreprocessedVariant
        {

            public bool Success { get; }
            public ShaderMessage[] Messages { get; }
            public string PreprocessedCode { get; }
        }
        public struct VariantCompileInfo
        {

            public bool Success { get; }
            public ShaderMessage[] Messages { get; }
            public byte[] ShaderData { get; }
            public VertexAttribute[] Attributes { get; }
            public ConstantBufferInfo[] ConstantBuffers { get; }
            public TextureBindingInfo[] TextureBindings { get; }
        }
        public struct ConstantBufferInfo
        {

            public string Name { get; }
            public int Size { get; }
            public ConstantInfo[] Fields { get; }
        }
        public struct ConstantInfo
        {

            public string Name { get; }
            public int Index { get; }
            public ShaderConstantType ConstantType { get; }
            public ShaderParamType DataType { get; }
            public int Rows { get; }
            public int Columns { get; }
            public int ArraySize { get; }
            public int StructSize { get; }
            public ConstantInfo[] StructFields { get; }
        }
        public struct TextureBindingInfo
        {

            public string Name { get; }
            public int Index { get; }
            public int SamplerIndex { get; }
            public bool Multisampled { get; }
            public int ArraySize { get; }
            public TextureDimension Dim { get; }
        }
    }
}
