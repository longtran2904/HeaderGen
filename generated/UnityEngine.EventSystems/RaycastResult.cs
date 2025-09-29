#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public struct RaycastResult
    {

        public BaseRaycaster module;
        public float distance;
        public float index;
        public int depth;
        public int sortingGroupID;
        public int sortingGroupOrder;
        public int sortingLayer;
        public int sortingOrder;
        public Vector3 worldPosition;
        public Vector3 worldNormal;
        public Vector2 screenPosition;
        public int displayIndex;

        public GameObject gameObject { get; set; }
        public bool isValid { get; }

        public void Clear();
        public override string ToString();
    }
}
