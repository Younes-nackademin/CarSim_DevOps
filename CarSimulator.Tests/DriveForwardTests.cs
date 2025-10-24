using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class DriveForwardTests
    {
        [Fact]
        public void Execute_WhenMovingForward_ShouldKeepSameDirection()
        {
            var strategy = new DriveForwardStrategy();
            var status = new StatusDTO
            {
                CardinalDirection = CardinalDirection.North,
                MovementAction = MovementAction.Forward
            };

            var result = strategy.Execute(status);

            Assert.Equal(CardinalDirection.North, result.CardinalDirection);
        }

        [Fact]
        public void Execute_WhenMovingBackward_ShouldReverseDirection()
        {
            var strategy = new DriveForwardStrategy();
            var status = new StatusDTO
            {
                CardinalDirection = CardinalDirection.East,
                MovementAction = MovementAction.Backward
            };

            var result = strategy.Execute(status);

            Assert.Equal(CardinalDirection.West, result.CardinalDirection);
        }
    }
}
