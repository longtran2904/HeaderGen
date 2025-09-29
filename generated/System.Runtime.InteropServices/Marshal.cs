#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using System.Security;

namespace System.Runtime.InteropServices
{
    public static class Marshal
    {
        public static readonly int SystemDefaultCharSize;
        public static readonly int SystemMaxDBCSCharSize;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static nint OffsetOf(Type t, string fieldName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ReadByte(Object, Int32) may be unavailable in future releases.")]
        public static byte ReadByte(object ptr, int ofs);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ReadInt16(Object, Int32) may be unavailable in future releases.")]
        public static short ReadInt16(object ptr, int ofs);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ReadInt32(Object, Int32) may be unavailable in future releases.")]
        public static int ReadInt32(object ptr, int ofs);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ReadInt64(Object, Int32) may be unavailable in future releases.")]
        public static long ReadInt64(in object ptr, int ofs);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteByte(Object, Int32, Byte) may be unavailable in future releases.")]
        public static void WriteByte(object ptr, int ofs, byte val);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteInt16(Object, Int32, Int16) may be unavailable in future releases.")]
        public static void WriteInt16(object ptr, int ofs, short val);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteInt32(Object, Int32, Int32) may be unavailable in future releases.")]
        public static void WriteInt32(object ptr, int ofs, int val);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteInt64(Object, Int32, Int64) may be unavailable in future releases.")]
        public static void WriteInt64(object ptr, int ofs, long val);
        public static int GetLastPInvokeError();
        public static void SetLastPInvokeError(int error);
        public static nint GetExceptionPointers();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetExceptionCode() may be unavailable in future releases.")]
        public static int GetExceptionCode();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void StructureToPtr(object structure, nint ptr, bool fDeleteOld);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void DestroyStructure(nint ptr, Type structuretype);
        public static nint GetHINSTANCE(Module m);
        public static int GetHRForException(Exception e);
        [SupportedOSPlatform("windows")]
        public static string GetTypeInfoName(ITypeInfo typeInfo);
        [SupportedOSPlatform("windows")]
        public static nint GetIUnknownForObject(object o);
        [SupportedOSPlatform("windows")]
        public static nint GetIDispatchForObject(object o);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static nint GetComInterfaceForObject(object o, Type T);
        [SupportedOSPlatform("windows")]
        public static nint GetComInterfaceForObject<T, TInterface>(T o);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static nint GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode);
        [SupportedOSPlatform("windows")]
        public static object GetObjectForIUnknown(nint pUnk);
        [SupportedOSPlatform("windows")]
        public static object GetUniqueObjectForIUnknown(nint unknown);
        [SupportedOSPlatform("windows")]
        public static object GetTypedObjectForIUnknown(nint pUnk, Type t);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static nint CreateAggregatedObject(nint pOuter, object o);
        [SupportedOSPlatform("windows")]
        public static nint CreateAggregatedObject<T>(nint pOuter, T o);
        public static void CleanupUnusedObjectsInCurrentContext();
        public static bool AreComObjectsAvailableForCleanup();
        public static bool IsComObject(object o);
        [SupportedOSPlatform("windows")]
        public static int ReleaseComObject(object o);
        [SupportedOSPlatform("windows")]
        public static int FinalReleaseComObject(object o);
        [SupportedOSPlatform("windows")]
        public static object GetComObjectData(object obj, object key);
        [SupportedOSPlatform("windows")]
        public static bool SetComObjectData(object obj, object key, object data);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static object CreateWrapperOfType(object o, Type t);
        [SupportedOSPlatform("windows")]
        public static TWrapper CreateWrapperOfType<T, TWrapper>(T o);
        public static bool IsTypeVisibleFromCom(Type t);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static void GetNativeVariantForObject(object obj, nint pDstNativeVariant);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static void GetNativeVariantForObject<T>(T obj, nint pDstNativeVariant);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static object GetObjectForNativeVariant(nint pSrcNativeVariant);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static T GetObjectForNativeVariant<T>(nint pSrcNativeVariant);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static object[] GetObjectsForNativeVariants(nint aSrcNativeVariant, int cVars);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SupportedOSPlatform("windows")]
        public static T[] GetObjectsForNativeVariants<T>(nint aSrcNativeVariant, int cVars);
        [SupportedOSPlatform("windows")]
        public static int GetStartComSlot(Type t);
        [SupportedOSPlatform("windows")]
        public static int GetEndComSlot(Type t);
        [SupportedOSPlatform("windows")]
        public static object BindToMoniker(string monikerName);
        [SupportedOSPlatform("windows")]
        public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak);
        public static nint AllocHGlobal(int cb);
        public static string PtrToStringAnsi(nint ptr);
        public static string PtrToStringAnsi(nint ptr, int len);
        public static string PtrToStringUni(nint ptr);
        public static string PtrToStringUni(nint ptr, int len);
        public static string PtrToStringUTF8(nint ptr);
        public static string PtrToStringUTF8(nint ptr, int byteLen);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static int SizeOf(object structure);
        public static int SizeOf<T>(T structure);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static int SizeOf(Type t);
        public static int SizeOf<T>();
        public static int QueryInterface(nint pUnk, in Guid iid, out nint ppv);
        public static int AddRef(nint pUnk);
        public static int Release(nint pUnk);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static nint UnsafeAddrOfPinnedArrayElement(Array arr, int index);
        public static nint UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index);
        public static nint OffsetOf<T>(string fieldName);
        public static void Copy(int[] source, int startIndex, nint destination, int length);
        public static void Copy(char[] source, int startIndex, nint destination, int length);
        public static void Copy(short[] source, int startIndex, nint destination, int length);
        public static void Copy(long[] source, int startIndex, nint destination, int length);
        public static void Copy(float[] source, int startIndex, nint destination, int length);
        public static void Copy(double[] source, int startIndex, nint destination, int length);
        public static void Copy(byte[] source, int startIndex, nint destination, int length);
        public static void Copy(nint[] source, int startIndex, nint destination, int length);
        public static void Copy(nint source, int[] destination, int startIndex, int length);
        public static void Copy(nint source, char[] destination, int startIndex, int length);
        public static void Copy(nint source, short[] destination, int startIndex, int length);
        public static void Copy(nint source, long[] destination, int startIndex, int length);
        public static void Copy(nint source, float[] destination, int startIndex, int length);
        public static void Copy(nint source, double[] destination, int startIndex, int length);
        public static void Copy(nint source, byte[] destination, int startIndex, int length);
        public static void Copy(nint source, nint[] destination, int startIndex, int length);
        public static byte ReadByte(nint ptr, int ofs);
        public static byte ReadByte(nint ptr);
        public static short ReadInt16(nint ptr, int ofs);
        public static short ReadInt16(nint ptr);
        public static int ReadInt32(nint ptr, int ofs);
        public static int ReadInt32(nint ptr);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ReadIntPtr(Object, Int32) may be unavailable in future releases.")]
        public static nint ReadIntPtr(object ptr, int ofs);
        public static nint ReadIntPtr(nint ptr, int ofs);
        public static nint ReadIntPtr(nint ptr);
        public static long ReadInt64(nint ptr, int ofs);
        public static long ReadInt64(nint ptr);
        public static void WriteByte(nint ptr, int ofs, byte val);
        public static void WriteByte(nint ptr, byte val);
        public static void WriteInt16(nint ptr, int ofs, short val);
        public static void WriteInt16(nint ptr, short val);
        public static void WriteInt16(nint ptr, int ofs, char val);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteInt16(Object, Int32, Char) may be unavailable in future releases.")]
        public static void WriteInt16(out object ptr, int ofs, char val);
        public static void WriteInt16(nint ptr, char val);
        public static void WriteInt32(nint ptr, int ofs, int val);
        public static void WriteInt32(nint ptr, int val);
        public static void WriteIntPtr(nint ptr, int ofs, nint val);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("WriteIntPtr(Object, Int32, IntPtr) may be unavailable in future releases.")]
        public static void WriteIntPtr(object ptr, int ofs, nint val);
        public static void WriteIntPtr(nint ptr, nint val);
        public static void WriteInt64(nint ptr, int ofs, long val);
        public static void WriteInt64(nint ptr, long val);
        public static void Prelink(MethodInfo m);
        public static void PrelinkAll(Type c);
        public static void StructureToPtr<T>(T structure, nint ptr, bool fDeleteOld);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static object PtrToStructure(nint ptr, Type structureType);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void PtrToStructure(nint ptr, object structure);
        public static void PtrToStructure<T>(nint ptr, T structure);
        public static T PtrToStructure<T>(nint ptr);
        public static void DestroyStructure<T>(nint ptr);
        public static Exception GetExceptionForHR(int errorCode);
        public static Exception GetExceptionForHR(int errorCode, nint errorInfo);
        public static void ThrowExceptionForHR(int errorCode);
        public static void ThrowExceptionForHR(int errorCode, nint errorInfo);
        public static nint SecureStringToBSTR(SecureString s);
        public static nint SecureStringToCoTaskMemAnsi(SecureString s);
        public static nint SecureStringToCoTaskMemUnicode(SecureString s);
        public static nint SecureStringToGlobalAllocAnsi(SecureString s);
        public static nint SecureStringToGlobalAllocUnicode(SecureString s);
        public static nint StringToHGlobalAnsi(string s);
        public static nint StringToHGlobalUni(string s);
        public static nint StringToCoTaskMemUni(string s);
        public static nint StringToCoTaskMemUTF8(string s);
        public static nint StringToCoTaskMemAnsi(string s);
        public static Guid GenerateGuidForType(Type type);
        public static string GenerateProgIdForType(Type type);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Delegate GetDelegateForFunctionPointer(nint ptr, Type t);
        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(nint ptr);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static nint GetFunctionPointerForDelegate(Delegate d);
        public static nint GetFunctionPointerForDelegate<TDelegate>(TDelegate d);
        public static int GetHRForLastWin32Error();
        public static void ZeroFreeBSTR(nint s);
        public static void ZeroFreeCoTaskMemAnsi(nint s);
        public static void ZeroFreeCoTaskMemUnicode(nint s);
        public static void ZeroFreeCoTaskMemUTF8(nint s);
        public static void ZeroFreeGlobalAllocAnsi(nint s);
        public static void ZeroFreeGlobalAllocUnicode(nint s);
        public static nint StringToBSTR(string s);
        public static string PtrToStringBSTR(nint ptr);
        [SupportedOSPlatform("windows")]
        public static Type GetTypeFromCLSID(Guid clsid);
        public static void InitHandle(SafeHandle safeHandle, nint handle);
        public static int GetLastWin32Error();
        public static string GetLastPInvokeErrorMessage();
        public static string PtrToStringAuto(nint ptr, int len);
        public static string PtrToStringAuto(nint ptr);
        public static nint StringToHGlobalAuto(string s);
        public static nint StringToCoTaskMemAuto(string s);
        public static nint AllocHGlobal(nint cb);
        public static void FreeHGlobal(nint hglobal);
        public static nint ReAllocHGlobal(nint pv, nint cb);
        public static nint AllocCoTaskMem(int cb);
        public static void FreeCoTaskMem(nint ptr);
        public static nint ReAllocCoTaskMem(nint pv, int cb);
        public static void FreeBSTR(nint ptr);
        public static int GetLastSystemError();
        public static void SetLastSystemError(int error);
        public static string GetPInvokeErrorMessage(int error);
    }
}
