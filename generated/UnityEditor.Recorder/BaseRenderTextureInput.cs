#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Recorder
{
    public abstract class BaseRenderTextureInput : RecorderInput
    {
        protected BaseRenderTextureInput();

        protected internal RenderTexture OutputRenderTexture { get; set; }
        protected internal Texture2D ReadbackTexture { get; set; }
        public int OutputWidth { get; protected set; }
        public int OutputHeight { get; protected set; }

        protected void ReleaseBuffer();
        protected override void Dispose(bool disposing);
    }
}
