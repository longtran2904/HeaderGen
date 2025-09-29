#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Build
{
    public abstract class BuildPlayerProcessor : IOrderedCallback
    {

        protected BuildPlayerProcessor();

        public virtual int callbackOrder { get; }

        public abstract void PrepareForBuild(BuildPlayerContext buildPlayerContext);
    }
}
