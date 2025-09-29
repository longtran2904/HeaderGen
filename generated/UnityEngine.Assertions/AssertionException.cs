#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Assertions
{
    public class AssertionException : Exception
    {
        public AssertionException(string message, string userMessage);

        public override string Message { get; }
    }
}
