using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SnakesAndLadders.Domain.Game;
using SnakesAndLadders.Domain.Player;
using SnakesAndLadders.Enum;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class PlayerGameStatusTests
    {

        [Fact]
        public void WhenTokenOneHundred_PlayerStatusShouldWin()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);
            game.PlacePlayerTokenOnBoard(player);
            player.Token.CurrentTokenPosition = 97;

            //Act
            player.MoveToken(3);
            game.PlayerGameStatusCheck(player);
                

            //Assert
            player.Token.CurrentTokenPosition.Should().Be(100);
            player.CurrentPlayerStatus.Should().Be(PlayerGameStatus.Won);

        }

        [Fact]
        public void WhenTokenIs101_PlayerStatusShouldBeInPlayAndPositionShouldBe97()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);
            game.PlacePlayerTokenOnBoard(player);
            player.Token.CurrentTokenPosition = 97;

            //Act
            player.MoveToken(4);
            game.PlayerGameStatusCheck(player);


            //Assert
            player.Token.CurrentTokenPosition.Should().Be(97);
            player.CurrentPlayerStatus.Should().Be(PlayerGameStatus.InPlay);

        }



    }
}
