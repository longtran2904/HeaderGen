#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor>
    {
        public AttachmentDescriptor(GraphicsFormat format);
        public AttachmentDescriptor(RenderTextureFormat format);
        public AttachmentDescriptor(RenderTextureFormat format, RenderTargetIdentifier target, bool loadExistingContents = False, bool storeResults = False, bool resolve = False);

        public RenderBufferLoadAction loadAction { get; set; }
        public RenderBufferStoreAction storeAction { get; set; }
        public GraphicsFormat graphicsFormat { get; set; }
        public RenderTextureFormat format { get; set; }
        public RenderTargetIdentifier loadStoreTarget { get; set; }
        public RenderTargetIdentifier resolveTarget { get; set; }
        public Color clearColor { get; set; }
        public float clearDepth { get; set; }
        public uint clearStencil { get; set; }

        public void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
        public void ConfigureResolveTarget(RenderTargetIdentifier target);
        public void ConfigureClear(Color clearColor, float clearDepth = 1, uint clearStencil = 0);
        public bool Equals(AttachmentDescriptor other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(AttachmentDescriptor left, AttachmentDescriptor right);
        public static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right);
    }
}
