using Models.Entities;
using Models.Interfaces;

namespace Models.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        private List<Machine> _fakeMachines = new();
        public Machine AddMachine(Machine newMachine)
        {
            _fakeMachines.Add(newMachine);
            return newMachine;
        }
    }
}
