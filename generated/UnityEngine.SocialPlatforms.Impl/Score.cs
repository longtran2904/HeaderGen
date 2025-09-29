#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms.Impl
{
    public class Score : IScore
    {
        public Score();
        public Score(string leaderboardID, long value);
        public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank);

        public string leaderboardID { get; set; }
        public long value { get; set; }
        public DateTime date { get; }
        public string formattedValue { get; }
        public string userID { get; }
        public int rank { get; }

        public override string ToString();
        public void ReportScore(Action<bool> callback);
        public void SetDate(DateTime date);
        public void SetFormattedValue(string value);
        public void SetUserID(string userID);
        public void SetRank(int rank);
    }
}
