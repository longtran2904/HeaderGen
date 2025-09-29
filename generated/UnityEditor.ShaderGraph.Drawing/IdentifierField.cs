#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing
{
    public class IdentifierField : TextValueField<string>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public IdentifierField();
        public IdentifierField(string label);

        protected override string ValueToString(string v);
        protected override string StringToValue(string str);
        public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, string startValue);
        public class UxmlFactory : UxmlFactory<IdentifierField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextValueFieldTraits<string, UxmlStringAttributeDescription>
        {

            public UxmlTraits();
        }
    }
}
