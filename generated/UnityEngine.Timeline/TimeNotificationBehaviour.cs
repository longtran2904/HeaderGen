#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class TimeNotificationBehaviour : PlayableBehaviour
    {
        public TimeNotificationBehaviour();

        public Playable timeSource { set; }

        public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode);
        public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive);
        public override void OnGraphStart(Playable playable);
        public override void OnBehaviourPause(Playable playable, FrameData info);
        public override void PrepareFrame(Playable playable, FrameData info);
    }
}
