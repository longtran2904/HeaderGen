#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Internal;

namespace UnityEditor
{
    [ExcludeFromDocs]
    public class CommandExecuteContext
    {

        public object[] args;
        public object result;
        public CommandHint hint;

        public CommandExecuteContext();

        public object data { get; }

        public T GetArgument<T>(int index, T defaultValue = null);
    }
}
