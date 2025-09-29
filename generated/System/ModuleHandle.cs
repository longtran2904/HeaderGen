#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public struct ModuleHandle : IEquatable<ModuleHandle>
    {

        public static readonly ModuleHandle EmptyHandle;

        public int MDStreamVersion { get; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(ModuleHandle handle);
        public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken);
        public RuntimeTypeHandle ResolveTypeHandle(int typeToken);
        public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext);
        public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken);
        public RuntimeMethodHandle ResolveMethodHandle(int methodToken);
        public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext);
        public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken);
        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken);
        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext);

        public static bool operator ==(ModuleHandle left, ModuleHandle right);
        public static bool operator !=(ModuleHandle left, ModuleHandle right);
    }
}
