#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices
{
    public sealed class HandleCollector
    {
        public HandleCollector(string name, int initialThreshold);
        public HandleCollector(string name, int initialThreshold, int maximumThreshold);

        public int Count { get; }
        public int InitialThreshold { get; }
        public int MaximumThreshold { get; }
        public string Name { get; }

        public void Add();
        public void Remove();
    }
}
