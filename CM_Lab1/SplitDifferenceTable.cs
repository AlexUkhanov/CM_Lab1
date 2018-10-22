using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Lab1
{
    class SplitDifferenceTable
    {
        Function func;
        //Split difference table
        private double?[,] sd_table;
        //X points
        PointsSequence points;
        public SplitDifferenceTable(PointsSequence ps_in,Function func_in)
        {
            func = func_in;
            points = ps_in;
            sd_table = new double?[ps_in.cnt, ps_in.cnt];
            //Fill the first column
            for (int i = 0; i < ps_in.cnt; i++)
            {
                sd_table[i, 0] = func.Caclulate(points[i]);
            }
            int str_cnt = ps_in.cnt-1;
            for (int j = 1; j < ps_in.cnt; j++)
            {
                for (int i = 0; i < str_cnt; i++)
                {
                    sd_table[i, j] = (sd_table[i + 1, j - 1] + sd_table[i, j - 1]) / (points[i + 1] - points[i]);
                }
                str_cnt--;
            }
        }

        //Indexer
        public double? this[int i,int j]
        {
            get { return sd_table[i,j]; }
        }
    }
}
