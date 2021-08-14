using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class QuanLyNhapKhoDAO
    {
        protected SqlConnection connection;
        public QuanLyNhapKhoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<NhaCungCap> listSupplier()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            try
            {
                string sql = "select * from NhaCungCap";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhaCungCap s = new NhaCungCap()
                    {
                        Ten = reader["Ten"].ToString(),
                        Ma = Convert.ToInt32(reader["Ma"].ToString()),
                    };
                    list.Add(s);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return list;
        }
    }
}
