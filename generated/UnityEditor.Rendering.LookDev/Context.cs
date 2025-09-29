#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering.LookDev
{
    public class Context : ScriptableObject, IDisposable
    {

        public Context();

        public EnvironmentLibrary environmentLibrary { get; }
        public LayoutContext layout { get; }
        public bool cameraSynced { get; set; }
        public ViewIterator viewContexts { get; }

        public ViewContext GetViewContent(ViewIndex index);
        public void UpdateEnvironmentLibrary(EnvironmentLibrary library);
        public void SynchronizeCameraStates(ViewIndex baseCameraState);
        public void SetFocusedCamera(ViewIndex index);
        public struct ViewIterator : IEnumerable, IEnumerable<ViewContext>
        {
        }
    }
}
