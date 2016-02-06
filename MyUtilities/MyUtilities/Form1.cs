﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;


        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Мои Утилиты содержит ряд небоьших программ, \nкоторые могут пригодиться в жизни. \n\nАвтор: Каращук А.Ф.","О программе");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count=0;
            lblCount.Text = Convert.ToString (count);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32 (numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value)+1);
            lblRandom.Text = n.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
