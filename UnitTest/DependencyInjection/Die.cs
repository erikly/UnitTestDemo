
using System;

namespace UnitTestDemo.DependencyInjection
{
    // Unit test?
    public class Die : IDie
    {
        private readonly Random _rng = new Random();

        public int Bonus => 2;

        public int GetDieRoll()
        {
            return _rng.Next(1, 6);
        }
    }
}
