﻿using System;
using UnitTestDemo.DependencyInjection;

namespace UnitTestDemo
{
    public class PlayerWithDie
    {
        private IDie _die;
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
                // special event, lots of fun game logic
                _die.GetDieRoll();

                // oops, something went wrong!
                //throw new Exception();
            }
        }
    }
}
