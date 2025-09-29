#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public struct LazyLoadReference<T> where T : Object
    {

        public LazyLoadReference(T asset);
        public LazyLoadReference(int instanceID);

        public bool isSet { get; }
        public bool isBroken { get; }
        public T asset { get; set; }
        public int instanceID { get; set; }

        public static implicit operator LazyLoadReference<T>(T asset);
        public static implicit operator LazyLoadReference<T>(int instanceID);
    }
}
