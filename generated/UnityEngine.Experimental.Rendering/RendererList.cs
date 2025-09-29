#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    [Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
    public struct RendererList
    {
        public CullingResults cullingResult;
        public DrawingSettings drawSettings;
        public FilteringSettings filteringSettings;
        public RenderStateBlock? stateBlock;
        public static readonly RendererList nullRendererList;

        public bool isValid { get; }

        public static RendererList Create(in RendererListDesc desc);
    }
}
