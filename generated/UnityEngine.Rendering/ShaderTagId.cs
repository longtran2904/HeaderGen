#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct ShaderTagId : IEquatable<ShaderTagId>
    {

        public static readonly ShaderTagId none;

        public ShaderTagId(string name);

        public string name { get; }

        public override bool Equals(object obj);
        public bool Equals(ShaderTagId other);
        public override int GetHashCode();

        public static bool operator ==(ShaderTagId tag1, ShaderTagId tag2);
        public static bool operator !=(ShaderTagId tag1, ShaderTagId tag2);

        public static explicit operator ShaderTagId(string name);
        public static explicit operator string(ShaderTagId tagId);
    }
}
