using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    // An interface for math functions
    public interface IFunction
    {
        /// Gets a value of the function from a given argument
        double Caclulate(double arg);
    }
}
