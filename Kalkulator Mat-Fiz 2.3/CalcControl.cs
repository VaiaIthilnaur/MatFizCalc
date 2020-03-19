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
    public partial class CalcControl : UserControl
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string operand3 = string.Empty;
        string result;
        char operation;
        public CalcControl()
        {
            InitializeComponent();
        }
        private void CalcControl_Load_1(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        txtInput.Text += "1";
                        break;
                    case "btnTwo":
                        txtInput.Text += "2";
                        break;
                    case "btnThree":
                        txtInput.Text += "3";
                        break;
                    case "btnFour":
                        txtInput.Text += "4";
                        break;
                    case "btnFive":
                        txtInput.Text += "5";
                        break;
                    case "btnSix":
                        txtInput.Text += "6";
                        break;
                    case "btnSeven":
                        txtInput.Text += "7";
                        break;
                    case "btnEight":
                        txtInput.Text += "8";
                        break;
                    case "btnNine":
                        txtInput.Text += "9";
                        break;
                    case "btnZero":
                        txtInput.Text += "0";
                        break;
                    case "btnDot":
                        if (!txtInput.Text.Contains(","))
                            txtInput.Text += ",";
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    //case '+': 
                    //case '-': 
                    //case '*': 
                    //case '/': 
                    //case '.': 
                    //case '^': 
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ,, *, /, ^ are allowed");
                    break;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            label1.Text = operand1;
            operation = '/';
            txtInput.Text = string.Empty;
        }

        private void btnMulitply_Click_1(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            label1.Text = operand1;
            operation = '*';
            txtInput.Text = string.Empty;
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            label1.Text = operand1;
            operation = '+';
            txtInput.Text = string.Empty;
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            label1.Text = operand1;
            operation = '-';
            txtInput.Text = string.Empty;
        }

        private void btnPot_Click_1(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            label1.Text = operand1;
            operation = '^';
            txtInput.Text = string.Empty;
        }

        private void buttonRowna_Click(object sender, EventArgs e)
        {
            operand2 = txtInput.Text;
            label1.Text = string.Empty;
            double opr1, opr2;
            double.TryParse(operand1, out opr1);
            double.TryParse(operand2, out opr2);

            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
                case '^':
                    result = Math.Pow(opr1, opr2).ToString();
                    break;

            }

            if (txtInput.Text == ""||label1.Text =="")
            {
                MessageBox.Show("WTF>?");
            }
            else txtInput.Text = result.ToString();
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            txtInput.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }


        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (Math.Sqrt(opr1)).ToString();
            }
        }


    }
}
