#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    public enum iOSBackgroundMode
    {

        None = 0,
        Audio = 1,
        Location = 2,
        VOIP = 4,
        NewsstandContent = 8,
        ExternalAccessory = 16,
        BluetoothCentral = 32,
        BluetoothPeripheral = 64,
        Fetch = 128,
        RemoteNotification = 256
    }
}
