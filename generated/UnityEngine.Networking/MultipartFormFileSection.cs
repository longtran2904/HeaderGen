#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System.Text;

namespace UnityEngine.Networking
{
    public class MultipartFormFileSection : IMultipartFormSection
    {
        public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType);
        public MultipartFormFileSection(byte[] data);
        public MultipartFormFileSection(string fileName, byte[] data);
        public MultipartFormFileSection(string name, string data, Encoding dataEncoding, string fileName);
        public MultipartFormFileSection(string data, Encoding dataEncoding, string fileName);
        public MultipartFormFileSection(string data, string fileName);

        public string sectionName { get; }
        public byte[] sectionData { get; }
        public string fileName { get; }
        public string contentType { get; }
    }
}
