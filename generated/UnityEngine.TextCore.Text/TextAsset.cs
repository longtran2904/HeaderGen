#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    [ExcludeFromObjectFactory]
    public abstract class TextAsset : ScriptableObject
    {

        protected TextAsset();

        public string version { get; }
        public int instanceID { get; }
        public int hashCode { get; set; }
        public Material material { get; set; }
        public int materialHashCode { get; set; }
    }
}
