#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System.Collections.Generic;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
    public class WWWForm
    {

        public WWWForm();

        public Dictionary<string, string> headers { get; }
        public byte[] data { get; }

        public void AddField(string fieldName, string value);
        public void AddField(string fieldName, string value, Encoding e);
        public void AddField(string fieldName, int i);
        [ExcludeFromDocs]
        public void AddBinaryData(string fieldName, byte[] contents);
        [ExcludeFromDocs]
        public void AddBinaryData(string fieldName, byte[] contents, string fileName);
        public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType);
    }
}
