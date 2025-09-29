#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.iOS
{
    [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
    [NativeHeader("PlatformDependent/iPhonePlayer/Notifications.h")]
    [Obsolete("iOS.Notification Services is deprecated. Consider using the Mobile Notifications package (available in the package manager) which implements the UserNotifications framework.")]
    public sealed class NotificationServices
    {
        public NotificationServices();

        public static int localNotificationCount { get; }
        public static int remoteNotificationCount { get; }
        public static NotificationType enabledNotificationTypes { get; }
        public static string registrationError { get; }
        public static byte[] deviceToken { get; }
        public static LocalNotification[] localNotifications { get; }
        public static RemoteNotification[] remoteNotifications { get; }
        public static LocalNotification[] scheduledLocalNotifications { get; }

        [FreeFunction("NotificationScripting::ClearLocal")]
        public static void ClearLocalNotifications();
        [FreeFunction("NotificationScripting::ClearRemote")]
        public static void ClearRemoteNotifications();
        public static void RegisterForNotifications(NotificationType notificationTypes);
        public static void RegisterForNotifications(NotificationType notificationTypes, bool registerForRemote);
        public static void ScheduleLocalNotification(LocalNotification notification);
        public static void PresentLocalNotificationNow(LocalNotification notification);
        public static void CancelLocalNotification(LocalNotification notification);
        [FreeFunction("iPhoneLocalNotification::CancelAll")]
        public static void CancelAllLocalNotifications();
        [FreeFunction("iPhoneRemoteNotification::Unregister")]
        public static void UnregisterForRemoteNotifications();
        public static LocalNotification GetLocalNotification(int index);
        public static RemoteNotification GetRemoteNotification(int index);
    }
}
