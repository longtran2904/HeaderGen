#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Cecil.Cil;
using System.IO;
using System.Reflection;

namespace Mono.Cecil
{
    public sealed class WriterParameters
    {
        public WriterParameters();

        public uint? Timestamp { get; set; }
        public Stream SymbolStream { get; set; }
        public ISymbolWriterProvider SymbolWriterProvider { get; set; }
        public bool WriteSymbols { get; set; }
        public StrongNameKeyPair StrongNameKeyPair { get; set; }
        public bool DeterministicMvid { get; set; }
    }
}
