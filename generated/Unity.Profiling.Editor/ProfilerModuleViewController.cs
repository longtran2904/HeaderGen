#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor;
using UnityEngine.UIElements;

namespace Unity.Profiling.Editor
{
    public abstract class ProfilerModuleViewController : IDisposable
    {

        protected ProfilerModuleViewController(ProfilerWindow profilerWindow);

        public bool Disposed { get; }
        protected ProfilerWindow ProfilerWindow { get; }

        public void Dispose();
        protected abstract VisualElement CreateView();
        protected virtual void Dispose(bool disposing);
    }
}
