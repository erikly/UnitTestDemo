using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddDemo.External;

namespace TddDemo
{
    public class DependencyAdapter : IDependency
    {
        public int GetResult()
        {
            return new UnreliableDependency().GetResult();
        }
    }
}
