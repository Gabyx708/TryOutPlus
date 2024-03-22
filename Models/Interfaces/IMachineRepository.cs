using Models.Entities;

namespace Models.Interfaces
{
    public interface IMachineRepository
    {
        Machine AddMachine(Machine newMachine);
    }
}
