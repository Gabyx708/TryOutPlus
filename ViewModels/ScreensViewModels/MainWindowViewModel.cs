using Models.Entities;
using Models.Interfaces;
using Models.Repositories;
using System.Windows.Input;
using ViewModel.BaseViewModels;

namespace ViewModel.ScreensViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string? _machineNumber;
        private string? _machineName;
        private string? _machineDescription;

        private IMachineRepository machinesRepository;

        //properties
        public string MachineNumber
        {
            get { return _machineNumber; }
            set { _machineNumber = value; OnPropertyChanged(nameof(MachineNumber)); }
        }

        public string MachineName
        {
            get { return _machineName; }
            set { _machineName = value; OnPropertyChanged(nameof(MachineName)); }
        }

        public string MachineDescription
        {
            get { return _machineDescription; }
            set { _machineDescription = value; OnPropertyChanged(nameof(MachineDescription)); }
        }

        public ICommand CreateMachineCommand { get; }

        public MainWindowViewModel()
        {
            machinesRepository = new MachineRepository();
            CreateMachineCommand = new ViewModelCommand(ExecuteCreateMachine);
        }

        private bool CanExecuteCreateMachineCommand(object obj)
        {
            bool validData;

            if (string.IsNullOrEmpty(MachineName))
            {
                validData = false;
            }
            else
            {
                validData = true;
            }

            return validData;
        }

        private void ExecuteCreateMachine(object obj)
        {
            Machine newMachine = new Machine
            {
                MachineNumber = MachineNumber,
                Description = MachineDescription,
                Name = MachineName
            };

            machinesRepository.AddMachine(newMachine);
        }

    }
}
