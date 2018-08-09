Feature: PlayerScore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: Player 1 score is zero when game starts
	When Player 1 started game of cricket
	Then Player 1 score should be 0

Scenario: Player 1 should be able to score runs
	Given Player 1 has started a game of cricket
	And Player 1 hits 2 runs
	And Player 1 hits 4 runs
	And Player 1 hits 6 runs
	And Player 1 gets out
	When Player 1 is out
	Then Player 1 score should be 12

Scenario: Player 2 score is zero when he comes to play
	When Player 2 comes to play
	Then Player 2 score should be 0

Scenario: Player 2 started playing
	Given Player 2 started playing
	And Player 2 hits 6 runs
	And Player 2 hits 4 runs
	And Player 2 gets out
	When Player 2 gets out
	Then Player 2 score should be 10

Scenario: Both Players are playing together (GAME 1)
	Given Player 1 has started a game of cricket
	And Player 1 hits 2 runs
	And Player 1 hits 6 runs
	And Player 1 hits 3 runs
	And Player 1 hits 4 runs
	And Player 1 gets out
	And Player 2 started playing
	And Player 2 hits 3 runs
	And Player 2 hits 4 runs
	And Player 2 hits 3 runs
	And Player 2 gets out
	When Player 1 and Player 2 both are out
	Then Player 1 should win

Scenario: Both Players are playing together (GAME 2)
	Given Player 1 has started a game of cricket
	And Player 1 hits 3 runs
	And Player 1 hits 3 runs
	And Player 1 hits 4 runs
	And Player 1 gets out
	And Player 2 started playing
	And Player 2 hits 3 runs
	And Player 2 hits 4 runs
	And Player 2 hits 3 runs
	And Player 2 gets out
	When Player 1 and Player 2 both are out
	Then Match is tied and result is 0