#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Experimental
{
    public struct AssetMoveInfo : IEquatable<AssetMoveInfo>
    {
        public AssetMoveInfo(string sourceAssetPath, string destinationAssetPath);

        public string sourceAssetPath { get; }
        public string destinationAssetPath { get; }

        public bool Equals(AssetMoveInfo other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(AssetMoveInfo left, AssetMoveInfo right);
        public static bool operator !=(AssetMoveInfo left, AssetMoveInfo right);
    }
}
