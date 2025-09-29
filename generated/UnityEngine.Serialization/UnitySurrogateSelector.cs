#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Runtime.Serialization;

namespace UnityEngine.Serialization
{
    public class UnitySurrogateSelector : ISurrogateSelector
    {

        public UnitySurrogateSelector();

        public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
        public void ChainSelector(ISurrogateSelector selector);
        public ISurrogateSelector GetNextSelector();
    }
}
