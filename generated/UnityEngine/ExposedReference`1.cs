#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode(Name = "ExposedReference")]
    public struct ExposedReference<T> where T : Object
    {

        [SerializeField]
        public PropertyName exposedName;
        [SerializeField]
        public Object defaultValue;

        public T Resolve(IExposedPropertyTable resolver);
    }
}
