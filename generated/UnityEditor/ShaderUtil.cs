#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.AssetImporters;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEditor
{
    [NativeHeader("Runtime/Shaders/GpuPrograms/GpuProgramManager.h")]
    [NativeHeader("Editor/Src/ShaderMenu.h")]
    [NativeHeader("Editor/Mono/ShaderUtil.bindings.h")]
    [NativeHeader("Editor/Mono/ShaderUtil.bindings.h")]
    [NativeHeader("Editor/Src/ShaderData.h")]
    public sealed class ShaderUtil
    {

        public ShaderUtil();

        public static bool hardwareSupportsRectRenderTexture { get; }
        public static bool anythingCompiling { get; }
        public static bool allowAsyncCompilation { get; set; }

        public static bool HasProceduralInstancing([NotNull("ArgumentNullException")] Shader s);
        public static int GetShaderMessageCount([NotNull("ArgumentNullException")] Shader s);
        public static ShaderMessage[] GetShaderMessages(Shader s);
        public static ShaderMessage[] GetShaderMessages([NotNull("ArgumentNullException")] Shader s, ShaderCompilerPlatform platform);
        public static void ClearShaderMessages([NotNull("ArgumentNullException")] Shader s);
        public static int GetComputeShaderMessageCount([NotNull("ArgumentNullException")] ComputeShader s);
        public static ShaderMessage[] GetComputeShaderMessages([NotNull("ArgumentNullException")] ComputeShader s);
        public static int GetRayTracingShaderMessageCount([NotNull("ArgumentNullException")] RayTracingShader s);
        public static ShaderMessage[] GetRayTracingShaderMessages([NotNull("ArgumentNullException")] RayTracingShader s);
        public static int GetRayGenerationShaderCount([NotNull("ArgumentNullException")] RayTracingShader s);
        public static string GetRayGenerationShaderName([NotNull("ArgumentNullException")] RayTracingShader s, int shaderIndex);
        public static int GetMissShaderCount([NotNull("ArgumentNullException")] RayTracingShader s);
        public static string GetMissShaderName([NotNull("ArgumentNullException")] RayTracingShader s, int shaderIndex);
        public static int GetMissShaderRayPayloadSize([NotNull("ArgumentNullException")] RayTracingShader s, int shaderIndex);
        public static int GetCallableShaderCount([NotNull("ArgumentNullException")] RayTracingShader s);
        public static string GetCallableShaderName([NotNull("ArgumentNullException")] RayTracingShader s, int shaderIndex);
        public static int GetCallableShaderParamSize([NotNull("ArgumentNullException")] RayTracingShader s, int shaderIndex);
        public static void ClearCachedData([NotNull("ArgumentNullException")] Shader s);
        public static Shader CreateShaderAsset(AssetImportContext context, string source, bool compileInitialShaderVariants);
        public static Shader CreateShaderAsset(string source);
        public static Shader CreateShaderAsset(string source, bool compileInitialShaderVariants);
        public static void UpdateShaderAsset(AssetImportContext context, [NotNull("ArgumentNullException")] Shader shader, [NotNull("ArgumentNullException")] string source, bool compileInitialShaderVariants);
        public static void UpdateShaderAsset(Shader shader, string source);
        public static void UpdateShaderAsset(Shader shader, string source, bool compileInitialShaderVariants);
        [FreeFunction("GetShaderNameRegistry().AddShader")]
        public static void RegisterShader([NotNull("NullExceptionObject")] Shader shader);
        [FreeFunction]
        public static ShaderInfo[] GetAllShaderInfo();
        [FreeFunction]
        public static ShaderInfo GetShaderInfo([NotNull("ArgumentNullException")] Shader shader);
        public static void SetAsyncCompilation([NotNull("ArgumentNullException")] CommandBuffer cmd, bool allow);
        public static void RestoreAsyncCompilation([NotNull("ArgumentNullException")] CommandBuffer cmd);
        public static bool IsPassCompiled([NotNull("ArgumentNullException")] Material material, int pass);
        public static void CompilePass([NotNull("ArgumentNullException")] Material material, int pass, bool forceSync = False);
        public static string GetCustomEditorForRenderPipeline(Shader shader, string renderPipelineType);
        public static string GetCustomEditorForRenderPipeline(Shader shader, Type renderPipelineType);
        public static string GetCurrentCustomEditor(Shader shader);
        public static BuiltinShaderDefine[] GetShaderPlatformKeywordsForBuildTarget(ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget, GraphicsTier tier);
        public static BuiltinShaderDefine[] GetShaderPlatformKeywordsForBuildTarget(ShaderCompilerPlatform shaderCompilerPlatform, BuildTarget buildTarget);
        public static LocalKeyword[] GetPassKeywords(Shader s, in PassIdentifier passIdentifier);
        public static LocalKeyword[] GetPassKeywords(Shader s, in PassIdentifier passIdentifier, ShaderType shaderType);
        public static LocalKeyword[] GetPassKeywords(Shader s, in PassIdentifier passIdentifier, ShaderType shaderType, ShaderCompilerPlatform shaderCompilerPlatform);
        public static bool PassHasKeyword(Shader s, in PassIdentifier passIdentifier, in LocalKeyword keyword);
        public static bool PassHasKeyword(Shader s, in PassIdentifier passIdentifier, in LocalKeyword keyword, ShaderType shaderType);
        public static bool PassHasKeyword(Shader s, in PassIdentifier passIdentifier, in LocalKeyword keyword, ShaderType shaderType, ShaderCompilerPlatform shaderCompilerPlatform);
        [NativeName("ClearShaderMessages")]
        [Obsolete("ClearShaderErrors has been deprecated. Use ClearShaderMessages instead (UnityUpgradable) -> ClearShaderMessages(*)")]
        public static void ClearShaderErrors([NotNull("ArgumentNullException")] Shader s);
        public static int GetPropertyCount(Shader s);
        public static string GetPropertyName(Shader s, int propertyIdx);
        public static ShaderPropertyType GetPropertyType(Shader s, int propertyIdx);
        public static string GetPropertyDescription(Shader s, int propertyIdx);
        public static float GetRangeLimits(Shader s, int propertyIdx, int defminmax);
        public static TextureDimension GetTexDim(Shader s, int propertyIdx);
        public static bool IsShaderPropertyHidden(Shader s, int propertyIdx);
        public static bool IsShaderPropertyNonModifiableTexureProperty(Shader s, int propertyIdx);
        public static ShaderData GetShaderData(Shader shader);
        public static bool ShaderHasError(Shader shader);
        public static bool ShaderHasWarnings(Shader shader);
        [Obsolete("Use UnityEngine.Rendering.TextureDimension instead.")]
        public enum ShaderPropertyTexDim
        {

            TexDimNone = 0,
            TexDim2D = 2,
            TexDim3D = 3,
            TexDimCUBE = 4,
            TexDimAny = 6
        }
        public enum ShaderPropertyType
        {

            Color = 0,
            Vector = 1,
            Float = 2,
            Range = 3,
            TexEnv = 4,
            Int = 5
        }
    }
}
