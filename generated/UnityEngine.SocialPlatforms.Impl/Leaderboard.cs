#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms.Impl
{
    public class Leaderboard : ILeaderboard
    {
        public Leaderboard();

        public bool loading { get; }
        public string id { get; set; }
        public UserScope userScope { get; set; }
        public Range range { get; set; }
        public TimeScope timeScope { get; set; }
        public IScore localUserScore { get; }
        public uint maxRange { get; }
        public IScore[] scores { get; }
        public string title { get; }

        public void SetUserFilter(string[] userIDs);
        public override string ToString();
        public void LoadScores(Action<bool> callback);
        public void SetLocalUserScore(IScore score);
        public void SetMaxRange(uint maxRange);
        public void SetScores(IScore[] scores);
        public void SetTitle(string title);
        public string[] GetUserFilter();
    }
}
