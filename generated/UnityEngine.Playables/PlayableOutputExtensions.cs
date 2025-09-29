#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Playables
{
    public static class PlayableOutputExtensions
    {

        public static bool IsOutputNull<U>(this U output) where U : IPlayableOutput, struct;
        public static bool IsOutputValid<U>(this U output) where U : IPlayableOutput, struct;
        public static Object GetReferenceObject<U>(this U output) where U : IPlayableOutput, struct;
        public static void SetReferenceObject<U>(this U output, Object value) where U : IPlayableOutput, struct;
        public static Object GetUserData<U>(this U output) where U : IPlayableOutput, struct;
        public static void SetUserData<U>(this U output, Object value) where U : IPlayableOutput, struct;
        public static Playable GetSourcePlayable<U>(this U output) where U : IPlayableOutput, struct;
        public static void SetSourcePlayable<U, V>(this U output, V value) where U : IPlayableOutput, struct where V : IPlayable, struct;
        public static void SetSourcePlayable<U, V>(this U output, V value, int port) where U : IPlayableOutput, struct where V : IPlayable, struct;
        public static int GetSourceOutputPort<U>(this U output) where U : IPlayableOutput, struct;
        public static float GetWeight<U>(this U output) where U : IPlayableOutput, struct;
        public static void SetWeight<U>(this U output, float value) where U : IPlayableOutput, struct;
        public static void PushNotification<U>(this U output, Playable origin, INotification notification, object context = null) where U : IPlayableOutput, struct;
        public static INotificationReceiver[] GetNotificationReceivers<U>(this U output) where U : IPlayableOutput, struct;
        public static void AddNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : IPlayableOutput, struct;
        public static void RemoveNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : IPlayableOutput, struct;
        [Obsolete("Method GetSourceInputPort has been renamed to GetSourceOutputPort (UnityUpgradable) -> GetSourceOutputPort<U>(*)", False)]
        public static int GetSourceInputPort<U>(this U output) where U : IPlayableOutput, struct;
        [Obsolete("Method SetSourceInputPort has been deprecated. Use SetSourcePlayable(Playable, Port) instead.", False)]
        public static void SetSourceInputPort<U>(this U output, int value) where U : IPlayableOutput, struct;
        [Obsolete("Method SetSourceOutputPort has been deprecated. Use SetSourcePlayable(Playable, Port) instead.", False)]
        public static void SetSourceOutputPort<U>(this U output, int value) where U : IPlayableOutput, struct;
    }
}
