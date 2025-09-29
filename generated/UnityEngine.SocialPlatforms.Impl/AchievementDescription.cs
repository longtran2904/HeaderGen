#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

namespace UnityEngine.SocialPlatforms.Impl
{
    public class AchievementDescription : IAchievementDescription
    {
        public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points);

        public string id { get; set; }
        public string title { get; }
        public Texture2D image { get; }
        public string achievedDescription { get; }
        public string unachievedDescription { get; }
        public bool hidden { get; }
        public int points { get; }

        public override string ToString();
        public void SetImage(Texture2D image);
    }
}
