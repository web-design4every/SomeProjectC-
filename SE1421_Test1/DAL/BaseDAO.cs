using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public abstract List<E> ListStudent();
        public abstract List<F> ListSubject();
        //public abstract DataTable GetDataToTableByName(string name);

        public abstract int getStudentID(string name);
        public abstract int getSubjectID(string name);
        public abstract void InsertExam(G entity);
    }
}
