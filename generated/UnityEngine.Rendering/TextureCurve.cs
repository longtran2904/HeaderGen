#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public class TextureCurve : IDisposable
    {
        public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds);
        public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds);

        ~TextureCurve();

        public Keyframe this[int index] { get; }
        public int length { get; }

        [Obsolete("Please use Release() instead.")]
        public void Dispose();
        public void Release();
        public void SetDirty();
        public Texture2D GetTexture();
        public float Evaluate(float time);
        public int AddKey(float time, float value);
        public int MoveKey(int index, in Keyframe key);
        public void RemoveKey(int index);
        public void SmoothTangents(int index, float weight);
    }
}
