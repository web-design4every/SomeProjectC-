using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1421_FirstWebFormApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDAO dao = new BaseDAO();
            dt = new DataTable();
            dt= dao.GetDataToTableByName(Request["value"]);

            gridView.DataSource = dt;
            gridView.DataBind();
        }

    }
}