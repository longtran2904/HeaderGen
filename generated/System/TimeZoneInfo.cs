#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace System
{
    public sealed class TimeZoneInfo : IDeserializationCallback, IEquatable<TimeZoneInfo>, ISerializable
    {

        public string Id { get; }
        public bool HasIanaId { get; }
        public string DisplayName { get; }
        public string StandardName { get; }
        public string DaylightName { get; }
        public TimeSpan BaseUtcOffset { get; }
        public bool SupportsDaylightSavingTime { get; }
        public static TimeZoneInfo Local { get; }
        public static TimeZoneInfo Utc { get; }

        public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset);
        public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime);
        public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset);
        public TimeSpan GetUtcOffset(DateTime dateTime);
        public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset);
        public bool IsAmbiguousTime(DateTime dateTime);
        public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset);
        public bool IsDaylightSavingTime(DateTime dateTime);
        public bool IsInvalidTime(DateTime dateTime);
        public static void ClearCachedData();
        public static DateTimeOffset ConvertTimeBySystemTimeZoneId(DateTimeOffset dateTimeOffset, string destinationTimeZoneId);
        public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string destinationTimeZoneId);
        public static TimeZoneInfo FindSystemTimeZoneById(string id);
        public static bool TryFindSystemTimeZoneById(string id, out TimeZoneInfo timeZoneInfo);
        public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId);
        public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone);
        public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone);
        public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone);
        public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone);
        public static DateTime ConvertTimeToUtc(DateTime dateTime);
        public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone);
        public bool Equals(TimeZoneInfo other);
        public override bool Equals(object obj);
        public static TimeZoneInfo FromSerializedString(string source);
        public override int GetHashCode();
        public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones();
        public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones(bool skipSorting);
        public bool HasSameRules(TimeZoneInfo other);
        public string ToSerializedString();
        public override string ToString();
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName);
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules);
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime);
        public static bool TryConvertIanaIdToWindowsId(string ianaId, out string windowsId);
        public static bool TryConvertWindowsIdToIanaId(string windowsId, out string ianaId);
        public static bool TryConvertWindowsIdToIanaId(string windowsId, string region, out string ianaId);
        public AdjustmentRule[] GetAdjustmentRules();
        public sealed class AdjustmentRule : IDeserializationCallback, IEquatable<AdjustmentRule>, ISerializable
        {

            public DateTime DateStart { get; }
            public DateTime DateEnd { get; }
            public TimeSpan DaylightDelta { get; }
            public TransitionTime DaylightTransitionStart { get; }
            public TransitionTime DaylightTransitionEnd { get; }
            public TimeSpan BaseUtcOffsetDelta { get; }

            public bool Equals(AdjustmentRule other);
            public override bool Equals(object obj);
            public override int GetHashCode();
            public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta);
            public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd);
        }
        public readonly struct TransitionTime : IDeserializationCallback, IEquatable<TransitionTime>, ISerializable
        {

            public DateTime TimeOfDay { get; }
            public int Month { get; }
            public int Week { get; }
            public int Day { get; }
            public DayOfWeek DayOfWeek { get; }
            public bool IsFixedDateRule { get; }

            public override bool Equals(object obj);
            public bool Equals(TransitionTime other);
            public override int GetHashCode();
            public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day);
            public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek);

            public static bool operator ==(TransitionTime t1, TransitionTime t2);
            public static bool operator !=(TransitionTime t1, TransitionTime t2);
        }
    }
}
