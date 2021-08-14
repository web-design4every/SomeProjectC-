using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Test1
{
    public partial class Form1 : Form
    {
        DAO db = new DAO();
        Student s;
        Subject su;
        public Form1()
        {
            InitializeComponent();
            List<Student> liststudent = new List<Student>();
            List<Subject> listsubject = new List<Subject>();
            liststudent = db.ListStudent();
            foreach (Student s in liststudent)
            {
                cbStudent.Items.Add(s.name);
            }
            listsubject = db.ListSubject();
            foreach (Subject su in listsubject)
            {
                cbSubject.Items.Add(su.name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam() { sid=db.getStudentID(cbStudent.SelectedItem.ToString()),suid=db.getSubjectID(cbSubject.SelectedItem.ToString()),date=dateTimePicker1.Value,score=int.Parse(txtScore.Text)};
            db.InsertExam(exam);
        }
    }
}
