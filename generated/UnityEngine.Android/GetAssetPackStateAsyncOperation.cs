#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

namespace UnityEngine.Android
{
    public class GetAssetPackStateAsyncOperation : CustomYieldInstruction
    {

        public override bool keepWaiting { get; }
        public bool isDone { get; }
        public ulong size { get; }
        public AndroidAssetPackState[] states { get; }
    }
}
