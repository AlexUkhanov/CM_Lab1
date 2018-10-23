using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    //Function's class
    public class Function:IFunction
    {
        //Function's delegate
        private Func<double, double> _func;

        //Constructor
        public Function(Func<double, double> func)
        {
            this._func = func;
        }

        //Calc
        public double Caclulate(double arg) => _func(arg);
    }
}
