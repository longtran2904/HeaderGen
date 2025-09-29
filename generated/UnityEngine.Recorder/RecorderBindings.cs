#region Unity.Recorder, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.dll
#endregion

namespace UnityEngine.Recorder
{
    [ExecuteInEditMode]
    public class RecorderBindings : MonoBehaviour
    {
        public RecorderBindings();

        public void SetBindingValue(string id, Object value);
        public Object GetBindingValue(string id);
        public bool HasBindingValue(string id);
        public void RemoveBinding(string id);
        public bool IsEmpty();
        public void DuplicateBinding(string src, string dst);
    }
}
