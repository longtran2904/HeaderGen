#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEditor.Networking.PlayerConnection
{
    public static class PlayerConnectionGUIUtility
    {

        public static IConnectionState GetConnectionState(EditorWindow parentWindow, Action<string> connectedCallback = null);
    }
}
