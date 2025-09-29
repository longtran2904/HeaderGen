#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public static class CameraCaptureBridge
    {

        public static bool enabled { get; set; }

        public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera);
        public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action);
        public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action);
    }
}
