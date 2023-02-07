using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GeneratePassword(int length, bool l, bool u, bool n, bool s)
        {
            string validChars = "";
            if (!l && !u && !n && !s)
            {
                checkBox0.Checked = true;
                l = true;
            }
            if (l) validChars += "abcdefghijklmnopqrstuvwxyz";
            if (u) validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (n) validChars += "1234567890";
            if (s) validChars += "!@#$%^&*?";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        void Generate()
        {
            Output.Text = GeneratePassword((int)numericUpDown1.Value, checkBox0.Checked, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
        }

        private void Re_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
