#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using System;

namespace UnityEngine
{
    public class AndroidJavaObject : IDisposable
    {

        public AndroidJavaObject(string className, string[] args);
        public AndroidJavaObject(string className, AndroidJavaObject[] args);
        public AndroidJavaObject(string className, AndroidJavaClass[] args);
        public AndroidJavaObject(string className, AndroidJavaProxy[] args);
        public AndroidJavaObject(string className, AndroidJavaRunnable[] args);
        public AndroidJavaObject(string className, params object[] args);

        ~AndroidJavaObject();

        public void Dispose();
        public void Call<T>(string methodName, T[] args);
        public void Call(string methodName, params object[] args);
        public void CallStatic<T>(string methodName, T[] args);
        public void CallStatic(string methodName, params object[] args);
        public FieldType Get<FieldType>(string fieldName);
        public void Set<FieldType>(string fieldName, FieldType val);
        public FieldType GetStatic<FieldType>(string fieldName);
        public void SetStatic<FieldType>(string fieldName, FieldType val);
        public nint GetRawObject();
        public nint GetRawClass();
        public AndroidJavaObject CloneReference();
        public ReturnType Call<ReturnType, T>(string methodName, T[] args);
        public ReturnType Call<ReturnType>(string methodName, params object[] args);
        public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        public ReturnType CallStatic<ReturnType>(string methodName, params object[] args);
        protected void DebugPrint(string msg);
        protected void DebugPrint(string call, string methodName, string signature, object[] args);
        protected virtual void Dispose(bool disposing);
        protected void _Call(string methodName, params object[] args);
        protected ReturnType _Call<ReturnType>(string methodName, params object[] args);
        protected FieldType _Get<FieldType>(string fieldName);
        protected void _Set<FieldType>(string fieldName, FieldType val);
        protected void _CallStatic(string methodName, params object[] args);
        protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args);
        protected FieldType _GetStatic<FieldType>(string fieldName);
        protected void _SetStatic<FieldType>(string fieldName, FieldType val);
        protected nint _GetRawObject();
        protected nint _GetRawClass();
    }
}
