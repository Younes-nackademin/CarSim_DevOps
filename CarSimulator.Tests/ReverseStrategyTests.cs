using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class ReverseStrategyTests
    {
        [Theory]
        [InlineData(CardinalDirection.North, CardinalDirection.South)]
        [InlineData(CardinalDirection.South, CardinalDirection.North)]
        [InlineData(CardinalDirection.East, CardinalDirection.West)]
        [InlineData(CardinalDirection.West, CardinalDirection.East)]
        public void Execute_ReversesDirection(CardinalDirection start, CardinalDirection expected)
        {
            var strategy = new ReverseStrategy();
            var status = new StatusDTO { CardinalDirection = start };
            var result = strategy.Execute(status);
            Assert.Equal(expected, result.CardinalDirection);
        }
    }
}
