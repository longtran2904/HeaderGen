#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Presets
{
    [NativeType(Header = "Modules/PresetsEditor/Public/PresetType.h")]
    public struct PresetType : IEquatable<PresetType>
    {

        public PresetType(UnityEngine.Object o);

        public override bool Equals(object obj);
        public override int GetHashCode();
        public bool IsValid();
        public bool IsValidDefault();
        public string GetManagedTypeName();
        public bool Equals(PresetType other);

        public static bool operator ==(PresetType a, PresetType b);
        public static bool operator !=(PresetType a, PresetType b);
    }
}
