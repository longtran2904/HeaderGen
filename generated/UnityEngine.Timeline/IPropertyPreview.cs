#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public interface IPropertyPreview
    {

        void GatherProperties(PlayableDirector director, IPropertyCollector driver);
    }
}
