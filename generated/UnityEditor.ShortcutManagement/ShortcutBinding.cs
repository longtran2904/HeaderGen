#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.ShortcutManagement
{
    public struct ShortcutBinding : IEquatable<ShortcutBinding>
    {

        public ShortcutBinding(KeyCombination keyCombination);

        public static ShortcutBinding empty { get; }
        public IEnumerable<KeyCombination> keyCombinationSequence { get; }

        public override string ToString();
        public bool Equals(ShortcutBinding other);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
