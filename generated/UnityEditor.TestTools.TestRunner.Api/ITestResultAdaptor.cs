#region UnityEditor.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.TestRunner.dll
#endregion

using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.Api
{
    public interface ITestResultAdaptor
    {

        ITestAdaptor Test { get; }
        string Name { get; }
        string FullName { get; }
        string ResultState { get; }
        TestStatus TestStatus { get; }
        double Duration { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        string Message { get; }
        string StackTrace { get; }
        int AssertCount { get; }
        int FailCount { get; }
        int PassCount { get; }
        int SkipCount { get; }
        int InconclusiveCount { get; }
        bool HasChildren { get; }
        IEnumerable<ITestResultAdaptor> Children { get; }
        string Output { get; }

        TNode ToXml();
    }
}
