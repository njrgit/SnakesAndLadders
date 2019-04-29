using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using SnakesAndLadders.Domain.Game;
using SnakesAndLadders.Domain.Player;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class PlayerTokenTests
    {
        [Fact]
        public void WhenGameIsStarted_TokenIsOnPositionOne()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);

            //Act
            game.PlacePlayerTokenOnBoard(player);

            //Assert
            player.Token.CurrentTokenPosition.Should().Be(1);

        }

        [Fact]
        public void WhenTokenIsMoved_ItIsInTheRightTokenPosition()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);
            game.PlacePlayerTokenOnBoard(player);

            //Act
            player.MoveToken(3);

            //Assert
            player.Token.CurrentTokenPosition.Should().Be(4);

        }

        [Fact]
        public void MoveTokenMoreThanOnce()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);
            game.PlacePlayerTokenOnBoard(player);

            //Act
            player.MoveToken(3);
            player.MoveToken(4);

            //Assert
            player.Token.CurrentTokenPosition.Should().Be(8);
        }

    }
}
