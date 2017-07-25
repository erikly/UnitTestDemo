using System;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("UnitTestDemo.Test")]

namespace UnitTestDemo
{
    internal class Player
    {
        internal void TakeTurn()
        {
            var randomNumberGenerator = new Random();
            var dieThrow = randomNumberGenerator.Next(1, 6);

            // move piece

            if(dieThrow == 6)
            {
                SpecialEvent();
                return;
            }
        }

        internal void SpecialEvent()
        {
            // special event, lots of fun game logic

            // oops, something went wrong!
            throw new Exception();
        }
    }
}