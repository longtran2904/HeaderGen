#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System.IO;

namespace Mono.Cecil.Cil
{
    public class DefaultSymbolReaderProvider : ISymbolReaderProvider
    {

        public DefaultSymbolReaderProvider();
        public DefaultSymbolReaderProvider(bool throwIfNoSymbol);

        public ISymbolReader GetSymbolReader(ModuleDefinition module, string fileName);
        public static SymbolReaderKind GetSymbolReaderKind(string fileName);
        public SymbolReaderKind GetSymbolReaderKind(ModuleDefinition module, string fileName);
        public ISymbolReader GetSymbolReader(ModuleDefinition module, Stream symbolStream);
    }
}
