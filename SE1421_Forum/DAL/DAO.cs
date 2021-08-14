using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAO : BaseDAO<Post, Comments>
    {
        public override int getLastIDComment()
        {
            try
            {
                string sql = "select top 1 id from Comment order by id desc";
                SqlCommand command = new SqlCommand(sql, connection);
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

        public override int getLastIDPost()
        {
            try
            {
                string sql = "select top 1 id from Post order by id desc";
                SqlCommand command = new SqlCommand(sql, connection);
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

        public override void InsertComment(Comments entity)
        {
            string sql = "INSERT into Comment(id,commentcontent,pid) values (@id,@content,@pid)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@content", entity.content));
            command.Parameters.Add(new SqlParameter("@pid", entity.pid));
            command.Parameters.Add(new SqlParameter("@id", entity.id));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override void InsertPost(Post entity)
        {
            string sql = "INSERT into Post(id,postcontent) values (@id,@content)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@content", entity.content));
            command.Parameters.Add(new SqlParameter("@id", entity.id));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
