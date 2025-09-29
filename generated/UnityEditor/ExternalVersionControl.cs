#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;

namespace UnityEditor
{
    [ExcludeFromDocs]
    public struct ExternalVersionControl
    {
        public static readonly string Disabled;
        public static readonly string AutoDetect;
        public static readonly string Generic;
        [Obsolete("Asset Server VCS support has been removed.")]
        public static readonly string AssetServer;

        public ExternalVersionControl(string value);

        public override string ToString();

        public static implicit operator string(ExternalVersionControl d);
        public static implicit operator ExternalVersionControl(string d);
    }
}
