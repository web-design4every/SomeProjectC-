using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DAO
{
    public abstract class BaseDAO<E,F>
    {
        protected SqlConnection connection;
        public BaseDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public abstract List<E> listStudent();
        public abstract void insert(E entity);

    }
}
