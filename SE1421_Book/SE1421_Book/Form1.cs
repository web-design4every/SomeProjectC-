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

namespace SE1421_Book
{
    public partial class Form1 : Form
    {
        List<Control> authorControl = new List<Control>();
        DAO db = new DAO();
        public Form1()
        {
            InitializeComponent();
            List<Author> authors = new List<Author>();
            authors = db.ListAuthor();
            for (int i = 0; i < authors.Count; i++)
            {
                CheckBox cboAuthor = new CheckBox();
                cboAuthor.Text = authors[i].name;
                pnAuthor.Controls.Add(cboAuthor);
                authorControl.Add(cboAuthor);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book b = new Book() { id = int.Parse(txtID.Text), title = txtTitle.Text, publisheDate = dtPicker.Value };
            db.insertBook(b);
            Book_Author ba = new Book_Author();
            ba.bid = b.id;
            List<Author> authors = new List<Author>();
            authors = db.ListAuthor();
            for (int i = 0; i < authors.Count; i++)
            {
                CheckBox cbxauthor = (CheckBox)authorControl[i];
                if (cbxauthor.Checked)
                {
                    ba.aid = authors[i].id;
                    db.insertBookAuthor(ba);
                }
            }
        }

        private void pnAuthor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
