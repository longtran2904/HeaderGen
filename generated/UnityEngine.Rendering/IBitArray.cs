#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public interface IBitArray
    {

        bool this[uint index] { get; set; }
        uint capacity { get; }
        bool allFalse { get; }
        bool allTrue { get; }
        string humanizedData { get; }

        IBitArray BitAnd(IBitArray other);
        IBitArray BitOr(IBitArray other);
        IBitArray BitNot();
    }
}
