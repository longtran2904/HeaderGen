#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
    [AttributeUsage(AttributeTargets.Interface)]
    public sealed class JobProducerTypeAttribute : Attribute
    {

        public JobProducerTypeAttribute(Type producerType);

        public Type ProducerType { get; }
    }
}
