#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class ResourceReloader
    {
        public static (bool hasChange, bool assetDatabaseNotReady) TryReloadAllNullIn(object container, string basePath);
        public static bool ReloadAllNullIn(object container, string basePath);
    }
}
