using CarSimulator.Server.Models;
using DataLogicLibrary.DTO;

namespace CarSimulator.Server.Models.ViewModels
{
    public class SimulationViewModel
    {
        public bool IsRunning { get; set; } = false;
        public int SelectedAction { get; set; }

        public Car Car { get; set; } = new Car();
        public Driver Driver { get; set; } = new Driver();
        public StatusDTO CurrentStatus { get; set; } = new StatusDTO();

        public string CarStatusMessage { get; set; } = string.Empty;
        public string DriverStatusMessage { get; set; } = string.Empty;
        public string CurrentActionMessage { get; set; } = string.Empty;

        public string? DriverName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
