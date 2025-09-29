#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class MinIntParameter : IntParameter
    {
        [NonSerialized]
        public int min;

        public MinIntParameter(int value, int min, bool overrideState = False);

        public override int value { get; set; }
    }
}
