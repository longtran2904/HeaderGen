#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEditor.Rendering
{
    public static class VolumeProfileFactory
    {
        public static VolumeProfile CreateVolumeProfileAtPath(string path);
        public static VolumeProfile CreateVolumeProfile(Scene scene, string targetName);
        public static T CreateVolumeComponent<T>(VolumeProfile profile, bool overrides = False, bool saveAsset = True) where T : VolumeComponent;
    }
}
