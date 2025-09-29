#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TMPro.SpriteAssetUtilities
{
    public class TexturePacker_JsonArray
    {

        public TexturePacker_JsonArray();
        public struct SpriteFrame
        {

            public float x;
            public float y;
            public float w;
            public float h;

            public override string ToString();
        }
        public struct SpriteSize
        {

            public float w;
            public float h;

            public override string ToString();
        }
        public struct Frame
        {

            public string filename;
            public SpriteFrame frame;
            public bool rotated;
            public bool trimmed;
            public SpriteFrame spriteSourceSize;
            public SpriteSize sourceSize;
            public Vector2 pivot;
        }
        public struct Meta
        {

            public string app;
            public string version;
            public string image;
            public string format;
            public SpriteSize size;
            public float scale;
            public string smartupdate;
        }
        public class SpriteDataObject
        {

            public List<Frame> frames;
            public Meta meta;

            public SpriteDataObject();
        }
    }
}
