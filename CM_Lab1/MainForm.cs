using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CM_Lab1
{
    public partial class MainForm : Form
    {
        //Step
        private readonly double eps = 0.001;
        //Function
        private Function _func;
        public MainForm()
        {
            InitializeComponent();
            _func = new Function(x => 1 / (1 + 25 * x * x));
        }
        //Draw function on chart
        private void DrawFunc(
           Chart chrt,
           IFunction func,
           double left,
           double right,
           string name = "")
        {
            if (chrt.Series.IndexOf(name) != -1)
                chrt.Series.Remove(chrt.Series[name]);
            var grp = new Series(name);
            grp.ChartType = SeriesChartType.Line;
            grp.ChartArea = "main";
            for (double x = left + eps; x <= right - eps; x += this.eps)
            {
                grp.Points.AddXY(x, func.Caclulate(x));
            }
            chrt.Series.Add(grp);
        }

        //Overloaded DrawFunc
        private void DrawFunc(Chart chrt, IFunction func, string name = "")
        {
            double a = Convert.ToDouble(nudLeft.Value);
            double b = Convert.ToDouble(nudRight.Value);
            this.DrawFunc(chrt, func, a, b, name);
        }
        // Event handler on change event
        private void ChangeEvent(object sender, EventArgs e)
        {
            chartFunctions.Series.Clear();
            chartError.Series.Clear();
        }
        //Run
        private void btRun_Click(object sender, EventArgs e)
        {
            this.DrawFunc(chartFunctions, this._func, "func");

            double a = Convert.ToDouble(nudLeft.Value);
            double b = Convert.ToDouble(nudRight.Value);
            int n = Convert.ToInt32(nudPower.Value);
            PointsSequence points = new PointsSequence(a, b, rbChebyshev.Checked, n);
            InterpolationNewtonPolynom polynom = new InterpolationNewtonPolynom(points, this._func);
            this.DrawFunc(chartFunctions, polynom, "polynom");
            this.DrawFunc(
                chartError,
                new Function(
                    x => Math.Abs(this._func.Caclulate(x) - polynom.Caclulate(x))),
                "error");
        }
    }
}
