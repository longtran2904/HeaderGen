#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class FocusChangeDirection : IDisposable
    {
        protected FocusChangeDirection(int value);

        public static FocusChangeDirection unspecified { get; }
        public static FocusChangeDirection none { get; }
        protected static FocusChangeDirection lastValue { get; }

        protected virtual void Dispose();

        public static implicit operator int(FocusChangeDirection fcd);
    }
}
