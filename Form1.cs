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
        public void x1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Resolution.Text = "1920x1080";
            button1.Visible = true;
            int w = 1920;
            int h = 1080;
            display.W = w;
            display.H = h;
        }

        public void x600ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Resolution.Text = "800x600";
            button1.Visible = true;
            int w = 800;
            int h = 600;
            display.W = w;
            display.H = h;
        }

        public void x500ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Resolution.Text = "500x500";
            button1.Visible = true;
            int w = 500;
            int h = 500;
            display.W = w;
            display.H = h;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            
            display.Show();
            this.Hide();
            var box = MessageBox.Show("The first window is hidden now click OK to close program","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(box == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
