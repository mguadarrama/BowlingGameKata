using Xunit;

namespace BowlingGameKata
{
    public class BowlingGameTest
    {
        private Game _testee;

        public BowlingGameTest()
        {
            _testee = new Game();
        }
        [Fact]
        public void Roll_ShouldReturnNumberOfRolledPins()
        {
            _testee.Roll(5);
            _testee.Score.Should().Be(5);
        }
    }
}
