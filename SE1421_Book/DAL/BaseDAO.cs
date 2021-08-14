using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public abstract class BaseDAO<E,F,G>
    {
        protected SqlConnection connection;
        public BaseDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public abstract List<G> ListAuthor();

        public abstract void insertBook(E entity);
        public abstract void insertBookAuthor(F entity);
    }
}
