#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public interface IExposedPropertyTable
    {

        void SetReferenceValue(PropertyName id, Object value);
        Object GetReferenceValue(PropertyName id, out bool idValid);
        void ClearReferenceValue(PropertyName id);
    }
}
