#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
    {
        public Text nameLabel;
        public Text valueLabel;
        public Func<float> getter;
        public Action<float> setter;
        public Func<float> incStepGetter;
        public Func<float> incStepMultGetter;
        public Func<float> decimalsGetter;

        public DebugUIHandlerIndirectFloatField();

        public void Init();
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous);
        public override void OnDeselection();
        public override void OnIncrement(bool fast);
        public override void OnDecrement(bool fast);
    }
}
