using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1421_Department
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DAO db = new DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDepartment();
            }
        }

        private void loadDepartment()
        {
            cbxDepartment.DataSource = db.loadDepartment();
            cbxDepartment.DataValueField = "id";
            cbxDepartment.DataTextField = "name";
            cbxDepartment.DataBind();
        }

        protected void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridView.DataSource = db.loadStudent(Convert.ToInt32(cbxDepartment.SelectedValue));
            gridView.DataBind();
        }

    }
}