#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Build
{
    public readonly struct NamedBuildTarget : IComparable<NamedBuildTarget>, IEquatable<NamedBuildTarget>
    {

        public static readonly NamedBuildTarget Unknown;
        public static readonly NamedBuildTarget Standalone;
        public static readonly NamedBuildTarget Server;
        public static readonly NamedBuildTarget iOS;
        public static readonly NamedBuildTarget Android;
        public static readonly NamedBuildTarget WebGL;
        public static readonly NamedBuildTarget WindowsStoreApps;
        public static readonly NamedBuildTarget PS4;
        public static readonly NamedBuildTarget XboxOne;
        public static readonly NamedBuildTarget tvOS;
        public static readonly NamedBuildTarget NintendoSwitch;
        public static readonly NamedBuildTarget Stadia;
        public static readonly NamedBuildTarget LinuxHeadlessSimulation;
        [Obsolete("CloudRendering is deprecated, please use LinuxHeadlessSimulation (UnityUpgradable) -> LinuxHeadlessSimulation", False)]
        public static readonly NamedBuildTarget CloudRendering;
        public static readonly NamedBuildTarget EmbeddedLinux;

        public string TargetName { get; }

        public BuildTargetGroup ToBuildTargetGroup();
        public static NamedBuildTarget FromBuildTargetGroup(BuildTargetGroup buildTargetGroup);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(NamedBuildTarget other);
        public int CompareTo(NamedBuildTarget other);

        public static bool operator ==(NamedBuildTarget lhs, NamedBuildTarget rhs);
        public static bool operator !=(NamedBuildTarget lhs, NamedBuildTarget rhs);
    }
}
