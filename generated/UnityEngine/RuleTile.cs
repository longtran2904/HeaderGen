#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
    [CreateAssetMenu(menuName = "2D/Tiles/Rule Tile", fileName = "New Rule Tile", order = 83)]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleTile.html")]
    public class RuleTile : TileBase
    {

        public Sprite m_DefaultSprite;
        public GameObject m_DefaultGameObject;
        public Tile.ColliderType m_DefaultColliderType;
        [HideInInspector]
        public List<TilingRule> m_TilingRules;

        public RuleTile();

        public virtual Type m_NeighborType { get; }
        public virtual int m_RotationAngle { get; }
        public int m_RotationCount { get; }
        public HashSet<Vector3Int> neighborPositions { get; }

        public void UpdateNeighborPositions();
        public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject instantiatedGameObject);
        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
        public static float GetPerlinValue(Vector3Int position, float scale, float offset);
        public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData);
        public override void RefreshTile(Vector3Int position, ITilemap tilemap);
        public virtual bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, ref Matrix4x4 transform);
        public virtual Matrix4x4 ApplyRandomTransform(TilingRuleOutput.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position);
        public FieldInfo[] GetCustomFields(bool isOverrideInstance);
        public virtual bool RuleMatch(int neighbor, TileBase other);
        public bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, int angle);
        public bool RuleMatches(TilingRule rule, Vector3Int position, ITilemap tilemap, bool mirrorX, bool mirrorY);
        public virtual Vector3Int GetRotatedPosition(Vector3Int position, int rotation);
        public virtual Vector3Int GetMirroredPosition(Vector3Int position, bool mirrorX, bool mirrorY);
        public virtual Vector3Int GetOffsetPosition(Vector3Int position, Vector3Int offset);
        public virtual Vector3Int GetOffsetPositionReverse(Vector3Int position, Vector3Int offset);
        public class TilingRuleOutput
        {

            public int m_Id;
            public Sprite[] m_Sprites;
            public GameObject m_GameObject;
            public float m_AnimationSpeed;
            public float m_PerlinScale;
            public OutputSprite m_Output;
            public Tile.ColliderType m_ColliderType;
            public Transform m_RandomTransform;

            public TilingRuleOutput();
            public class Neighbor
            {

                public const int This = 1;
                public const int NotThis = 2;

                public Neighbor();
            }
            public enum Transform
            {

                Fixed = 0,
                Rotated = 1,
                MirrorX = 2,
                MirrorY = 3,
                MirrorXY = 4
            }
            public enum OutputSprite
            {

                Single = 0,
                Random = 1,
                Animation = 2
            }
        }
        public class TilingRule : TilingRuleOutput
        {

            public List<int> m_Neighbors;
            public List<Vector3Int> m_NeighborPositions;
            public Transform m_RuleTransform;

            public TilingRule();

            public Dictionary<Vector3Int, int> GetNeighbors();
            public void ApplyNeighbors(Dictionary<Vector3Int, int> dict);
            public BoundsInt GetBounds();
        }
        public class DontOverride : Attribute
        {

            public DontOverride();
        }
    }
}
