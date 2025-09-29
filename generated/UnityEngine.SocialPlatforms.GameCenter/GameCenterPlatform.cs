#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.SocialPlatforms.GameCenter
{
    [NativeHeader("Modules/GameCenter/Public/GameCenterScriptingGlue.h")]
    [RequiredByNativeCode]
    public class GameCenterPlatform : ISocialPlatform
    {
        public GameCenterPlatform();

        public ILocalUser localUser { get; }

        public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);
        public void ReportProgress(string id, double progress, Action<bool> callback);
        public void LoadAchievements(Action<IAchievement[]> callback);
        public void ReportScore(long score, string board, Action<bool> callback);
        public void LoadScores(string category, Action<IScore[]> callback);
        public void LoadScores(ILeaderboard board, Action<bool> callback);
        public bool GetLoading(ILeaderboard board);
        public void ShowAchievementsUI();
        public void ShowLeaderboardUI();
        public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);
        public ILeaderboard CreateLeaderboard();
        public IAchievement CreateAchievement();
        public static void ResetAllAchievements(Action<bool> callback);
        public static void ShowDefaultAchievementCompletionBanner(bool value);
        public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope);
    }
}
