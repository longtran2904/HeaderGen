#region Unity.Recorder.Base, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Base.dll
#endregion

using System;

namespace Unity.Media
{
    public class RefHandle<T> : IDisposable where T : class
    {
        public RefHandle();
        public RefHandle(T target);

        ~RefHandle();

        public bool IsCreated { get; }
        public T Target { get; set; }

        public void Dispose();
        public void Dispose(bool disposing);
    }
}
