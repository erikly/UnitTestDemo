using System;
using System.Collections.Generic;
using System.Text;

namespace TddDemo
{
    public class BusinessLogic
    {
        private IDependency _dependency;

        public BusinessLogic(IDependency dependency)
        {
            _dependency = dependency;
        }

        public int Execute()
        {
            return _dependency.GetResult();
        }
    }
}
