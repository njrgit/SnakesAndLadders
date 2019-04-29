using System;
using System.Collections.Generic;
using System.Text;
using SnakesAndLadders.Interfaces;

namespace SnakesAndLadders.Domain.Die
{
    public class Dice : IDice
    {

        readonly Random _random = new Random();

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}
