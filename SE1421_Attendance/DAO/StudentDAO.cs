using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class StudentDAO : BaseDAO<Attendance, Student>
    {
        public override void insert(Attendance entity)
        {
            string sql = "INSERT into Attendance(sid,attendance) values(@sid,@attendance)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@sid", entity.sid));
            command.Parameters.Add(new SqlParameter("@attendance", entity.attendance));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override List<Attendance> listStudent()
        {
            List<Attendance> attendances = new List<Attendance>();
            try
            {
                string sql = "SELECT id,name FROM Attendance";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Attendance s = new Attendance()
                    {
                        sid = reader["sid"].ToString(),
                        attendance = Convert.ToBoolean(reader["attendance"]),
                    };
                    attendances.Add(s);
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
            return attendances;
        }
    }
}
