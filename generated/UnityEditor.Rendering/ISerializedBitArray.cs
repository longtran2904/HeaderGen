#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public interface ISerializedBitArray
    {
        uint capacity { get; }

        bool GetBitAt(uint bitIndex);
        void SetBitAt(uint bitIndex, bool value);
        bool HasBitMultipleDifferentValue(uint bitIndex);
    }
}
