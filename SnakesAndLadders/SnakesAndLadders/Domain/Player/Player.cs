using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.Domain.Die;
using SnakesAndLadders.Enum;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders.Domain.Player
{
    public class Player
    {

        public PlayerGameStatus CurrentPlayerStatus { get; set; }

        public Token.Token Token { get; set; }

        private IDice _dice;

        public int RollValue => _dice.Roll();

        public Player()
        {
            Token = new Token.Token();
            _dice = new Dice();
            
        }

        public void MoveToken(int rollValue)
        {
            Token.PreviousTokenPosition = Token.CurrentTokenPosition;

            Console.WriteLine($"Previous Token Position : {Token.PreviousTokenPosition}");

            Token.CurrentTokenPosition += rollValue;

            Console.WriteLine($"Current Token Position : {Token.CurrentTokenPosition}");
        }
    }

}
