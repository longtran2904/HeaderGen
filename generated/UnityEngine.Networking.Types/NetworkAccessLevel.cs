#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System.ComponentModel;

namespace UnityEngine.Networking.Types
{
    [DefaultValue(NetworkAccessLevel.Invalid)]
    public enum NetworkAccessLevel
    {
        Invalid = 0,
        User = 1,
        Owner = 2,
        Admin = 4
    }
}
