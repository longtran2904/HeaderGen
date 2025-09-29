#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms
{
    public interface ILocalUser : IUserProfile
    {
        IUserProfile[] friends { get; }
        bool authenticated { get; }
        bool underage { get; }

        void Authenticate(Action<bool> callback);
        void Authenticate(Action<bool, string> callback);
        void LoadFriends(Action<bool> callback);
    }
}
