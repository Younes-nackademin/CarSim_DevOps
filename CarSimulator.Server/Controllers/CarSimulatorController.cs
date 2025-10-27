using APIServiceLibrary.Services;
using CarSimulator.Server.Factories;
using CarSimulator.Server.Models.ViewModels;
using DataLogicLibrary.Factories;
using DataLogicLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarSimulator.Server.Controllers
{
    public class CarSimulatorController : Controller
    {
        private readonly IAPIService _apiService;
        private readonly ISimulationLogicService _simulationLogicService;
        private readonly ICarFactory _carFactory;
        private readonly IDriverFactory _driverFactory;
        private readonly IStatusFactory _statusFactory;
        private readonly IStatusMessageService _statusMessageService;

        public CarSimulatorController(
            IAPIService apiService,
            ISimulationLogicService simulationLogicService,
            ICarFactory carFactory,
            IDriverFactory driverFactory,
            IStatusFactory statusFactory,
            IStatusMessageService statusMessageService)
        {
            _apiService = apiService;
            _simulationLogicService = simulationLogicService;
            _carFactory = carFactory;
            _driverFactory = driverFactory;
            _statusFactory = statusFactory;
            _statusMessageService = statusMessageService;
        }

        public async Task<IActionResult> Index(SimulationViewModel viewModel)
        {
            if (viewModel.SelectedAction == 7)
            {
                return RedirectToAction("Index");
            }

            if (viewModel.Driver == null || string.IsNullOrEmpty(viewModel.Driver.First))
            {
                var resultDTO = await _apiService.GetOneDriver();
                var driver = _driverFactory.CreateDriver(resultDTO);
                viewModel.Driver = driver;

                viewModel.DriverName = $"{driver.Title}. {driver.First} {driver.Last}";
                viewModel.City = driver.City;
                viewModel.Country = driver.Country;
            }

            if (viewModel.IsRunning)
            {
                if (viewModel.Car != null)
                {
                    viewModel.CurrentStatus = _simulationLogicService.DecreaseStatusValues(viewModel.SelectedAction, viewModel.CurrentStatus);
                    viewModel.CurrentStatus = _simulationLogicService.PerformAction(viewModel.SelectedAction, viewModel.CurrentStatus);
                }
                else
                {
                    viewModel.Car = _carFactory.CreateCar();
                    viewModel.CurrentStatus = _statusFactory.CreateStatus();
                }

                viewModel.CurrentActionMessage = _statusMessageService.GetCurrentActionMessage(viewModel.SelectedAction, viewModel.CurrentStatus.GasValue, viewModel.Driver.First)!;
                viewModel.DriverStatusMessage = _statusMessageService.GetDriverStatusMessage(viewModel.CurrentStatus.EnergyValue, viewModel.Driver.First)!;
                viewModel.CarStatusMessage = _statusMessageService.GetCarStatusMessage(viewModel.CurrentStatus.GasValue)!;
            }

            ModelState.Clear();
            return View(viewModel);
        }
    }
}
