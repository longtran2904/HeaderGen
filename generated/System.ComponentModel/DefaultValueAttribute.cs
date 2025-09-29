#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class DefaultValueAttribute : Attribute
    {
        public DefaultValueAttribute(Type type, string value);
        public DefaultValueAttribute(char value);
        public DefaultValueAttribute(byte value);
        public DefaultValueAttribute(short value);
        public DefaultValueAttribute(int value);
        public DefaultValueAttribute(long value);
        public DefaultValueAttribute(float value);
        public DefaultValueAttribute(double value);
        public DefaultValueAttribute(bool value);
        public DefaultValueAttribute(string value);
        public DefaultValueAttribute(object value);
        [CLSCompliant(False)]
        public DefaultValueAttribute(sbyte value);
        [CLSCompliant(False)]
        public DefaultValueAttribute(ushort value);
        [CLSCompliant(False)]
        public DefaultValueAttribute(uint value);
        [CLSCompliant(False)]
        public DefaultValueAttribute(ulong value);

        public virtual object Value { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        protected void SetValue(object value);
    }
}
