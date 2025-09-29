#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
    [UsedByNativeCode]
    public sealed class CustomRenderTexture : RenderTexture
    {
        public CustomRenderTexture(int width, int height, RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite);
        [ExcludeFromDocs]
        public CustomRenderTexture(int width, int height, RenderTextureFormat format);
        [ExcludeFromDocs]
        public CustomRenderTexture(int width, int height);
        [ExcludeFromDocs]
        public CustomRenderTexture(int width, int height, [DefaultValue("DefaultFormat.LDR")] DefaultFormat defaultFormat);
        [ExcludeFromDocs]
        public CustomRenderTexture(int width, int height, GraphicsFormat format);

        public Material material { get; set; }
        public Material initializationMaterial { get; set; }
        public Texture initializationTexture { get; set; }
        public CustomRenderTextureInitializationSource initializationSource { get; set; }
        public Color initializationColor { get; set; }
        public CustomRenderTextureUpdateMode updateMode { get; set; }
        public CustomRenderTextureUpdateMode initializationMode { get; set; }
        public CustomRenderTextureUpdateZoneSpace updateZoneSpace { get; set; }
        public int shaderPass { get; set; }
        public uint cubemapFaceMask { get; set; }
        public bool doubleBuffered { get; set; }
        public bool wrapUpdateZones { get; set; }
        public float updatePeriod { get; set; }

        public void Update(int count);
        public void Update();
        public void Initialize();
        public void ClearUpdateZones();
        public void GetUpdateZones(List<CustomRenderTextureUpdateZone> updateZones);
        [FreeFunction(Name = "CustomRenderTextureScripting::GetDoubleBufferRenderTexture", HasExplicitThis = True)]
        public RenderTexture GetDoubleBufferRenderTexture();
        public void EnsureDoubleBufferConsistency();
        public void SetUpdateZones(CustomRenderTextureUpdateZone[] updateZones);
    }
}
