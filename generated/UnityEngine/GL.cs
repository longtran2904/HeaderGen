#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    [NativeHeader("Runtime/Camera/CameraUtil.h")]
    [NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
    [StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
    public sealed class GL
    {

        public const int TRIANGLES = 4;
        public const int TRIANGLE_STRIP = 5;
        public const int QUADS = 7;
        public const int LINES = 1;
        public const int LINE_STRIP = 2;

        public GL();

        public static bool wireframe { get; set; }
        public static bool sRGBWrite { get; set; }
        [NativeProperty("UserBackfaceMode")]
        public static bool invertCulling { get; set; }
        public static Matrix4x4 modelview { get; set; }

        [NativeName("ImmediateVertex")]
        public static void Vertex3(float x, float y, float z);
        public static void Vertex(Vector3 v);
        [NativeName("ImmediateTexCoordAll")]
        public static void TexCoord3(float x, float y, float z);
        public static void TexCoord(Vector3 v);
        public static void TexCoord2(float x, float y);
        [NativeName("ImmediateTexCoord")]
        public static void MultiTexCoord3(int unit, float x, float y, float z);
        public static void MultiTexCoord(int unit, Vector3 v);
        public static void MultiTexCoord2(int unit, float x, float y);
        public static void Color(Color c);
        public static void Flush();
        public static void RenderTargetBarrier();
        [NativeName("SetWorldMatrix")]
        public static void MultMatrix(Matrix4x4 m);
        [NativeName("InsertCustomMarker")]
        [Obsolete("IssuePluginEvent(eventID) is deprecated. Use IssuePluginEvent(callback, eventID) instead.", False)]
        public static void IssuePluginEvent(int eventID);
        [NativeName("SetUserBackfaceMode")]
        [Obsolete("SetRevertBackfacing(revertBackFaces) is deprecated. Use invertCulling property instead.", False)]
        public static void SetRevertBackfacing(bool revertBackFaces);
        [FreeFunction("GLPushMatrixScript")]
        public static void PushMatrix();
        [FreeFunction("GLPopMatrixScript")]
        public static void PopMatrix();
        [FreeFunction("GLLoadIdentityScript")]
        public static void LoadIdentity();
        [FreeFunction("GLLoadOrthoScript")]
        public static void LoadOrtho();
        [FreeFunction("GLLoadPixelMatrixScript")]
        public static void LoadPixelMatrix();
        [FreeFunction("GLLoadProjectionMatrixScript")]
        public static void LoadProjectionMatrix(Matrix4x4 mat);
        [FreeFunction("GLInvalidateState")]
        public static void InvalidateState();
        [FreeFunction("GLGetGPUProjectionMatrix")]
        public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture);
        public static void LoadPixelMatrix(float left, float right, float bottom, float top);
        public static void IssuePluginEvent(nint callback, int eventID);
        [FreeFunction("GLBegin", ThrowsException = True)]
        public static void Begin(int mode);
        [FreeFunction("GLEnd")]
        public static void End();
        public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth);
        public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor);
        [FreeFunction("SetGLViewport")]
        public static void Viewport(Rect pixelRect);
        [FreeFunction("ClearWithSkybox")]
        public static void ClearWithSkybox(bool clearDepth, Camera camera);
    }
}
