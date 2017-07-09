using System;
using UnitTestDemo.DependencyInjection;

namespace UnitTestDemo
{
    public class PlayerWithDie
    {
        private readonly IDie _die;
        public PlayerWithDie(IDie die)
        {
            _die = die;
        }

        public void TakeTurn()
        {
            var dieRoll = _die.GetDieRoll();

            // move piece

            if (dieRoll == 6)
            {
                dieRoll += _die.Bonus;
                // special event, lots of fun game logic

                // oops, something went wrong!
                throw new Exception();
            }
        }
    }
}
