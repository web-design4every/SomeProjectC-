using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_FirstWindowForm
{
    public partial class Form1 : Form
    {
        Button btnOK1;
        Button btnOk2;
        TextBox txtValue;
        public Form1()
        {
            InitializeComponent();
            btnOK1 = new Button();
            btnOK1.Text = "Ok";
            btnOK1.Size = new Size(100, 70);
            btnOK1.Location = new Point(100, 100);
            this.Controls.Add(btnOK1);
            btnOK1.Click += BtnOk_Click;

            btnOk2 = new Button();
            btnOk2.Text = "Ok";
            btnOk2.Size = new Size(100, 70);
            btnOk2.Location = new Point(200, 200);
            this.Controls.Add(btnOk2);
            btnOk2.Click += BtnOk_Click;

            txtValue = new TextBox();
            txtValue.Size = new Size(150, 30);
            btnOk2.Location = new Point(200, 300);
            txtValue.ReadOnly = true;
            txtValue.Enabled = true;
            this.Controls.Add(txtValue);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (btnOK1 == sender)
            {
                ((Button)sender).Text = "Ahihi";
            }
           DialogResult result = MessageBox.Show(this, "Do you love me?", "Stupid Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                Console.WriteLine("Ahihi");
            }
        }
    }
}
