using System.Collections.Generic;
using System.IO;
using AlarmSystem.Core.Domain;
using AlarmSystem.Core.Entity.Dto;

namespace AlarmSystem.Core.Application.Implementation
{
    public class WatchService : IWatchService
    {
        private IWatchRepository _watchRepo;
        public WatchService(IWatchRepository watchRepo) {
            _watchRepo = watchRepo;
        }

        public List<MachineWatch> GetMachineSubscriptionsByMachine(string machineId)
        {
            if (string.IsNullOrEmpty(machineId)) {
                throw new InvalidDataException("Machine Id cannot be empty or non existent! Please include machine id");
            }
            return _watchRepo.ReadAllMachineSubscriptionsByMachine(machineId);
        }

        public List<MachineWatch> GetMachineSubscriptionsFromWatch(string watchId)
        {
            if (string.IsNullOrEmpty(watchId)) {
                throw new InvalidDataException("Watch id cannot be empty or non existent! Please include watch id");
            }
            return _watchRepo.ReadAllMachineSubscriptionsByWatch(watchId);
        }
    }
}