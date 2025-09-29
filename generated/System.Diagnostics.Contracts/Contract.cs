#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Diagnostics.Contracts
{
    public static class Contract
    {

        public static event EventHandler<ContractFailedEventArgs> ContractFailed;

        [Conditional("DEBUG")]
        [Conditional("CONTRACTS_FULL")]
        public static void Assume(bool condition);
        [Conditional("DEBUG")]
        [Conditional("CONTRACTS_FULL")]
        public static void Assume(bool condition, string userMessage);
        [Conditional("DEBUG")]
        [Conditional("CONTRACTS_FULL")]
        public static void Assert(bool condition);
        [Conditional("DEBUG")]
        [Conditional("CONTRACTS_FULL")]
        public static void Assert(bool condition, string userMessage);
        [Conditional("CONTRACTS_FULL")]
        public static void Requires(bool condition);
        [Conditional("CONTRACTS_FULL")]
        public static void Requires(bool condition, string userMessage);
        public static void Requires<TException>(bool condition) where TException : Exception;
        public static void Requires<TException>(bool condition, string userMessage) where TException : Exception;
        [Conditional("CONTRACTS_FULL")]
        public static void Ensures(bool condition);
        [Conditional("CONTRACTS_FULL")]
        public static void Ensures(bool condition, string userMessage);
        [Conditional("CONTRACTS_FULL")]
        public static void EnsuresOnThrow<TException>(bool condition) where TException : Exception;
        [Conditional("CONTRACTS_FULL")]
        public static void EnsuresOnThrow<TException>(bool condition, string userMessage) where TException : Exception;
        public static T Result<T>();
        public static T ValueAtReturn<T>(out T value);
        public static T OldValue<T>(T value);
        [Conditional("CONTRACTS_FULL")]
        public static void Invariant(bool condition);
        [Conditional("CONTRACTS_FULL")]
        public static void Invariant(bool condition, string userMessage);
        public static bool ForAll(int fromInclusive, int toExclusive, Predicate<int> predicate);
        public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate);
        public static bool Exists(int fromInclusive, int toExclusive, Predicate<int> predicate);
        public static bool Exists<T>(IEnumerable<T> collection, Predicate<T> predicate);
        [Conditional("CONTRACTS_FULL")]
        public static void EndContractBlock();
    }
}
