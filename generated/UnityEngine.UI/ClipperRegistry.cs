#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    public class ClipperRegistry
    {

        protected ClipperRegistry();

        public static ClipperRegistry instance { get; }

        public void Cull();
        public static void Register(IClipper c);
        public static void Unregister(IClipper c);
        public static void Disable(IClipper c);
    }
}
