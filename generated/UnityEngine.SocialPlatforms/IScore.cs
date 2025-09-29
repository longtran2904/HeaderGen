#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms
{
    public interface IScore
    {
        string leaderboardID { get; set; }
        long value { get; set; }
        DateTime date { get; }
        string formattedValue { get; }
        string userID { get; }
        int rank { get; }

        void ReportScore(Action<bool> callback);
    }
}
