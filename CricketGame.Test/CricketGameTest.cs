using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);
        }

        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
    }
}
