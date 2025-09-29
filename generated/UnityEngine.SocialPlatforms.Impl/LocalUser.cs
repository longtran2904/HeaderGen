#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms.Impl
{
    public class LocalUser : UserProfile, ILocalUser
    {
        public LocalUser();

        public IUserProfile[] friends { get; }
        public bool authenticated { get; }
        public bool underage { get; }

        public void Authenticate(Action<bool> callback);
        public void Authenticate(Action<bool, string> callback);
        public void LoadFriends(Action<bool> callback);
        public void SetFriends(IUserProfile[] friends);
        public void SetAuthenticated(bool value);
        public void SetUnderage(bool value);
    }
}
