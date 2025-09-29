#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public struct CullingGroupEvent
    {
        public int index { get; }
        public bool isVisible { get; }
        public bool wasVisible { get; }
        public bool hasBecomeVisible { get; }
        public bool hasBecomeInvisible { get; }
        public int currentDistance { get; }
        public int previousDistance { get; }
    }
}
