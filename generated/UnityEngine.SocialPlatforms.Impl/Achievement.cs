#region UnityEngine.GameCenterModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.GameCenterModule.dll
#endregion

using System;

namespace UnityEngine.SocialPlatforms.Impl
{
    public class Achievement : IAchievement
    {

        public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate);
        public Achievement(string id, double percent);
        public Achievement();

        public string id { get; set; }
        public double percentCompleted { get; set; }
        public bool completed { get; }
        public bool hidden { get; }
        public DateTime lastReportedDate { get; }

        public override string ToString();
        public void ReportProgress(Action<bool> callback);
        public void SetCompleted(bool value);
        public void SetHidden(bool value);
        public void SetLastReportedDate(DateTime date);
    }
}
