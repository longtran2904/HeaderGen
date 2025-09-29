#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
    public class UnassignedReferenceException : SystemException
    {
        public UnassignedReferenceException();
        public UnassignedReferenceException(string message);
        public UnassignedReferenceException(string message, Exception innerException);
        protected UnassignedReferenceException(SerializationInfo info, StreamingContext context);
    }
}
