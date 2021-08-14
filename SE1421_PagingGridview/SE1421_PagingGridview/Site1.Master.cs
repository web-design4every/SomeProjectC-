using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1421_PagingGridview
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public List<User> users()
        {
            List<User> list = new List<User>();
            list.Add(new User() { username = "admin", password = "123" });
            list.Add(new User() { username = "mra", password = "123" });
            list.Add(new User() { username = "mrb", password = "123" });
            list.Add(new User() { username = "mrc", password = "123" });
            return list;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> list = users();
            foreach(User u in list)
            {
                if (u.username.Equals(txtUsername.Text)&&u.password.Equals(txtPassword.Text))
                {
                    Session["login"] = u.username;
                }
            }
        }
    }
}