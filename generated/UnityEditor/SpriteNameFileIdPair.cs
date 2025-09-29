#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using System;

namespace UnityEditor
{
    public class SpriteNameFileIdPair : IEquatable<SpriteNameFileIdPair>
    {

        public SpriteNameFileIdPair();
        public SpriteNameFileIdPair(string name, GUID fileId);

        public string name { get; set; }
        [Obsolete("Property obsolete. Please use GetFileGUID and SetFileGUID instead.")]
        public long fileId { get; set; }

        public GUID GetFileGUID();
        public void SetFileGUID(GUID value);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(SpriteNameFileIdPair pair);
    }
}
