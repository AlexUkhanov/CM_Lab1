using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    class InterpolationNewtonPolynom:IFunction
    {
        //Divided difference table instance
        private DividedDifferenceTable divTable;
        //Points sequence
        PointsSequence ps;
        //Function
        Function func;
        //Constructor
        public InterpolationNewtonPolynom(PointsSequence ps_in, Function func_in)
        {
            ps = ps_in;
            func = func_in;
            divTable = new DividedDifferenceTable(ps, func);
        }
        //Calculate
        public double Caclulate(double arg)
        {
            double res = 0;
            for (int j = 0; j < this.divTable.len; j++)
            {
                double addend = (double)this.divTable[0, j];
                for (int i = 0; i < j; i++)
                {
                    addend *= (arg - ps[i]);
                }
                res += addend;
            }
            return res;
        }
    }
}
