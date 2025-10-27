using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class TurnLeftStrategyTests
    {
        [Theory]
        [InlineData(CardinalDirection.North, CardinalDirection.West)]
        [InlineData(CardinalDirection.West, CardinalDirection.South)]
        [InlineData(CardinalDirection.South, CardinalDirection.East)]
        [InlineData(CardinalDirection.East, CardinalDirection.North)]
        public void Execute_TurnsLeftCorrectly(CardinalDirection start, CardinalDirection expected)
        {
            var strategy = new TurnLeftStrategy();
            var status = new StatusDTO { CardinalDirection = start };
            var result = strategy.Execute(status);
            Assert.Equal(expected, result.CardinalDirection);
        }
    }
}
