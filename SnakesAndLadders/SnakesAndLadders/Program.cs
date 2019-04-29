using System;
using SnakesAndLadders.Domain.Game;
using SnakesAndLadders.Domain.Player;


namespace SnakesAndLadders
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Game game  = new Game();
            Player player = new Player();

            game.StartGame();

            game.AddPlayerToGame(player);

            game.RollDiceAndMoveToken(player);
            
        }

    }
}
