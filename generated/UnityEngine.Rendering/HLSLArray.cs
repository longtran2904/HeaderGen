#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Field)]
    public class HLSLArray : Attribute
    {

        public int arraySize;
        public Type elementType;

        public HLSLArray(int arraySize, Type elementType);
    }
}
