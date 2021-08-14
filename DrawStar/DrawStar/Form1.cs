using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayStar star = new DisplayStar(5);
            star.Size = new Size(400, 400);
            star.Location = new Point(100, 100);
            this.Controls.Add(star);
        }
    }
}
