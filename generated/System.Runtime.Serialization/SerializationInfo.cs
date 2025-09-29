#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Serialization
{
    public sealed class SerializationInfo
    {
        [CLSCompliant(False)]
        [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public SerializationInfo(Type type, IFormatterConverter converter);
        [CLSCompliant(False)]
        [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust);

        public string FullTypeName { get; set; }
        public string AssemblyName { get; set; }
        public bool IsFullTypeNameSetExplicit { get; }
        public bool IsAssemblyNameSetExplicit { get; }
        public int MemberCount { get; }
        public Type ObjectType { get; }

        public void SetType(Type type);
        public SerializationInfoEnumerator GetEnumerator();
        public void AddValue(string name, object value, Type type);
        public void AddValue(string name, object value);
        public void AddValue(string name, bool value);
        public void AddValue(string name, char value);
        [CLSCompliant(False)]
        public void AddValue(string name, sbyte value);
        public void AddValue(string name, byte value);
        public void AddValue(string name, short value);
        [CLSCompliant(False)]
        public void AddValue(string name, ushort value);
        public void AddValue(string name, int value);
        [CLSCompliant(False)]
        public void AddValue(string name, uint value);
        public void AddValue(string name, long value);
        [CLSCompliant(False)]
        public void AddValue(string name, ulong value);
        public void AddValue(string name, float value);
        public void AddValue(string name, double value);
        public void AddValue(string name, decimal value);
        public void AddValue(string name, DateTime value);
        public object GetValue(string name, Type type);
        public bool GetBoolean(string name);
        public char GetChar(string name);
        [CLSCompliant(False)]
        public sbyte GetSByte(string name);
        public byte GetByte(string name);
        public short GetInt16(string name);
        [CLSCompliant(False)]
        public ushort GetUInt16(string name);
        public int GetInt32(string name);
        [CLSCompliant(False)]
        public uint GetUInt32(string name);
        public long GetInt64(string name);
        [CLSCompliant(False)]
        public ulong GetUInt64(string name);
        public float GetSingle(string name);
        public double GetDouble(string name);
        public decimal GetDecimal(string name);
        public DateTime GetDateTime(string name);
        public string GetString(string name);
        public static DeserializationToken StartDeserialization();
    }
}
