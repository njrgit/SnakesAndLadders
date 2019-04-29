using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using SnakesAndLadders.Domain.Game;
using SnakesAndLadders.Domain.Player;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class DiceTests
    {
        [Test]
        [Repeat(11)]
        public void RollDice_ShouldBeLessThanSixOrGreaterThanOne()
        {
            //Arrange
            Game game = new Game();
            Player player = new Player();
            game.StartGame();
            game.AddPlayerToGame(player);
            game.PlacePlayerTokenOnBoard(player);

            //Act
            game.RollDiceAndMoveToken(player);

            //Assert
            player.RollValue.Should().BeGreaterOrEqualTo(1);
            player.RollValue.Should().BeLessOrEqualTo(6);

        }

    }
}
