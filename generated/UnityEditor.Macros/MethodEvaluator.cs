#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Macros
{
    public static class MethodEvaluator
    {

        public static object Eval(string assemblyFile, string typeName, string methodName, Type[] paramTypes, object[] args);
        public static object ExecuteExternalCode(string parcel);
    }
}
