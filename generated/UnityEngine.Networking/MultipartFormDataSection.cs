#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System.Text;

namespace UnityEngine.Networking
{
    public class MultipartFormDataSection : IMultipartFormSection
    {
        public MultipartFormDataSection(string name, byte[] data, string contentType);
        public MultipartFormDataSection(string name, byte[] data);
        public MultipartFormDataSection(byte[] data);
        public MultipartFormDataSection(string name, string data, Encoding encoding, string contentType);
        public MultipartFormDataSection(string name, string data, string contentType);
        public MultipartFormDataSection(string name, string data);
        public MultipartFormDataSection(string data);

        public string sectionName { get; }
        public byte[] sectionData { get; }
        public string fileName { get; }
        public string contentType { get; }
    }
}
