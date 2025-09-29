#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using System;

namespace UnityEngine.Android
{
    public class PermissionCallbacks : AndroidJavaProxy
    {
        public PermissionCallbacks();

        public event Action<string> PermissionGranted;
        public event Action<string> PermissionDenied;
        public event Action<string> PermissionDeniedAndDontAskAgain;
    }
}
