/*Copyright (C) 2023 Huzieva Iyliia*/
/*Підрахувати кількість однакових символів, що входять у заданий рядок.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huzeva_Lab19
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string inputString = InputTextBox.Text;
            if (string.IsNullOrEmpty(inputString))
            {
                MessageBox.Show("Please enter a string to count characters.");
                return;
            }

            var charCounts = inputString.GroupBy(c => c)
                                        .ToDictionary(g => g.Key, g => g.Count());


            lblOutput.Text = "";
            foreach (var charCount in charCounts)
            {
                lblOutput.Text += charCount.Key + ": " + charCount.Value + Environment.NewLine;
            }
        }

    }
}
