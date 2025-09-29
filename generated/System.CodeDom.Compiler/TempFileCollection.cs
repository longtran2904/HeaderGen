#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;

namespace System.CodeDom.Compiler
{
    public class TempFileCollection : ICollection, IDisposable, IEnumerable
    {

        public TempFileCollection();
        public TempFileCollection(string tempDir);
        public TempFileCollection(string tempDir, bool keepFiles);

        ~TempFileCollection();

        public int Count { get; }
        public string TempDir { get; }
        public string BasePath { get; }
        public bool KeepFiles { get; set; }

        protected virtual void Dispose(bool disposing);
        public string AddExtension(string fileExtension);
        public string AddExtension(string fileExtension, bool keepFile);
        public void AddFile(string fileName, bool keepFile);
        public IEnumerator GetEnumerator();
        public void CopyTo(string[] fileNames, int start);
        public void Delete();
    }
}
