using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoCalculator
{
    public partial class Form1 : Form
    {
        TextBox txtNum1;
        TextBox txtNum2;
        TextBox txtresult;
        Label lbl1;
        Label lbl2;
        Button btnPlus;
        Button btnMinus;
        Button btnDivide;
        Button btnMulti;
        public Form1()
        {
            InitializeComponent();
            txtNum1 = new TextBox();
            txtNum1.Size = new Size(200, 50);
            txtNum1.Enabled = true;
            txtNum1.Location = new Point(100, 50);
            this.Controls.Add(txtNum1);

            txtNum2 = new TextBox();
            txtNum2.Size = new Size(200, 50);
            txtNum2.Enabled = true;
            txtNum2.Location = new Point(100, 100);
            this.Controls.Add(txtNum2);

            txtresult = new TextBox();
            txtresult.Size = new Size(200, 50);
            txtresult.Enabled = true;
            txtresult.ReadOnly = true;
            txtresult.Location = new Point(100, 180);
            this.Controls.Add(txtresult);

            lbl1 = new Label();
            lbl1.Text = "Num 1";

            lbl1.Location = new Point(50, 50);
            this.Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Num 2";

            lbl2.Location = new Point(50, 100);
            this.Controls.Add(lbl2);

            btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Size = new Size(40, 40);
            btnPlus.Location = new Point(100, 130);
            this.Controls.Add(btnPlus);
            btnPlus.Click += BtnPlus_Click;

            btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Size = new Size(40, 40);
            btnMinus.Location = new Point(150, 130);
            this.Controls.Add(btnMinus);
            btnMinus.Click += BtnMinus_Click;

            btnMulti = new Button();
            btnMulti.Text = "x";
            btnMulti.Size = new Size(40, 40);
            btnMulti.Location = new Point(200, 130);
            this.Controls.Add(btnMulti);
            btnMulti.Click += BtnMulti_Click;

            btnDivide = new Button();
            btnDivide.Text = "/";
            btnDivide.Size = new Size(40, 40);
            btnDivide.Location = new Point(250, 130);
            this.Controls.Add(btnDivide);
            btnDivide.Click += BtnDivide_Click;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Calculate(btnDivide);
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Calculate(btnMulti);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Calculate(btnMinus);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Calculate(btnPlus);
        }
        public void Calculate(Button btn)
        {
            string text = btn.Text;
            int num1 = Int16.Parse(txtNum1.Text);
            int num2 = Int16.Parse(txtNum2.Text);
            int result = 0;
            if (text.Equals("+"))
            {
                result = num1 + num2;
            }
            if (text.Equals("-"))
            {
                result = num1 - num2;
            }
            if (text.Equals("x"))
            {
                result = num1 * num2;
            }
            if (text.Equals("/"))
            {
                result = num1 / num2;
            }
            string textresult = result.ToString();
            txtresult.Text = textresult;
        }
    }
}