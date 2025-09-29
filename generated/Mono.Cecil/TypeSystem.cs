#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    public abstract class TypeSystem
    {

        [Obsolete("Use CoreLibrary")]
        public IMetadataScope Corlib { get; }
        public IMetadataScope CoreLibrary { get; }
        public TypeReference Object { get; }
        public TypeReference Void { get; }
        public TypeReference Boolean { get; }
        public TypeReference Char { get; }
        public TypeReference SByte { get; }
        public TypeReference Byte { get; }
        public TypeReference Int16 { get; }
        public TypeReference UInt16 { get; }
        public TypeReference Int32 { get; }
        public TypeReference UInt32 { get; }
        public TypeReference Int64 { get; }
        public TypeReference UInt64 { get; }
        public TypeReference Single { get; }
        public TypeReference Double { get; }
        public TypeReference IntPtr { get; }
        public TypeReference UIntPtr { get; }
        public TypeReference String { get; }
        public TypeReference TypedReference { get; }
    }
}
