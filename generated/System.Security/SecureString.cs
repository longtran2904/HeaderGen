#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Security
{
    public sealed class SecureString : IDisposable
    {

        public SecureString();
        [CLSCompliant(False)]
        public SecureString(char* value, int length);

        public int Length { get; }

        public void AppendChar(char c);
        public void Clear();
        public SecureString Copy();
        public void Dispose();
        public void InsertAt(int index, char c);
        public bool IsReadOnly();
        public void MakeReadOnly();
        public void RemoveAt(int index);
        public void SetAt(int index, char c);
    }
}
