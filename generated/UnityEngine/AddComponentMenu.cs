#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public sealed class AddComponentMenu : Attribute
    {

        public AddComponentMenu(string menuName);
        public AddComponentMenu(string menuName, int order);

        public string componentMenu { get; }
        public int componentOrder { get; }
    }
}
