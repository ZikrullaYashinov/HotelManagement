using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class Kalkulyator : Form
    {
        double resoult;
        string operation;
        bool event_value;
        public Kalkulyator()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            resoult = 0;
            operation = string.Empty;
            event_value = false;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int len = textBox1.Text.Length;
                bool k = textBox1.Text[0] == '-' ? true : false;
                if (k && len == 2 || len == 1)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(len - 1);
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            
        }
    }
}
