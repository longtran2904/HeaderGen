#region UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VRModule.dll
#endregion

using System;
using UnityEngine.XR.WSA;

namespace UnityEngineInternal.XR.WSA
{
    public class RemoteSpeechAccess
    {

        public RemoteSpeechAccess();

        [Obsolete("Support for built-in VR will be removed in Unity 2020.2. Please update to the new Unity XR Plugin System. More information about the new XR Plugin System can be found at https://docs.unity3d.com/2019.3/Documentation/Manual/XR.html.", False)]
        public static void EnableRemoteSpeech(RemoteDeviceVersion version);
        [Obsolete("Support for built-in VR will be removed in Unity 2020.2. Please update to the new Unity XR Plugin System. More information about the new XR Plugin System can be found at https://docs.unity3d.com/2019.3/Documentation/Manual/XR.html.", False)]
        public static void DisableRemoteSpeech();
    }
}
