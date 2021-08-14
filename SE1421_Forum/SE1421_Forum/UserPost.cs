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
    public partial class UserPost : UserControl
    {
        public Post post = new Post();
        DAO db = new DAO();
        public UserPost(string content)
        {
            InitializeComponent();
            post.comments = new List<Comments>();
            post.content = content;
            rtPost.Text = content;
        }

        private void btnAddCmt_Click(object sender, EventArgs e)
        {
            Comments comments = new Comments() { pid = post.id, content = txtAddCmt.Text, id = db.getLastIDComment()+1 };
            this.pnComment.Controls.Add(new Label() { Text = comments.content });
            post.comments.Add(comments);
            db.InsertComment(comments);
            txtAddCmt.Text = "";
        }
    }
}
