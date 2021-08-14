using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operataor;
        int firstnum;
        TextBox txtScreen;
        string[] text = { "+", "9", "8", "7", "-", "6", "5", "4", "X", "3", "2", "1", "/", "=", ".", "0" };
        public Form1()
        {

            InitializeComponent();
            txtScreen = new TextBox();
            txtScreen.Size = new Size(230, 50);
            txtScreen.ReadOnly = true;
            txtScreen.Location = new Point(40, 30);
            txtScreen.ReadOnly = true;
            this.Controls.Add(txtScreen);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Text = text.ElementAt(i * 4 + j);
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(220 - (20 * j + 40 * j), 70 + (20 * i + 40 * i));
                    this.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string value = btn.Text;
            if (!(value.Equals("+") || value.Equals("-") ||
                value.Equals("/") || value.Equals("X") ||
                value.Equals("=") || txtScreen.Text.Contains(".")))
                txtScreen.Text = txtScreen.Text + value;

            if (value.Equals("+"))
            {
                firstnum = Int16.Parse(txtScreen.Text);
                txtScreen.Text = "";
                operataor = "+";
            }
            if (value.Equals("-"))
            {
                firstnum = Int16.Parse(txtScreen.Text);
                txtScreen.Text = "";
                operataor = "-";
            }
            if (value.Equals("X"))
            {
                firstnum = Int16.Parse(txtScreen.Text);
                txtScreen.Text = "";
                operataor = "X";
            }
            if (value.Equals("/"))
            {
                firstnum = Int16.Parse(txtScreen.Text);
                txtScreen.Text = "";
                operataor = "/";
            }
            if (value.Equals("="))
            {
                if (operataor.Equals("+"))
                {
                    txtScreen.Text = (Int16.Parse(txtScreen.Text) + firstnum).ToString();
                }
                if (operataor.Equals("-"))
                {
                    txtScreen.Text = (firstnum - Int16.Parse(txtScreen.Text)).ToString();
                }
                if (operataor.Equals("X"))
                {
                    txtScreen.Text = (firstnum * Int16.Parse(txtScreen.Text)).ToString();
                }
                if (operataor.Equals("/"))
                {
                    txtScreen.Text = (firstnum / Int16.Parse(txtScreen.Text)).ToString();
                }
            }
        }

    }
}
