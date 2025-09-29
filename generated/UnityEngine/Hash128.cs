#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Utilities/Hash128.h")]
    [NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
    [UsedByNativeCode]
    public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
    {

        public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        public Hash128(ulong u64_0, ulong u64_1);

        public bool isValid { get; }

        public int CompareTo(Hash128 rhs);
        public override string ToString();
        [FreeFunction("StringToHash128", IsThreadSafe = True)]
        public static Hash128 Parse(string hashString);
        public static Hash128 Compute(string data);
        public static Hash128 Compute<T>(NativeArray<T> data) where T : struct;
        public static Hash128 Compute<T>(NativeArray<T> data, int start, int count) where T : struct;
        public static Hash128 Compute<T>(T[] data) where T : struct;
        public static Hash128 Compute<T>(T[] data, int start, int count) where T : struct;
        public static Hash128 Compute<T>(List<T> data) where T : struct;
        public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct;
        public static Hash128 Compute<T>(ref T val) where T : unmanaged;
        public static Hash128 Compute(int val);
        public static Hash128 Compute(float val);
        public static Hash128 Compute(void* data, ulong size);
        public void Append(string data);
        public void Append<T>(NativeArray<T> data) where T : struct;
        public void Append<T>(NativeArray<T> data, int start, int count) where T : struct;
        public void Append<T>(T[] data) where T : struct;
        public void Append<T>(T[] data, int start, int count) where T : struct;
        public void Append<T>(List<T> data) where T : struct;
        public void Append<T>(List<T> data, int start, int count) where T : struct;
        public void Append<T>(ref T val) where T : unmanaged;
        public void Append(int val);
        public void Append(float val);
        public void Append(void* data, ulong size);
        public override bool Equals(object obj);
        public bool Equals(Hash128 obj);
        public override int GetHashCode();
        public int CompareTo(object obj);

        public static bool operator ==(Hash128 hash1, Hash128 hash2);
        public static bool operator !=(Hash128 hash1, Hash128 hash2);
        public static bool operator <(Hash128 x, Hash128 y);
        public static bool operator >(Hash128 x, Hash128 y);
    }
}
