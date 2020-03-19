using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Mat_Fiz_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            trd.Abort();
            calcControl1.BringToFront();
            calcControl1.Dock = DockStyle.Left;
        }
        private void formRun()
        {
            Application.Run(new SplachScreen());
        }
        public void Karakan()
        {
            label9.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox7.BackColor = Color.FromArgb(26, 32, 40);
            label8.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox8.BackColor = Color.FromArgb(26, 32, 40);
            label7.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox5.BackColor = Color.FromArgb(26, 32, 40);
            label4.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox3.BackColor = Color.FromArgb(26, 32, 40);
            label5.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox6.BackColor = Color.FromArgb(26, 32, 40);
            label6.BackColor = Color.FromArgb(26, 32, 40);
            pictureBox4.BackColor = Color.FromArgb(26, 32, 40);
            label9.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        public void Karakan2(Label obiekt1)
        {
            if (obiekt1.BackColor == Color.FromArgb(19, 177, 180))
            {
                obiekt1.ForeColor = Color.White;
            }
            else
            {
                obiekt1.ForeColor = Color.FromArgb(19, 177, 180);
            }
        }
        public void Karakan3(Label obiekt1)
        {
            if (obiekt1.BackColor != Color.FromArgb(19, 177, 180))
            {
                obiekt1.ForeColor = Color.White;
            }
            else
            {
                obiekt1.ForeColor = Color.Black;
            }
        }
        public void Karakan4(Label obiekt1)
        {
            SidePanel.Show();
            SidePanel.Top = obiekt1.Top;
            SidePanel.Height = obiekt1.Height;
        }

        public void Karakan5()
        {
            calcControl1.Size = new System.Drawing.Size(778, 513);
            logControl1.Size = new System.Drawing.Size(778, 513);
            naControl1.Size = new System.Drawing.Size(778, 513);
            progressionControl1.Size = new System.Drawing.Size(778, 513);
            wxControl1.Size = new System.Drawing.Size(778, 513);
            fxControl1.Size = new System.Drawing.Size(778, 513);


        }
        public void Karakan6()
        {
            logControl1.Size = new System.Drawing.Size(616, 513);
            fxControl1.Size = new System.Drawing.Size(616, 513);
            wxControl1.Size = new System.Drawing.Size(616, 513);
            progressionControl1.Size = new System.Drawing.Size(616, 513);
            calcControl1.Size = new System.Drawing.Size(616, 513);
            naControl1.Size = new System.Drawing.Size(616, 513);
        }
        public void Karakan7()
        {
            logControl1.Dock = DockStyle.None;
            wxControl1.Dock = DockStyle.None;
            fxControl1.Dock = DockStyle.None;
            progressionControl1.Dock = DockStyle.None;
            calcControl1.Dock = DockStyle.None;
            naControl1.Dock = DockStyle.None;

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(panel1, true);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }
        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            calcControl1.Dock = DockStyle.Left;
            label4.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox3.BackColor = Color.FromArgb(19, 177, 180);
            calcControl1.BringToFront();
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label4);
            Karakan4(label4);
        }
        public void label4_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label4);
            SidePanel.Hide();
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label5);
            Karakan4(label5);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label5);
            SidePanel.Hide();

        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.Location = new Point(186, 6);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(32,32); 
            pictureBox2.Location = new Point(191, 11);
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label6);
            Karakan4(label6);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label6);
            SidePanel.Hide();

        }
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label7);
            Karakan4(label7);
        }
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label7);
            SidePanel.Hide();

        }
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label8);
            Karakan4(label8);
        }
        private void label8_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label8);
            SidePanel.Hide();

        }
        private void label9_MouseEnter(object sender, EventArgs e)
        {
            Karakan2(label9);
            Karakan4(label9);
        }
        private void label9_MouseLeave(object sender, EventArgs e)
        {
            Karakan3(label9);
            SidePanel.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            logControl1.Dock = DockStyle.Left;
            label5.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox6.BackColor = Color.FromArgb(19, 177, 180);
            logControl1.BringToFront();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            naControl1.Dock = DockStyle.Left;
            label6.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox4.BackColor = Color.FromArgb(19, 177, 180);
            naControl1.BringToFront();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            fxControl1.Dock = DockStyle.Left;
            fxControl1.BringToFront();
            label7.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox5.BackColor = Color.FromArgb(19, 177, 180);
        }
        
        private void label8_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            wxControl1.Dock = DockStyle.Left;
            wxControl1.BringToFront();
            label8.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox8.BackColor = Color.FromArgb(19, 177, 180);
        }
        
        private void label9_Click(object sender, EventArgs e)
        {
            Karakan();
            Karakan7();
            progressionControl1.Dock = DockStyle.Left;
            progressionControl1.BringToFront();
            label9.BackColor = Color.FromArgb(19, 177, 180);
            pictureBox7.BackColor = Color.FromArgb(19, 177, 180);
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(72, 513);
            Karakan5();
            pictureBox10.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            label1.Hide();
            label2.Hide();
            pictureBox11.Show();
            
        }
        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            panel1.Size = new Size(234, 513);
            Karakan6();
            pictureBox10.Hide();
            pictureBox1.Show();
            label1.Show();
            label2.Show();
            pictureBox11.Hide();
            pictureBox2.Location = new Point(191, 11);
            pictureBox2.Show();
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(33, 33); 
            pictureBox9.Location = new Point(815, 1);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(25, 25); 
            pictureBox9.Location = new Point(820, 6);
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(42, 42);
            pictureBox11.Location = new Point(29, 38);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(32, 32);
            pictureBox11.Location = new Point(34, 43);
        }
    }
}
