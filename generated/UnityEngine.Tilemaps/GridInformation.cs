#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine.Tilemaps
{
    [AddComponentMenu("Tilemap/Grid Information")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/GridInformation.html")]
    public class GridInformation : MonoBehaviour, ISerializationCallbackReceiver
    {
        public GridInformation();

        public bool SetPositionProperty<T>(Vector3Int position, string name, T positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, int positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, string positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, float positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, double positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, Object positionProperty);
        public bool SetPositionProperty(Vector3Int position, string name, Color positionProperty);
        public T GetPositionProperty<T>(Vector3Int position, string name, T defaultValue) where T : Object;
        public int GetPositionProperty(Vector3Int position, string name, int defaultValue);
        public string GetPositionProperty(Vector3Int position, string name, string defaultValue);
        public float GetPositionProperty(Vector3Int position, string name, float defaultValue);
        public double GetPositionProperty(Vector3Int position, string name, double defaultValue);
        public Color GetPositionProperty(Vector3Int position, string name, Color defaultValue);
        public bool ErasePositionProperty(Vector3Int position, string name);
        public virtual void Reset();
        public Vector3Int[] GetAllPositions(string propertyName);
    }
}
