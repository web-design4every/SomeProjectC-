using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public abstract class BaseDAO<E,F>
    {
        protected SqlConnection connection;
        public BaseDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public abstract int getLastIDPost();
        public abstract int getLastIDComment();

        public abstract void InsertPost(E entity);
        public abstract void InsertComment(F entity);
    }
}
