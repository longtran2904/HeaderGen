#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{
    [Obsolete("The menu items are handled automatically for components with the AdditionalComponentData attribute", False)]
    public interface IRemoveAdditionalDataContextualMenu<T> where T : Component
    {
        void RemoveComponent(T component, IEnumerable<Component> dependencies);
    }
}
