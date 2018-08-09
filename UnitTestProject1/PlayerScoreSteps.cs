using CricketGame;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        private Cricket _result;
        [Given(@"Player 1 has started a game of cricket")]
        [When(@"Player 1 started game of cricket")]
        public void WhenPlayer1StartedGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _player1 = new Cricket();
        }

        [Given(@"Player 1 hits (.*) runs")]
        public void GivenPlayer1HitsRuns(int runs)
        {
            //ScenarioContext.Current.Pending();
            _player1.Score(runs);
        }

        [Given(@"Player 1 gets out")]
        public void GivenPlayer1GetsOut()
        {
            //ScenarioContext.Current.Pending();
            _player1.playerOut();
        }

        [When(@"Player 1 is out")]
        public void WhenPlayer1IsOut()
        {
            //ScenarioContext.Current.Pending();
            _player1.Out.Should().Be(true);
        }

        [Then(@"Player 1 score should be (.*)")]
        public void ThenPlayer1ScoreShouldBe(int score)
        {
            //ScenarioContext.Current.Pending();
            _player1.PlayerScore.Should().Be(score);
        }

        [Given(@"Player 2 started playing")]
        [When(@"Player 2 comes to play")]
        public void WhenPlayer2ComesToPlay()
        {
            //ScenarioContext.Current.Pending();
            _player2 = new Cricket();
        }

        [Given(@"Player 2 hits (.*) runs")]
        public void GivenPlayer2HitsRuns(int runs)
        {
            //ScenarioContext.Current.Pending();
            _player2.Score(runs);
        }

        [Given(@"Player 2 gets out")]
        public void GivenPlayer2GetsOut()
        {
            //ScenarioContext.Current.Pending();
            _player2.playerOut();
        }

        [When(@"Player 2 gets out")]
        public void WhenPlayer2GetsOut()
        {
            //ScenarioContext.Current.Pending();
            _player2.Out.Should().Be(true);
        }

        [Then(@"Player 2 score should be (.*)")]
        public void ThenPlayer2ScoreShouldBe(int score)
        {
            //ScenarioContext.Current.Pending();
            _player2.PlayerScore.Should().Be(score);
        }

        [When(@"Player 1 and Player 2 both are out")]
        public void WhenPlayerAndPlayerBothAreOut()
        {
            //ScenarioContext.Current.Pending();
            _player1.Out.Should().Be(true);
            _player2.Out.Should().Be(true);

        }

        [Then(@"Player (.*) should win")]
        public void ThenPlayerShouldWin(int p1)
        {
            _result = new Cricket();
            _result.result(_player1.PlayerScore, _player2.PlayerScore);
            //ScenarioContext.Current.Pending();
            _result.Result.Should().Be(p1);
        }

        [Then(@"Match is tied and result is (.*)")]
        public void ThenMatchIsTiedAndResultIs(int p1)
        {
            _result = new Cricket();
            _result.result(_player1.PlayerScore, _player2.PlayerScore);
            //ScenarioContext.Current.Pending();
            _result.Result.Should().Be(p1);
        }

    }
}
