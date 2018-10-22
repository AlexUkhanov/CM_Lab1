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
        PointsSequence points;
        public MainForm()
        {
            InitializeComponent();
            points = new PointsSequence(1, 3, false, 5);
            SplitDifferenceTable sdt = new SplitDifferenceTable(points, new Function(x => 1.0 / (5 + 9 * x * x)));
        }
    }
}
