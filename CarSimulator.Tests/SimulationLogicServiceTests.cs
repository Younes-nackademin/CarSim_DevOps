using Xunit;
using DataLogicLibrary.Services;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DirectionStrategies.Interfaces;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class SimulationLogicServiceTests
    {
        private readonly SimulationLogicService _service;
        private readonly DirectionContext _context;

        public SimulationLogicServiceTests()
        {
            _context = new DirectionContext();
            _service = new SimulationLogicService(_context, m =>
                m switch
                {
                    MovementAction.Left => new TurnLeftStrategy(),
                    MovementAction.Right => new TurnRightStrategy(),
                    MovementAction.Forward => new DriveForwardStrategy(),
                    MovementAction.Backward => new ReverseStrategy(),
                    _ => throw new ArgumentOutOfRangeException()
                });
        }

        [Fact]
        public void TurnLeft_ChangesDirectionCorrectly()
        {
            var status = new StatusDTO { CardinalDirection = CardinalDirection.North };
            var result = _service.PerformAction(1, status);
            Assert.Equal(CardinalDirection.West, result.CardinalDirection);
        }

        [Fact]
        public void TurnRight_ChangesDirectionCorrectly()
        {
            var status = new StatusDTO { CardinalDirection = CardinalDirection.North };
            var result = _service.PerformAction(2, status);
            Assert.Equal(CardinalDirection.East, result.CardinalDirection);
        }

        [Fact]
        public void DriveForward_KeepsDirection()
        {
            var status = new StatusDTO { CardinalDirection = CardinalDirection.South };
            var result = _service.PerformAction(3, status);
            Assert.Equal(CardinalDirection.South, result.CardinalDirection);
        }

        [Fact]
        public void Reverse_ChangesDirectionOpposite()
        {
            var status = new StatusDTO { CardinalDirection = CardinalDirection.East };
            var result = _service.PerformAction(4, status);
            Assert.Equal(CardinalDirection.West, result.CardinalDirection);
        }

        [Fact]
        public void RestAction_RefillsEnergy()
        {
            var status = new StatusDTO { EnergyValue = 0 };
            var result = _service.PerformAction(5, status);
            Assert.Equal(20, result.EnergyValue);
        }

        [Fact]
        public void RefuelAction_RefillsGas()
        {
            var status = new StatusDTO { GasValue = 0 };
            var result = _service.PerformAction(6, status);
            Assert.Equal(20, result.GasValue);
        }

        [Fact]
        public void DecreaseStatusValues_DecreasesEnergyAndGas()
        {
            var status = new StatusDTO { EnergyValue = 15, GasValue = 15 };
            var result = _service.DecreaseStatusValues(3, status);
            Assert.True(result.EnergyValue < 15 && result.GasValue < 15);
        }

        [Fact]
        public void DecreaseStatusValues_NeverBelowZero()
        {
            var status = new StatusDTO { EnergyValue = 0, GasValue = 0 };
            var result = _service.DecreaseStatusValues(3, status);
            Assert.True(result.EnergyValue >= 0 && result.GasValue >= 0);
        }
    }
}
