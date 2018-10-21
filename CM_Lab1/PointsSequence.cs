using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    class PointsSequence
    {
        private Func<int,double> _func;
        //Left and right borders of segment
        private double left, right;
        //Points x
        private double[] x_points;
        //Split type
        //true-Chebyshev's distribution
        //false-even distribution
        bool type;
        //Count of segments
        int n;
        //Constructor
        //left_in,right_in - borders of distribution
        //n_in - count of segments
        //type_in - type of distribution
        public PointsSequence(double left_in, double right_in, bool type_in, int n_in)
        {
            type = type_in;
            n = n_in;
            left = left_in;
            right = right_in;
            x_points = new double[n+1];
            if (type)
            {
                _func = ChebyshevDistribution;
            }
            else
            {
                _func = EvenDistribution;
            }
            for (int i = 0; i <= n; i++)
            {
                x_points[i] = _func(i);
            }
        }
        //i-number of point
        private double ChebyshevDistribution(int i)
        {
            return (left + right) / 2 + (right - left) / 2 * Math.Cos((2 * i + 1) / (2 * n + 2) * Math.PI);
        }
        private double EvenDistribution(int i)
        {
            return left + (right - left) * i / n;
        }
        //Indexer
        public double this[int i]
        {
            get { return x_points[i]; }
        }
    }
}
