#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
    public class BitStream
    {

        public BitStream();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public bool isReading { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public bool isWriting { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref bool value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref char value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref short value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref int value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref float value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref float value, float maxDelta);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref Quaternion value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref Quaternion value, float maxDelta);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref Vector3 value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref Vector3 value, float maxDelta);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref NetworkPlayer value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void Serialize(ref NetworkViewID viewID);
    }
}
