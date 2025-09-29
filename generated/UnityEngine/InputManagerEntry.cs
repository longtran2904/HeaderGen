#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine
{
    public class InputManagerEntry
    {
        public string name;
        public string desc;
        public string btnNegative;
        public string btnPositive;
        public string altBtnNegative;
        public string altBtnPositive;
        public float gravity;
        public float deadZone;
        public float sensitivity;
        public bool snap;
        public bool invert;
        public Kind kind;
        public Axis axis;
        public Joy joystick;

        public InputManagerEntry();

        public enum Kind
        {
            KeyOrButton = 0,
            Mouse = 1,
            Axis = 2
        }
        public enum Axis
        {
            X = 0,
            Y = 1,
            Third = 2,
            Fourth = 3,
            Fifth = 4,
            Sixth = 5,
            Seventh = 6,
            Eigth = 7
        }
        public enum Joy
        {
            All = 0,
            First = 1,
            Second = 2
        }
    }
}
