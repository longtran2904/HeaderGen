#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Reporting
{
    public class StrippingInfo : ScriptableObject, ISerializationCallbackReceiver
    {

        public StrippingInfo();

        public IEnumerable<string> includedModules { get; }

        public IEnumerable<string> GetReasonsForIncluding(string entityName);
    }
}
