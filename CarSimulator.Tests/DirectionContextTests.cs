using Xunit;
using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DirectionStrategies.Interfaces;
using DataLogicLibrary.DTO;
using Moq;

namespace CarSimulator.Tests
{
    public class DirectionContextTests
    {
        [Fact]
        public void ExecuteStrategy_CallsExecuteOnStrategy()
        {
            var strategyMock = new Mock<IDirectionStrategy>();
            var context = new DirectionContext();
            context.SetStrategy(strategyMock.Object);

            var status = new StatusDTO();
            context.ExecuteStrategy(status);

            strategyMock.Verify(s => s.Execute(status), Times.Once);
        }

        [Fact]
        public void ExecuteStrategy_ThrowsException_WhenNoStrategySet()
        {
            var context = new DirectionContext();
            var status = new StatusDTO();
            Assert.Throws<InvalidOperationException>(() => context.ExecuteStrategy(status));
        }
    }
}
