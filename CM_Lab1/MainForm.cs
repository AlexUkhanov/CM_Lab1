using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //double[] arr = { -2, 0, 2 };
            //PointsSequence points=new PointsSequence(arr);
            PointsSequence points = new PointsSequence(-1, 1, false, 15);
            InterpolationNewtonPolynom polynom=new InterpolationNewtonPolynom(points, new Function(x => 1.0 / (5 + 9 * x * x)));
            double val = polynom.Calculate(0.5);
        }
    }
}
