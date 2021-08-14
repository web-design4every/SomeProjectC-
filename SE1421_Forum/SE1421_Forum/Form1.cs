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

namespace SE1421_Forum
{
    public partial class Form1 : Form
    {
        List<UserPost> userPosts;
        DAO db = new DAO();
        public Form1()
        {
            InitializeComponent();
            userPosts = new List<UserPost>();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            UserPost u = new UserPost(txtPost.Text);
            userPosts.Add(u);
            pnPost.Controls.Add(u);
            u.post.id = db.getLastIDPost()+1;
            db.InsertPost(u.post);
            txtPost.Text = "";
        }
    }
}
