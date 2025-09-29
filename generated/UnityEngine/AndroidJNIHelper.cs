#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeConditional("PLATFORM_ANDROID")]
    [NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
    [StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
    [UsedByNativeCode]
    public static class AndroidJNIHelper
    {
        public static bool debug { get; set; }

        public static nint GetConstructorID(nint javaClass);
        public static nint GetConstructorID(nint javaClass, [DefaultValue("")] string signature);
        public static nint GetMethodID(nint javaClass, string methodName);
        public static nint GetMethodID(nint javaClass, string methodName, [DefaultValue("")] string signature);
        public static nint GetMethodID(nint javaClass, string methodName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic);
        public static nint GetFieldID(nint javaClass, string fieldName);
        public static nint GetFieldID(nint javaClass, string fieldName, [DefaultValue("")] string signature);
        public static nint GetFieldID(nint javaClass, string fieldName, [DefaultValue("")] string signature, [DefaultValue("false")] bool isStatic);
        public static nint CreateJavaRunnable(AndroidJavaRunnable jrunnable);
        public static nint CreateJavaProxy(AndroidJavaProxy proxy);
        public static nint ConvertToJNIArray(Array array);
        public static jvalue[] CreateJNIArgArray(object[] args);
        public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs);
        public static nint GetConstructorID(nint jclass, object[] args);
        public static nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        public static string GetSignature(object obj);
        public static string GetSignature(object[] args);
        public static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        public static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        public static nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        public static string GetSignature<ReturnType>(object[] args);
    }
}
