#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEditor.Playables
{
    [NativeHeader("Editor/Src/Playables/Playables.bindings.h")]
    public static class Utility
    {
        public static event Action<PlayableGraph> graphCreated;
        public static event Action<PlayableGraph> destroyingGraph;

        public static PlayableGraph[] GetAllGraphs();
    }
}
