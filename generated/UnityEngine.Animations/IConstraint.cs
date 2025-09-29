#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Animations
{
    public interface IConstraint
    {
        float weight { get; set; }
        bool constraintActive { get; set; }
        bool locked { get; set; }
        int sourceCount { get; }

        int AddSource(ConstraintSource source);
        void RemoveSource(int index);
        ConstraintSource GetSource(int index);
        void SetSource(int index, ConstraintSource source);
        void GetSources(List<ConstraintSource> sources);
        void SetSources(List<ConstraintSource> sources);
    }
}
