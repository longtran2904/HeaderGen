#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.WSA
{
    [NativeConditional("PLATFORM_WINRT")]
    [NativeHeader("Runtime/Export/WSA/WSATiles.bindings.h")]
    [StaticAccessor("WSATilesBindings::Tile", StaticAccessorType.DoubleColon)]
    public sealed class Tile
    {

        public static Tile main { get; }
        public string id { get; }
        public bool hasUserConsent { get; }
        public bool exists { get; }

        [ThreadAndSerializationSafe]
        public static string GetTemplate(TileTemplate templ);
        public void Update(string xml);
        public void Update(string medium, string wide, string large, string text);
        public void PeriodicUpdate(string uri, float interval);
        public void StopPeriodicUpdate();
        public void UpdateBadgeImage(string image);
        public void UpdateBadgeNumber(float number);
        public void RemoveBadge();
        public void PeriodicBadgeUpdate(string uri, float interval);
        public void StopPeriodicBadgeUpdate();
        [ThreadAndSerializationSafe]
        public static bool Exists(string tileId);
        public static Tile CreateOrUpdateSecondary(SecondaryTileData data);
        public static Tile CreateOrUpdateSecondary(SecondaryTileData data, Vector2 pos);
        public static Tile CreateOrUpdateSecondary(SecondaryTileData data, Rect area);
        public static Tile GetSecondary(string tileId);
        public static Tile[] GetSecondaries();
        public void Delete();
        [ThreadAndSerializationSafe]
        public static void DeleteSecondary(string tileId);
        public void Delete(Vector2 pos);
        public static void DeleteSecondary(string tileId, Vector2 pos);
        public void Delete(Rect area);
        public static void DeleteSecondary(string tileId, Rect area);
    }
}
