using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace set_display_resolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 display = new Form2();

        public void button1_Click(object sender, EventArgs e)
        {
            this.h = height.Value;
            this.w = width.Value;
            int h2 = (int)h;
            int w2 = (int)w;
            display.H = h2;
            display.W = w2;
            display.Show();
            this.Hide();
            var box = MessageBox.Show("The first window is hidden now click OK to close program","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(box == DialogResult.OK)
            {
                this.Close();
            }
        }
        NumericUpDown sans = new NumericUpDown();
        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal w = width.Value;

            this.h = height.Value;
            Resolution.Text = w + " x " + h;

        }
        public decimal w{ get; set; }
        public decimal h { get; set; }
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            decimal h = height.Value;
            this.w = width.Value;
            Resolution.Text = w + " x " + h;

            
         
        }


    }
}
