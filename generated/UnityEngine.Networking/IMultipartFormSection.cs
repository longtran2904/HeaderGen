#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

namespace UnityEngine.Networking
{
    public interface IMultipartFormSection
    {

        string sectionName { get; }
        byte[] sectionData { get; }
        string fileName { get; }
        string contentType { get; }
    }
}
