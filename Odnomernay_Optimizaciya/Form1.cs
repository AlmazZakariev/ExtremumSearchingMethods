using Odnomernay_Optimizaciya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odnomernay_Optimizaciya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FH = new FunctionHandler(textBox1.Text);
            var Extremum = new ExtremumSearching(FH.RegionA, FH.RegionB, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            //для задания границ вручную
            //var Extremum = new ExtremumSearching(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            if (radioButton1.Checked)
            {
                Extremum.DivisionSegmentInHalf(FH);
            }
            else if (radioButton2.Checked)
            {
                Extremum.Dichotomy(FH);
            }
            else if (radioButton3.Checked)
            {
                Extremum.GoldenRatio(FH);
            }
            label2.Text = "X = " + Convert.ToString(Extremum.XResult);
            label3.Text = "Y = "  + Convert.ToString(Extremum.YResult);

        }

       
    }
}
