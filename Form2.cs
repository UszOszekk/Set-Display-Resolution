﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace set_display_resolutions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int W{ get; set;}
        public int H { get; set;}

        private void Form2_Load(object sender, EventArgs e)
        {
            Width = W;
            Height = H;
        }
    }
}
