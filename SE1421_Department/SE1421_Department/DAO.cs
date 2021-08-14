using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SE1421_Department
{
    public class DAO
    {
        protected SqlConnection connection;
        public DAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<Department> loadDepartment()
        {
            List<Department> departments = new List<Department>();
            try
            {
                string sql = "SELECT * from Department";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Department s = new Department()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                    };
                    departments.Add(s);
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
            return departments;
        }
        public List<Student> loadStudent(int id)
        {
            List<Student> students = new List<Student>();
            try
            {
                string sql = "SELECT * from Student where did=@id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@id", id));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                        did = Convert.ToInt32(reader["did"]),
                    };
                    students.Add(s);
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
            return students;
        }
    }
}