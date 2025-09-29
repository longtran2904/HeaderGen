#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("AudioScriptingClasses.h")]
    [NativeHeader("Runtime/Video/ScriptBindings/WebCamTexture.bindings.h")]
    [NativeHeader("Runtime/Video/BaseWebCamTexture.h")]
    public sealed class WebCamTexture : Texture
    {

        public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS);
        public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight);
        public WebCamTexture(string deviceName);
        public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS);
        public WebCamTexture(int requestedWidth, int requestedHeight);
        public WebCamTexture();

        public static WebCamDevice[] devices { get; }
        public bool isPlaying { get; }
        [NativeName("Device")]
        public string deviceName { get; set; }
        public float requestedFPS { get; set; }
        public int requestedWidth { get; set; }
        public int requestedHeight { get; set; }
        public int videoRotationAngle { get; }
        public bool videoVerticallyMirrored { get; }
        public bool didUpdateThisFrame { get; }
        public Vector2? autoFocusPoint { get; set; }
        public bool isDepth { get; }

        public void Play();
        public void Pause();
        public void Stop();
        [FreeFunction("WebCamTextureBindings::Internal_GetPixel", HasExplicitThis = True)]
        public Color GetPixel(int x, int y);
        public Color[] GetPixels();
        [FreeFunction("WebCamTextureBindings::Internal_GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        [ExcludeFromDocs]
        public Color32[] GetPixels32();
        [FreeFunction("WebCamTextureBindings::Internal_GetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public Color32[] GetPixels32([DefaultValue("null")][Unmarshalled] Color32[] colors);
    }
}
