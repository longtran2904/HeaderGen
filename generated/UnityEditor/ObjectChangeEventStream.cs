#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using Unity.Collections;

namespace UnityEditor
{
    public struct ObjectChangeEventStream : IDisposable
    {
        public int length { get; }
        public bool isCreated { get; }

        public ObjectChangeKind GetEventType(int eventIdx);
        public void GetChangeSceneEvent(int eventIdx, out ChangeSceneEventArgs data);
        public void GetCreateGameObjectHierarchyEvent(int eventIdx, out CreateGameObjectHierarchyEventArgs data);
        public void GetDestroyGameObjectHierarchyEvent(int eventIdx, out DestroyGameObjectHierarchyEventArgs data);
        public void GetChangeGameObjectStructureHierarchyEvent(int eventIdx, out ChangeGameObjectStructureHierarchyEventArgs data);
        public void GetChangeGameObjectStructureEvent(int eventIdx, out ChangeGameObjectStructureEventArgs data);
        public void GetChangeGameObjectParentEvent(int eventIdx, out ChangeGameObjectParentEventArgs data);
        public void GetChangeGameObjectOrComponentPropertiesEvent(int eventIdx, out ChangeGameObjectOrComponentPropertiesEventArgs data);
        public void GetCreateAssetObjectEvent(int eventIdx, out CreateAssetObjectEventArgs data);
        public void GetDestroyAssetObjectEvent(int eventIdx, out DestroyAssetObjectEventArgs data);
        public void GetChangeAssetObjectPropertiesEvent(int eventIdx, out ChangeAssetObjectPropertiesEventArgs data);
        public void GetUpdatePrefabInstancesEvent(int eventIdx, out UpdatePrefabInstancesEventArgs data);
        public ObjectChangeEventStream Clone(Allocator allocator);
        public void Dispose();

        public struct Builder : IDisposable
        {
            public Builder(Allocator allocator);

            public int eventCount { get; }

            public ObjectChangeEventStream ToStream(Allocator allocator);
            public void Dispose();
            public void PushChangeSceneEvent(ref ChangeSceneEventArgs data);
            public void PushCreateGameObjectHierarchyEvent(ref CreateGameObjectHierarchyEventArgs data);
            public void PushDestroyGameObjectHierarchyEvent(ref DestroyGameObjectHierarchyEventArgs data);
            public void PushChangeGameObjectStructureHierarchyEvent(ref ChangeGameObjectStructureHierarchyEventArgs data);
            public void PushChangeGameObjectStructureEvent(ref ChangeGameObjectStructureEventArgs data);
            public void PushChangeGameObjectParentEvent(ref ChangeGameObjectParentEventArgs data);
            public void PushChangeGameObjectOrComponentPropertiesEvent(ref ChangeGameObjectOrComponentPropertiesEventArgs data);
            public void PushCreateAssetObjectEvent(ref CreateAssetObjectEventArgs data);
            public void PushDestroyAssetObjectEvent(ref DestroyAssetObjectEventArgs data);
            public void PushChangeAssetObjectPropertiesEvent(ref ChangeAssetObjectPropertiesEventArgs data);
            public void PushUpdatePrefabInstancesEvent(ref UpdatePrefabInstancesEventArgs data);
        }
    }
}
