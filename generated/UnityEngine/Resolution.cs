#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public struct Resolution
    {
        public int width { get; set; }
        public int height { get; set; }
        public int refreshRate { get; set; }

        public override string ToString();
    }
}
