#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Cecil.Cil;
using System.IO;

namespace Mono.Cecil
{
    public sealed class ReaderParameters
    {
        public ReaderParameters();
        public ReaderParameters(ReadingMode readingMode);

        public ReadingMode ReadingMode { get; set; }
        public bool InMemory { get; set; }
        public IAssemblyResolver AssemblyResolver { get; set; }
        public IMetadataResolver MetadataResolver { get; set; }
        public IMetadataImporterProvider MetadataImporterProvider { get; set; }
        public IReflectionImporterProvider ReflectionImporterProvider { get; set; }
        public Stream SymbolStream { get; set; }
        public ISymbolReaderProvider SymbolReaderProvider { get; set; }
        public bool ReadSymbols { get; set; }
        public bool ReadWrite { get; set; }
        public bool ApplyWindowsRuntimeProjections { get; set; }
    }
}
