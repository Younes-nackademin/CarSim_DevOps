using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class DriveForwardStrategyTests
    {
        [Fact]
        public void Execute_ForwardKeepsDirection()
        {
            var strategy = new DriveForwardStrategy();
            var status = new StatusDTO { CardinalDirection = CardinalDirection.North };
            var result = strategy.Execute(status);
            Assert.Equal(CardinalDirection.North, result.CardinalDirection);
        }
    }
}
