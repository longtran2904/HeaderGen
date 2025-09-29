#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    [NativeType("Modules/UMPE/ChannelService.h")]
    public struct ChannelInfo : IEquatable<ChannelInfo>
    {
        public static ChannelInfo invalidChannel;

        public string name { get; }
        public int id { get; }

        public bool Equals(ChannelInfo obj);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(ChannelInfo x, ChannelInfo y);
        public static bool operator !=(ChannelInfo x, ChannelInfo y);
    }
}
