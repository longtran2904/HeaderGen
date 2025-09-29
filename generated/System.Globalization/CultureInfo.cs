#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class CultureInfo : ICloneable, IFormatProvider
    {

        public CultureInfo(string name);
        public CultureInfo(string name, bool useUserOverride);
        public CultureInfo(int culture);
        public CultureInfo(int culture, bool useUserOverride);

        public static CultureInfo CurrentCulture { get; set; }
        public static CultureInfo CurrentUICulture { get; set; }
        public static CultureInfo InstalledUICulture { get; }
        public static CultureInfo DefaultThreadCurrentCulture { get; set; }
        public static CultureInfo DefaultThreadCurrentUICulture { get; set; }
        public static CultureInfo InvariantCulture { get; }
        public virtual CultureInfo Parent { get; }
        public virtual int LCID { get; }
        public virtual int KeyboardLayoutId { get; }
        public virtual string Name { get; }
        public string IetfLanguageTag { get; }
        public virtual string DisplayName { get; }
        public virtual string NativeName { get; }
        public virtual string EnglishName { get; }
        public virtual string TwoLetterISOLanguageName { get; }
        public virtual string ThreeLetterISOLanguageName { get; }
        public virtual string ThreeLetterWindowsLanguageName { get; }
        public virtual CompareInfo CompareInfo { get; }
        public virtual TextInfo TextInfo { get; }
        public virtual bool IsNeutralCulture { get; }
        public CultureTypes CultureTypes { get; }
        public virtual NumberFormatInfo NumberFormat { get; set; }
        public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
        public virtual Calendar Calendar { get; }
        public virtual Calendar[] OptionalCalendars { get; }
        public bool UseUserOverride { get; }
        public bool IsReadOnly { get; }

        public static CultureInfo CreateSpecificCulture(string name);
        public static CultureInfo[] GetCultures(CultureTypes types);
        public override bool Equals(object value);
        public override int GetHashCode();
        public override string ToString();
        public virtual object GetFormat(Type formatType);
        public void ClearCachedData();
        public CultureInfo GetConsoleFallbackUICulture();
        public virtual object Clone();
        public static CultureInfo ReadOnly(CultureInfo ci);
        public static CultureInfo GetCultureInfo(int culture);
        public static CultureInfo GetCultureInfo(string name);
        public static CultureInfo GetCultureInfo(string name, string altName);
        public static CultureInfo GetCultureInfo(string name, bool predefinedOnly);
        public static CultureInfo GetCultureInfoByIetfLanguageTag(string name);
    }
}
