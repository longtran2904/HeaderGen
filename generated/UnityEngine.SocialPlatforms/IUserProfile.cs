#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

namespace UnityEngine.SocialPlatforms
{
    public interface IUserProfile
    {

        string userName { get; }
        string id { get; }
        bool isFriend { get; }
        UserState state { get; }
        Texture2D image { get; }
    }
}
