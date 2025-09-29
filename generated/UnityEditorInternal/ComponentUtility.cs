#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Editor/Src/ComponentUtility.bindings.h")]
    [StaticAccessor("ComponentUtilityBindings", StaticAccessorType.DoubleColon)]
    public sealed class ComponentUtility
    {

        public ComponentUtility();

        public static bool MoveComponentUp(Component component);
        public static bool MoveComponentDown(Component component);
        public static bool CopyComponent(Component component);
        public static bool PasteComponentValues(Component component);
        public static bool PasteComponentAsNew([NotNull("NullExceptionObject")] GameObject go);
        public static void DestroyComponentsMatching(GameObject dst, IsDesiredComponent componentFilter);
        public static void ReplaceComponentsIfDifferent(GameObject src, GameObject dst, IsDesiredComponent componentFilter);
        public delegate bool IsDesiredComponent(Component c);
    }
}
