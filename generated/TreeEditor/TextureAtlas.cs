#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class TextureAtlas
    {

        public int atlasWidth;
        public int atlasHeight;
        public int atlasPadding;
        public List<TextureNode> nodes;

        public TextureAtlas();

        public override int GetHashCode();
        public void AddTexture(string name, Texture2D diffuse, Color diffuseColor, Texture2D normal, Texture2D gloss, Texture2D transtex, Texture2D shadowOffsetTex, float shininess, Vector2 scale, bool tileV, Vector2 uvTiling);
        public Vector2 GetTexTiling(string name);
        public Rect GetUVRect(string name);
        public void Pack(ref int targetWidth, int targetHeight, int padding, bool correctPow2);
        public class TextureNode
        {

            public string name;
            public Texture2D diffuseTexture;
            public Color diffuseColor;
            public Texture2D normalTexture;
            public Texture2D glossTexture;
            public Texture2D translucencyTexture;
            public Texture2D shadowOffsetTexture;
            public float shininess;
            public Vector2 scale;
            public bool tileV;
            public Vector2 uvTiling;
            public Rect sourceRect;
            public Rect packedRect;
            public Rect uvRect;

            public TextureNode();

            public static bool Overlap(TextureNode a, TextureNode b);
            public int CompareTo(TextureNode b);
        }
    }
}
