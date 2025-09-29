#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public interface ILogHandler
    {
        void LogFormat(LogType logType, Object context, string format, params object[] args);
        void LogException(Exception exception, Object context);
    }
}
