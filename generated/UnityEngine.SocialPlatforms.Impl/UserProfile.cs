#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms.Impl
{
    public class UserProfile : IUserProfile
    {

        protected string m_UserName;
        protected string m_ID;
        protected bool m_IsFriend;
        protected UserState m_State;
        protected Texture2D m_Image;

        public UserProfile();
        public UserProfile(string name, string id, bool friend);
        public UserProfile(string name, string id, bool friend, UserState state, Texture2D image);
        public UserProfile(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image);

        public string userName { get; }
        public string id { get; }
        [Obsolete("legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead (UnityUpgradable) -> id", True)]
        public string legacyId { get; }
        public string gameId { get; }
        public bool isFriend { get; }
        public UserState state { get; }
        public Texture2D image { get; }

        public override string ToString();
        public void SetUserName(string name);
        public void SetUserID(string id);
        public void SetLegacyUserID(string id);
        public void SetUserGameID(string id);
        public void SetImage(Texture2D image);
        public void SetIsFriend(bool value);
        public void SetState(UserState state);
    }
}
