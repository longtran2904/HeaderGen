#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;

namespace TMPro
{
    public class FastAction<A, B>
    {

        public FastAction();

        public void Add(Action<A, B> rhs);
        public void Remove(Action<A, B> rhs);
        public void Call(A a, B b);
    }
}
