using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAO : BaseDAO<Student, Subject, Exam>
    {
        public override int getStudentID(string name)
        {
            try
            {
                string sql = "select id from Student where name=@name";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@name", name));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ID = Convert.ToInt32(reader["id"]);
                    return ID;
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
            return 0;
        }

        public override int getSubjectID(string name)
        {
            try
            {
                string sql = "select id from Subject where name=@name";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@name", name));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ID = Convert.ToInt32(reader["id"]);
                    return ID;
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
            return 0;
        }

        //public override DataTable GetDataToTableByName(string name)
        //{

        //}

        public override void InsertExam(Exam entity)
        {
            string sql = "INSERT into Exam(sid,suid,date,score) values (@sid,@suid,@date,@score)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@sid", entity.sid));
            command.Parameters.Add(new SqlParameter("@suid", entity.suid));
            command.Parameters.Add(new SqlParameter("@date", entity.date));
            command.Parameters.Add(new SqlParameter("@score", entity.score));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override List<Student> ListStudent()
        {
            List<Student> students = new List<Student>();
            try
            {
                string sql = "select id,name from Student";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
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

        public override List<Subject> ListSubject()
        {
            List<Subject> subject = new List<Subject>();
            try
            {
                string sql = "select id,name from Subject";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Subject s = new Subject()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                    };
                    subject.Add(s);
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
            return subject;
        }
    }
}
