#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public struct TMP_Offset
    {
        public TMP_Offset(float left, float right, float top, float bottom);
        public TMP_Offset(float horizontal, float vertical);

        public float left { get; set; }
        public float right { get; set; }
        public float top { get; set; }
        public float bottom { get; set; }
        public float horizontal { get; set; }
        public float vertical { get; set; }
        public static TMP_Offset zero { get; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(TMP_Offset other);

        public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs);
        public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs);
        public static TMP_Offset operator *(TMP_Offset a, float b);
    }
}
