#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Internal;

namespace UnityEditor
{
    [ExcludeFromDocs]
    public static class CommandService
    {

        public static string GetCommandLabel(string commandId);
        public static void RegisterCommand(string id, string label, CommandHandler handler, CommandHint hint = CommandHint.Undefined);
        public static void RegisterCommand(string id, CommandHandler handler, CommandHint hint = CommandHint.Undefined);
        public static bool UnregisterCommand(string id);
        public static bool Exists(string id);
        public static object Execute(string id);
        public static object Execute(string id, CommandHint hint);
        public static object Execute(string id, CommandHint hint, params object[] args);
    }
}
