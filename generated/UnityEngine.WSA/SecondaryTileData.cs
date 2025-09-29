#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.WSA
{
    public struct SecondaryTileData
    {
        public string arguments;
        public bool backgroundColorSet;
        public string displayName;
        public TileForegroundText foregroundText;
        public string lockScreenBadgeLogo;
        public bool lockScreenDisplayBadgeAndTileText;
        public string phoneticName;
        public bool roamingEnabled;
        public bool showNameOnSquare150x150Logo;
        public bool showNameOnSquare310x310Logo;
        public bool showNameOnWide310x150Logo;
        public string square150x150Logo;
        public string square30x30Logo;
        public string square310x310Logo;
        public string square70x70Logo;
        public string tileId;
        public string wide310x150Logo;

        public SecondaryTileData(string id, string displayName);

        public Color32 backgroundColor { get; set; }
    }
}
