#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

namespace UnityEngine.Timeline
{
    public abstract class Marker : ScriptableObject, IMarker
    {

        protected Marker();

        public TrackAsset parent { get; }
        public double time { get; set; }

        public virtual void OnInitialize(TrackAsset aPent);
    }
}
