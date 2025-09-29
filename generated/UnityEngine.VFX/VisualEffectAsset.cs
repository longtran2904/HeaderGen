#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
    [NativeHeader("VFXScriptingClasses.h")]
    [UsedByNativeCode]
    public class VisualEffectAsset : VisualEffectObject
    {

        public static readonly int PlayEventID;
        public static readonly int StopEventID;
        public const string PlayEventName = "OnPlay";
        public const string StopEventName = "OnStop";

        public VisualEffectAsset();

        [FreeFunction(Name = "VisualEffectAssetBindings::GetTextureDimension", HasExplicitThis = True)]
        public TextureDimension GetTextureDimension(int nameID);
        [FreeFunction(Name = "VisualEffectAssetBindings::GetExposedProperties", HasExplicitThis = True)]
        public void GetExposedProperties([NotNull("ArgumentNullException")] List<VFXExposedProperty> exposedProperties);
        [FreeFunction(Name = "VisualEffectAssetBindings::GetEvents", HasExplicitThis = True)]
        public void GetEvents([NotNull("ArgumentNullException")] List<string> names);
        public TextureDimension GetTextureDimension(string name);
    }
}
