#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Cursor : IEquatable<Cursor>
    {

        public Texture2D texture { get; set; }
        public Vector2 hotspot { get; set; }

        public override bool Equals(object obj);
        public bool Equals(Cursor other);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Cursor style1, Cursor style2);
        public static bool operator !=(Cursor style1, Cursor style2);
    }
}
