#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms
{
    public class Local : ISocialPlatform
    {
        public Local();

        public ILocalUser localUser { get; }

        public void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback);
        public void ReportProgress(string id, double progress, Action<bool> callback);
        public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);
        public void LoadAchievements(Action<IAchievement[]> callback);
        public void ReportScore(long score, string board, Action<bool> callback);
        public void LoadScores(string leaderboardID, Action<IScore[]> callback);
        public void ShowAchievementsUI();
        public void ShowLeaderboardUI();
        public ILeaderboard CreateLeaderboard();
        public IAchievement CreateAchievement();
    }
}
