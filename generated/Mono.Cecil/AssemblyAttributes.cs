#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    [Flags]
    public enum AssemblyAttributes
    {

        PublicKey = 1,
        SideBySideCompatible = 0,
        Retargetable = 256,
        WindowsRuntime = 512,
        DisableJITCompileOptimizer = 16384,
        EnableJITCompileTracking = 32768
    }
}
