#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeType("Runtime/Graphics/DisplayInfo.h")]
    [UsedByNativeCode]
    public struct DisplayInfo : IEquatable<DisplayInfo>
    {
        [RequiredMember]
        public int width;
        [RequiredMember]
        public int height;
        [RequiredMember]
        public RefreshRate refreshRate;
        [RequiredMember]
        public RectInt workArea;
        [RequiredMember]
        public string name;

        public bool Equals(DisplayInfo other);
    }
}
