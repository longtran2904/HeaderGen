#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

namespace UnityEngine.SocialPlatforms
{
    public interface IAchievementDescription
    {

        string id { get; set; }
        string title { get; }
        Texture2D image { get; }
        string achievedDescription { get; }
        string unachievedDescription { get; }
        bool hidden { get; }
        int points { get; }
    }
}
