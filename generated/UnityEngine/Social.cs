#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
    public static class Social
    {
        public static ISocialPlatform Active { get; set; }
        public static ILocalUser localUser { get; }

        public static void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback);
        public static void ReportProgress(string achievementID, double progress, Action<bool> callback);
        public static void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);
        public static void LoadAchievements(Action<IAchievement[]> callback);
        public static void ReportScore(long score, string board, Action<bool> callback);
        public static void LoadScores(string leaderboardID, Action<IScore[]> callback);
        public static ILeaderboard CreateLeaderboard();
        public static IAchievement CreateAchievement();
        public static void ShowAchievementsUI();
        public static void ShowLeaderboardUI();
    }
}
