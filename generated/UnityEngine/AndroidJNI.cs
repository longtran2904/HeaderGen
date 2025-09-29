#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeConditional("PLATFORM_ANDROID")]
    [NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
    [StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
    public static class AndroidJNI
    {

        [ThreadSafe]
        public static int AttachCurrentThread();
        [ThreadSafe]
        public static int DetachCurrentThread();
        [ThreadSafe]
        public static int GetVersion();
        [ThreadSafe]
        public static nint FindClass(string name);
        [ThreadSafe]
        public static nint FromReflectedMethod(nint refMethod);
        [ThreadSafe]
        public static nint FromReflectedField(nint refField);
        [ThreadSafe]
        public static nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        [ThreadSafe]
        public static nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        [ThreadSafe]
        public static nint GetSuperclass(nint clazz);
        [ThreadSafe]
        public static bool IsAssignableFrom(nint clazz1, nint clazz2);
        [ThreadSafe]
        public static int Throw(nint obj);
        [ThreadSafe]
        public static int ThrowNew(nint clazz, string message);
        [ThreadSafe]
        public static nint ExceptionOccurred();
        [ThreadSafe]
        public static void ExceptionDescribe();
        [ThreadSafe]
        public static void ExceptionClear();
        [ThreadSafe]
        public static void FatalError(string message);
        [ThreadSafe]
        public static int PushLocalFrame(int capacity);
        [ThreadSafe]
        public static nint PopLocalFrame(nint ptr);
        [ThreadSafe]
        public static nint NewGlobalRef(nint obj);
        [ThreadSafe]
        public static void DeleteGlobalRef(nint obj);
        [ThreadSafe]
        public static nint NewWeakGlobalRef(nint obj);
        [ThreadSafe]
        public static void DeleteWeakGlobalRef(nint obj);
        [ThreadSafe]
        public static nint NewLocalRef(nint obj);
        [ThreadSafe]
        public static void DeleteLocalRef(nint obj);
        [ThreadSafe]
        public static bool IsSameObject(nint obj1, nint obj2);
        [ThreadSafe]
        public static int EnsureLocalCapacity(int capacity);
        [ThreadSafe]
        public static nint AllocObject(nint clazz);
        [ThreadSafe]
        public static nint NewObject(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static nint GetObjectClass(nint obj);
        [ThreadSafe]
        public static bool IsInstanceOf(nint obj, nint clazz);
        [ThreadSafe]
        public static nint GetMethodID(nint clazz, string name, string sig);
        [ThreadSafe]
        public static nint GetFieldID(nint clazz, string name, string sig);
        [ThreadSafe]
        public static nint GetStaticMethodID(nint clazz, string name, string sig);
        [ThreadSafe]
        public static nint GetStaticFieldID(nint clazz, string name, string sig);
        public static nint NewString(string chars);
        [ThreadSafe]
        public static nint NewString(char[] chars);
        [ThreadSafe]
        public static nint NewStringUTF(string bytes);
        [ThreadSafe]
        public static string GetStringChars(nint str);
        [ThreadSafe]
        public static int GetStringLength(nint str);
        [ThreadSafe]
        public static int GetStringUTFLength(nint str);
        [ThreadSafe]
        public static string GetStringUTFChars(nint str);
        [ThreadSafe]
        public static string CallStringMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static nint CallObjectMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static int CallIntMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static bool CallBooleanMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static short CallShortMethod(nint obj, nint methodID, jvalue[] args);
        [Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
        public static byte CallByteMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static sbyte CallSByteMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static char CallCharMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static float CallFloatMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static double CallDoubleMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static long CallLongMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static void CallVoidMethod(nint obj, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static string GetStringField(nint obj, nint fieldID);
        [ThreadSafe]
        public static nint GetObjectField(nint obj, nint fieldID);
        [ThreadSafe]
        public static bool GetBooleanField(nint obj, nint fieldID);
        [Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
        public static byte GetByteField(nint obj, nint fieldID);
        [ThreadSafe]
        public static sbyte GetSByteField(nint obj, nint fieldID);
        [ThreadSafe]
        public static char GetCharField(nint obj, nint fieldID);
        [ThreadSafe]
        public static short GetShortField(nint obj, nint fieldID);
        [ThreadSafe]
        public static int GetIntField(nint obj, nint fieldID);
        [ThreadSafe]
        public static long GetLongField(nint obj, nint fieldID);
        [ThreadSafe]
        public static float GetFloatField(nint obj, nint fieldID);
        [ThreadSafe]
        public static double GetDoubleField(nint obj, nint fieldID);
        [ThreadSafe]
        public static void SetStringField(nint obj, nint fieldID, string val);
        [ThreadSafe]
        public static void SetObjectField(nint obj, nint fieldID, nint val);
        [ThreadSafe]
        public static void SetBooleanField(nint obj, nint fieldID, bool val);
        [Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
        public static void SetByteField(nint obj, nint fieldID, byte val);
        [ThreadSafe]
        public static void SetSByteField(nint obj, nint fieldID, sbyte val);
        [ThreadSafe]
        public static void SetCharField(nint obj, nint fieldID, char val);
        [ThreadSafe]
        public static void SetShortField(nint obj, nint fieldID, short val);
        [ThreadSafe]
        public static void SetIntField(nint obj, nint fieldID, int val);
        [ThreadSafe]
        public static void SetLongField(nint obj, nint fieldID, long val);
        [ThreadSafe]
        public static void SetFloatField(nint obj, nint fieldID, float val);
        [ThreadSafe]
        public static void SetDoubleField(nint obj, nint fieldID, double val);
        [ThreadSafe]
        public static string CallStaticStringMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static nint CallStaticObjectMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static int CallStaticIntMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static bool CallStaticBooleanMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static short CallStaticShortMethod(nint clazz, nint methodID, jvalue[] args);
        [Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
        public static byte CallStaticByteMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static sbyte CallStaticSByteMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static char CallStaticCharMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static float CallStaticFloatMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static double CallStaticDoubleMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static long CallStaticLongMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static void CallStaticVoidMethod(nint clazz, nint methodID, jvalue[] args);
        [ThreadSafe]
        public static string GetStaticStringField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static nint GetStaticObjectField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static bool GetStaticBooleanField(nint clazz, nint fieldID);
        [Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
        public static byte GetStaticByteField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static sbyte GetStaticSByteField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static char GetStaticCharField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static short GetStaticShortField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static int GetStaticIntField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static long GetStaticLongField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static float GetStaticFloatField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static double GetStaticDoubleField(nint clazz, nint fieldID);
        [ThreadSafe]
        public static void SetStaticStringField(nint clazz, nint fieldID, string val);
        [ThreadSafe]
        public static void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        [ThreadSafe]
        public static void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        [Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
        public static void SetStaticByteField(nint clazz, nint fieldID, byte val);
        [ThreadSafe]
        public static void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        [ThreadSafe]
        public static void SetStaticCharField(nint clazz, nint fieldID, char val);
        [ThreadSafe]
        public static void SetStaticShortField(nint clazz, nint fieldID, short val);
        [ThreadSafe]
        public static void SetStaticIntField(nint clazz, nint fieldID, int val);
        [ThreadSafe]
        public static void SetStaticLongField(nint clazz, nint fieldID, long val);
        [ThreadSafe]
        public static void SetStaticFloatField(nint clazz, nint fieldID, float val);
        [ThreadSafe]
        public static void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        [ThreadSafe]
        public static nint ToBooleanArray(bool[] array);
        [Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
        [ThreadSafe]
        public static nint ToByteArray(byte[] array);
        [ThreadSafe]
        public static nint ToSByteArray([Unmarshalled] sbyte[] array);
        [ThreadSafe]
        public static nint ToCharArray([Unmarshalled] char[] array);
        [ThreadSafe]
        public static nint ToShortArray([Unmarshalled] short[] array);
        [ThreadSafe]
        public static nint ToIntArray([Unmarshalled] int[] array);
        [ThreadSafe]
        public static nint ToLongArray([Unmarshalled] long[] array);
        [ThreadSafe]
        public static nint ToFloatArray([Unmarshalled] float[] array);
        [ThreadSafe]
        public static nint ToDoubleArray([Unmarshalled] double[] array);
        [ThreadSafe]
        public static nint ToObjectArray(nint[] array, nint arrayClass);
        public static nint ToObjectArray(nint[] array);
        [ThreadSafe]
        public static bool[] FromBooleanArray(nint array);
        [Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
        [ThreadSafe]
        public static byte[] FromByteArray(nint array);
        [ThreadSafe]
        public static sbyte[] FromSByteArray(nint array);
        [ThreadSafe]
        public static char[] FromCharArray(nint array);
        [ThreadSafe]
        public static short[] FromShortArray(nint array);
        [ThreadSafe]
        public static int[] FromIntArray(nint array);
        [ThreadSafe]
        public static long[] FromLongArray(nint array);
        [ThreadSafe]
        public static float[] FromFloatArray(nint array);
        [ThreadSafe]
        public static double[] FromDoubleArray(nint array);
        [ThreadSafe]
        public static nint[] FromObjectArray(nint array);
        [ThreadSafe]
        public static int GetArrayLength(nint array);
        [ThreadSafe]
        public static nint NewBooleanArray(int size);
        [Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
        public static nint NewByteArray(int size);
        [ThreadSafe]
        public static nint NewSByteArray(int size);
        [ThreadSafe]
        public static nint NewCharArray(int size);
        [ThreadSafe]
        public static nint NewShortArray(int size);
        [ThreadSafe]
        public static nint NewIntArray(int size);
        [ThreadSafe]
        public static nint NewLongArray(int size);
        [ThreadSafe]
        public static nint NewFloatArray(int size);
        [ThreadSafe]
        public static nint NewDoubleArray(int size);
        [ThreadSafe]
        public static nint NewObjectArray(int size, nint clazz, nint obj);
        [ThreadSafe]
        public static bool GetBooleanArrayElement(nint array, int index);
        [Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
        public static byte GetByteArrayElement(nint array, int index);
        [ThreadSafe]
        public static sbyte GetSByteArrayElement(nint array, int index);
        [ThreadSafe]
        public static char GetCharArrayElement(nint array, int index);
        [ThreadSafe]
        public static short GetShortArrayElement(nint array, int index);
        [ThreadSafe]
        public static int GetIntArrayElement(nint array, int index);
        [ThreadSafe]
        public static long GetLongArrayElement(nint array, int index);
        [ThreadSafe]
        public static float GetFloatArrayElement(nint array, int index);
        [ThreadSafe]
        public static double GetDoubleArrayElement(nint array, int index);
        [ThreadSafe]
        public static nint GetObjectArrayElement(nint array, int index);
        [Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
        public static void SetBooleanArrayElement(nint array, int index, byte val);
        [ThreadSafe]
        public static void SetBooleanArrayElement(nint array, int index, bool val);
        [Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
        public static void SetByteArrayElement(nint array, int index, sbyte val);
        [ThreadSafe]
        public static void SetSByteArrayElement(nint array, int index, sbyte val);
        [ThreadSafe]
        public static void SetCharArrayElement(nint array, int index, char val);
        [ThreadSafe]
        public static void SetShortArrayElement(nint array, int index, short val);
        [ThreadSafe]
        public static void SetIntArrayElement(nint array, int index, int val);
        [ThreadSafe]
        public static void SetLongArrayElement(nint array, int index, long val);
        [ThreadSafe]
        public static void SetFloatArrayElement(nint array, int index, float val);
        [ThreadSafe]
        public static void SetDoubleArrayElement(nint array, int index, double val);
        [ThreadSafe]
        public static void SetObjectArrayElement(nint array, int index, nint obj);
    }
}
