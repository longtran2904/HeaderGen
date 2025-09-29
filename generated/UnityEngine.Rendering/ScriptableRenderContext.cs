#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering
{
    [NativeHeader("Modules/UI/Canvas.h")]
    [NativeHeader("Modules/UI/CanvasManager.h")]
    [NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
    [NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
    [NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
    [NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
    public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
    {
        [FreeFunction("UI::GetCanvasManager().EmitWorldGeometryForSceneView")]
        public static void EmitWorldGeometryForSceneView(Camera cullingCamera);
        [FreeFunction("UI::GetCanvasManager().EmitGeometryForCamera")]
        public static void EmitGeometryForCamera(Camera camera);
        public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1);
        public ScopedRenderPass BeginScopedRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1);
        public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly);
        public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = False);
        public void BeginSubPass(NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly);
        public void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = False);
        public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly);
        public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = False);
        public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly);
        public ScopedSubPass BeginScopedSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = False);
        public void EndSubPass();
        public void EndRenderPass();
        public void Submit();
        public bool SubmitForRenderPassValidation();
        public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings);
        public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock);
        public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, NativeArray<ShaderTagId> renderTypes, NativeArray<RenderStateBlock> stateBlocks);
        public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks);
        public void DrawShadows(ref ShadowDrawingSettings settings);
        public void ExecuteCommandBuffer(CommandBuffer commandBuffer);
        public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType);
        public void SetupCameraProperties(Camera camera, bool stereoSetup = False);
        public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye);
        public void StereoEndRender(Camera camera);
        public void StereoEndRender(Camera camera, int eye);
        public void StereoEndRender(Camera camera, int eye, bool isFinalPass);
        public void StartMultiEye(Camera camera);
        public void StartMultiEye(Camera camera, int eye);
        public void StopMultiEye(Camera camera);
        public void DrawSkybox(Camera camera);
        public void InvokeOnRenderObjectCallback();
        public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset);
        public void DrawWireOverlay(Camera camera);
        public void DrawUIOverlay(Camera camera);
        public CullingResults Cull(ref ScriptableCullingParameters parameters);
        public bool Equals(ScriptableRenderContext other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public RendererList CreateRendererList(RendererListDesc desc);
        public void PrepareRendererListsAsync(List<RendererList> rendererLists);
        public RendererListStatus QueryRendererListStatus(RendererList rendererList);

        public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right);
        public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right);
    }
}
