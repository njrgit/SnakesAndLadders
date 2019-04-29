using SnakesAndLadders.Domain.Die;
using SnakesAndLadders.Enum;
using SnakesAndLadders.Interfaces;
using System;

namespace SnakesAndLadders.Domain.Game
{
    public class Game
    {
        public readonly IDice Dice;

        private int _maxBoardValue = 100;


        public Game()
        {
            Dice = new Dice();
        }

        public GameStatus CurrentGameStatus { get; set; }

        public void StartGame()
        {
            CurrentGameStatus = GameStatus.Started;
        }

        public void AddPlayerToGame(Player.Player player)
        {
            if (CurrentGameStatus == GameStatus.Started)
            {
                player.CurrentPlayerStatus = PlayerGameStatus.InPlay;

            }
            else
            {
                throw new ArgumentException("Please Start The Game First");
            }
        }

        public void PlacePlayerTokenOnBoard(Player.Player player)
        {
            if (player.CurrentPlayerStatus == PlayerGameStatus.InPlay)
            {
                player.Token.CurrentTokenPosition = 1;
            }
        }

        public void RollDiceAndMoveToken(Player.Player player)
        {
            while(player.CurrentPlayerStatus == PlayerGameStatus.InPlay)
            {
                player.MoveToken(Dice.Roll());
                PlayerGameStatusCheck(player);
            }
        }

        public void PlayerGameStatusCheck(Player.Player player)
        {
            if (player.Token.CurrentTokenPosition == _maxBoardValue)
            {
                player.CurrentPlayerStatus = PlayerGameStatus.Won;

            }

            if (player.Token.CurrentTokenPosition > _maxBoardValue)
            {
                player.Token.CurrentTokenPosition = player.Token.PreviousTokenPosition;
            }

            Console.WriteLine($"Player Status : {player.CurrentPlayerStatus}");
        }

    }
}
