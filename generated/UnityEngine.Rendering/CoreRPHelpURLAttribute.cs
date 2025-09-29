#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = False)]
    [Conditional("UNITY_EDITOR")]
    public class CoreRPHelpURLAttribute : HelpURLAttribute
    {

        public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core");
    }
}
