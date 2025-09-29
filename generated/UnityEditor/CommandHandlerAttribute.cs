#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True, Inherited = False)]
    [ExcludeFromDocs]
    public class CommandHandlerAttribute : Attribute
    {
        public CommandHandlerAttribute(string id, string label, CommandHint hint);
        public CommandHandlerAttribute(string id);
        public CommandHandlerAttribute(string id, CommandHint hint);
        public CommandHandlerAttribute(string id, string label);

        public string id { get; }
        public string label { get; }
        public CommandHint hint { get; }
    }
}
