using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace CarSimulator.Tests
{
    public class TurnRightStrategyTests
    {
        [Theory]
        [InlineData(CardinalDirection.North, CardinalDirection.East)]
        [InlineData(CardinalDirection.East, CardinalDirection.South)]
        [InlineData(CardinalDirection.South, CardinalDirection.West)]
        [InlineData(CardinalDirection.West, CardinalDirection.North)]
        public void Execute_TurnsRightCorrectly(CardinalDirection start, CardinalDirection expected)
        {
            var strategy = new TurnRightStrategy();
            var status = new StatusDTO { CardinalDirection = start };
            var result = strategy.Execute(status);
            Assert.Equal(expected, result.CardinalDirection);
        }
    }
}
