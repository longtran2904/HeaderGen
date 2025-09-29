#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public struct RangeInt
    {
        public int start;
        public int length;

        public RangeInt(int start, int length);

        public int end { get; }
    }
}
