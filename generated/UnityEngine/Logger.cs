#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public class Logger : ILogger, ILogHandler
    {

        public Logger(ILogHandler logHandler);

        public ILogHandler logHandler { get; set; }
        public bool logEnabled { get; set; }
        public LogType filterLogType { get; set; }

        public bool IsLogTypeAllowed(LogType logType);
        public void Log(LogType logType, object message);
        public void Log(LogType logType, object message, Object context);
        public void Log(LogType logType, string tag, object message);
        public void Log(LogType logType, string tag, object message, Object context);
        public void Log(object message);
        public void Log(string tag, object message);
        public void Log(string tag, object message, Object context);
        public void LogWarning(string tag, object message);
        public void LogWarning(string tag, object message, Object context);
        public void LogError(string tag, object message);
        public void LogError(string tag, object message, Object context);
        public void LogException(Exception exception);
        public void LogException(Exception exception, Object context);
        public void LogFormat(LogType logType, string format, params object[] args);
        public void LogFormat(LogType logType, Object context, string format, params object[] args);
    }
}
