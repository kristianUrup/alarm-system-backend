using System.Collections.Generic;
using AlarmSystem.Core.Entity.Dto;
using AlarmSystem.Core.Entity.Entity;

namespace AlarmSystem.Core.Application
{
    public interface IAlarmService
    {
        Alarm GetAlarmById(int id);
		void CreateAlarm(Alarm alarm);
        List<Alarm> GetAllAlarms();
	}
}