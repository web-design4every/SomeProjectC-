using Entity;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Attendance
{
    public partial class Form1 : Form
    {
        StudentDAO db = new StudentDAO();
        public Form1()
        {
            InitializeComponent();
            loadStudents();
        }

        private void loadStudents()
        {
            List<Attendance> students = db.listStudent();
            grdStudent.DataSource = students;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
