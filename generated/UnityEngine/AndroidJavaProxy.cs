#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

namespace UnityEngine
{
    public class AndroidJavaProxy
    {

        public readonly AndroidJavaClass javaInterface;

        public AndroidJavaProxy(string javaInterface);
        public AndroidJavaProxy(AndroidJavaClass javaInterface);

        ~AndroidJavaProxy();

        public virtual AndroidJavaObject Invoke(string methodName, object[] args);
        public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs);
        public virtual bool equals(AndroidJavaObject obj);
        public virtual int hashCode();
        public virtual string toString();
    }
}
