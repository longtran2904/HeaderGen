#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

namespace System.Text.RegularExpressions
{
    public enum RegexParseError
    {
        Unknown = 0,
        AlternationHasTooManyConditions = 1,
        AlternationHasMalformedCondition = 2,
        InvalidUnicodePropertyEscape = 3,
        MalformedUnicodePropertyEscape = 4,
        UnrecognizedEscape = 5,
        UnrecognizedControlCharacter = 6,
        MissingControlCharacter = 7,
        InsufficientOrInvalidHexDigits = 8,
        QuantifierOrCaptureGroupOutOfRange = 9,
        UndefinedNamedReference = 10,
        UndefinedNumberedReference = 11,
        MalformedNamedReference = 12,
        UnescapedEndingBackslash = 13,
        UnterminatedComment = 14,
        InvalidGroupingConstruct = 15,
        AlternationHasNamedCapture = 16,
        AlternationHasComment = 17,
        AlternationHasMalformedReference = 18,
        AlternationHasUndefinedReference = 19,
        CaptureGroupNameInvalid = 20,
        CaptureGroupOfZero = 21,
        UnterminatedBracket = 22,
        ExclusionGroupNotLast = 23,
        ReversedCharacterRange = 24,
        ShorthandClassInCharacterRange = 25,
        InsufficientClosingParentheses = 26,
        ReversedQuantifierRange = 27,
        NestedQuantifiersNotParenthesized = 28,
        QuantifierAfterNothing = 29,
        InsufficientOpeningParentheses = 30,
        UnrecognizedUnicodeProperty = 31
    }
}
