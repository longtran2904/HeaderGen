#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements.Experimental
{
    public interface IValueAnimation
    {

        bool isRunning { get; }
        int durationMs { get; set; }

        void Start();
        void Stop();
        void Recycle();
    }
}
