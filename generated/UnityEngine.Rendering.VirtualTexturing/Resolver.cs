#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/Public/VirtualTextureResolver.h")]
    public class Resolver : IDisposable
    {
        public Resolver();

        ~Resolver();

        public int CurrentWidth { get; }
        public int CurrentHeight { get; }

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public void UpdateSize(int width, int height);
        public void Process(CommandBuffer cmd, RenderTargetIdentifier rt);
        public void Process(CommandBuffer cmd, RenderTargetIdentifier rt, int x, int width, int y, int height, int mip, int slice);
    }
}
