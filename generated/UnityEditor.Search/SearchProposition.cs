#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Search
{
    public readonly struct SearchProposition : IComparable<SearchProposition>, IEquatable<SearchProposition>
    {
        public SearchProposition(string label, string replacement = null, string help = null, int priority = 2147483647, TextCursorPlacement moveCursor = TextCursorPlacement.MoveAutoComplete, Texture2D icon = null, Color color = null);

        public int CompareTo(SearchProposition other);
        public bool Equals(SearchProposition other);
        public override int GetHashCode();
        public override bool Equals(object other);
        public override string ToString();
    }
}
