#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Playables;

namespace UnityEditor.Playables
{
    public static class PlayableOutputEditorExtensions
    {

        public static string GetEditorName<U>(this U output) where U : IPlayableOutput, struct;
    }
}
