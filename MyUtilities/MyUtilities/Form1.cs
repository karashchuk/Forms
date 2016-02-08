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
            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;
                    if (i > 1000) break;
                }
               if(i<=1000) tbRandom.AppendText(n + "\n");
            }
            else
            {
                tbRandom.AppendText(n + "\n");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbRandom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
        }
        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }

        }
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}
