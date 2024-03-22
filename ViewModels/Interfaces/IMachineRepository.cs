using Models.Entities;

namespace ViewModels.Interfaces
{
    public interface IMachineRepository
    {
        Machine AddMachine(Machine newMachine);
    }
}
