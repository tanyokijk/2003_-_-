using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2003_таймер_Деревянко
{
    public partial class Form1 : Form
    {
        Timer vTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowTimer);
        }
        private void ShowTimer(object vObject, EventArgs e)
        {
            vTimer.Stop();
            button2.Enabled = false;
            MessageBox.Show("Таймер спрацював!", "Таймер");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown.Value <= 0)
            {
                MessageBox.Show("Кількість секунд має бути більше 0!");
                return;
            }

            button2.Enabled = true;

            vTimer.Interval = Decimal.ToInt32(numericUpDown.Value) * 1000;
            vTimer.Start();
        }


        private void numSeconds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vTimer.Interval = Decimal.ToInt32(numericUpDown.Value) * 1000;
            vTimer.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            vTimer.Stop();
            MessageBox.Show("Таймер не встиг спрацювати!", "Таймер");
            button2.Enabled = false;
        }
    }
}

