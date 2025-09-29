#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    public struct MetadataToken : IEquatable<MetadataToken>
    {

        public static readonly MetadataToken Zero;

        public MetadataToken(uint token);
        public MetadataToken(TokenType type);
        public MetadataToken(TokenType type, uint rid);
        public MetadataToken(TokenType type, int rid);

        public uint RID { get; }
        public TokenType TokenType { get; }

        public int ToInt32();
        public uint ToUInt32();
        public override int GetHashCode();
        public bool Equals(MetadataToken other);
        public override bool Equals(object obj);
        public override string ToString();

        public static bool operator ==(MetadataToken one, MetadataToken other);
        public static bool operator !=(MetadataToken one, MetadataToken other);
    }
}
