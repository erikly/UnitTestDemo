using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo.External
{
    // We do not own this class! Do not touch!
    class UnreliableDependency
    {
        private readonly Random _rng;
        // Simulate unstable behaviour
        public int GetResult()
        {
            return _rng.Next(-5, 50);
        }
    }
}
