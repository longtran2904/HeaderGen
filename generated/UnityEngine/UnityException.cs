#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public class UnityException : SystemException
    {

        public UnityException();
        public UnityException(string message);
        public UnityException(string message, Exception innerException);
        protected UnityException(SerializationInfo info, StreamingContext context);
    }
}
