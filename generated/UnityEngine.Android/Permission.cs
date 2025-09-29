#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

namespace UnityEngine.Android
{
    public struct Permission
    {
        public const string Camera = "android.permission.CAMERA";
        public const string Microphone = "android.permission.RECORD_AUDIO";
        public const string FineLocation = "android.permission.ACCESS_FINE_LOCATION";
        public const string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";
        public const string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";
        public const string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";

        public static bool HasUserAuthorizedPermission(string permission);
        public static void RequestUserPermission(string permission);
        public static void RequestUserPermissions(string[] permissions);
        public static void RequestUserPermission(string permission, PermissionCallbacks callbacks);
        public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks);
    }
}
