#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.PackageManager.Requests
{
    public abstract class Request<T> : Request
    {
        public T Result { get; }

        protected abstract T GetResult();
        protected sealed override void FetchNativeData();
    }
}
