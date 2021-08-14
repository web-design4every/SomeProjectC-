using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        Button btnUp;
        Button btnDown;
        Button btnRight;
        Button btnLeft;
        Form2 f;
        Button btnMove;
        public Form1()
        {
            InitializeComponent();
            btnLeft = new Button();
            btnLeft.Size = new Size(50, 50);
            btnLeft.Text = "Left";
            btnLeft.Location = new Point(100, 100);
            this.Controls.Add(btnLeft);
            btnLeft.Click += BtnLeft_Click;

            btnRight = new Button();
            btnRight.Size = new Size(50, 50);
            btnRight.Location = new Point(200, 100);
            btnRight.Text = "Right";
            this.Controls.Add(btnRight);
            btnRight.Click += BtnRight_Click;

            btnUp = new Button();
            btnUp.Size = new Size(50, 50);
            btnUp.Text = "Up";
            btnUp.Location = new Point(150, 50);
            this.Controls.Add(btnUp);
            btnUp.Click += BtnUp_Click;

            btnDown = new Button();
            btnDown.Size = new Size(50, 50);
            btnDown.Text = "Down";
            btnDown.Location = new Point(150, 150);
            this.Controls.Add(btnDown);
            btnDown.Click += BtnDown_Click;

            f = new Form2();
            f.Show();
            btnMove = new Button();
            btnMove.Size = new Size(50, 50);
            btnMove.Text = "Move";
            btnMove.Location = new Point(100, 100);
            f.Controls.Add(btnMove);
        }

        private void F_Resize(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            btnMove.Location = new Point(btnMove.Location.X, btnMove.Location.Y+10);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            btnMove.Location = new Point(btnMove.Location.X, btnMove.Location.Y-10);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            btnMove.Location = new Point(btnMove.Location.X+10, btnMove.Location.Y);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            btnMove.Location = new Point(btnMove.Location.X-1, btnMove.Location.Y);
        }
    }
}
