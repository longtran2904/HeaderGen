#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public class WaitForSecondsRealtime : CustomYieldInstruction
    {

        public WaitForSecondsRealtime(float time);

        public float waitTime { get; set; }
        public override bool keepWaiting { get; }

        public override void Reset();
    }
}
