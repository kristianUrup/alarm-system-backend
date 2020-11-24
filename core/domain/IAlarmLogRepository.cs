using System.Collections.Generic;
using AlarmSystem.Core.Entity.Entity;

namespace AlarmSystem.Core.Domain
{
    public interface IAlarmLogRepository
    {
        List<AlarmLog> GetAlarmLog();
    }
}