﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Skill;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.contacts2;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.information;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.map22;
        }
    }
}
