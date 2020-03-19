using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Mat_Fiz_2._3
{
    public partial class LogControl : UserControl
    {
        public LogControl()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

                Double inputValue_1 = Convert.ToDouble(textBox1.Text);
                Double inputValue_2 = Convert.ToDouble(textBox2.Text);
                Double result = Math.Log(inputValue_2) / Math.Log(inputValue_1);
                label3.Text = result.ToString();
                textBox1.Text = "0";
                textBox2.Text = "0";
        }
    }
}
