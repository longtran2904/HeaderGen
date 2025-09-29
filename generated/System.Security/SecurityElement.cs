#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;

namespace System.Security
{
    public sealed class SecurityElement
    {
        public SecurityElement(string tag);
        public SecurityElement(string tag, string text);

        public string Tag { get; set; }
        public Hashtable Attributes { get; set; }
        public string Text { get; set; }
        public ArrayList Children { get; set; }

        public void AddAttribute(string name, string value);
        public void AddChild(SecurityElement child);
        public bool Equal(SecurityElement other);
        public SecurityElement Copy();
        public static bool IsValidTag(string tag);
        public static bool IsValidText(string text);
        public static bool IsValidAttributeName(string name);
        public static bool IsValidAttributeValue(string value);
        public static string Escape(string str);
        public override string ToString();
        public string Attribute(string name);
        public SecurityElement SearchForChildByTag(string tag);
        public string SearchForTextOfTag(string tag);
        public static SecurityElement FromString(string xml);
    }
}
