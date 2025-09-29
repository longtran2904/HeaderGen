#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Networking/Ping.bindings.h")]
    public sealed class Ping
    {

        public Ping(string address);

        ~Ping();

        public bool isDone { get; }
        public int time { get; }
        public string ip { get; }

        [ThreadAndSerializationSafe]
        public void DestroyPing();
    }
}
