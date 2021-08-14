using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAO : BaseDAO<Book, Book_Author, Author>
    {
        public override void insertBook(Book entity)
        {
            string sql = "INSERT into Book(id,title,publisheDate) values(@id,@title,@publisheDate)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@id", entity.id));
            command.Parameters.Add(new SqlParameter("@title", entity.title));
            command.Parameters.Add(new SqlParameter("@publisheDate", entity.publisheDate));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override void insertBookAuthor(Book_Author entity)
        {
            string sql = "INSERT into Book_Author(bid,aid) values(@bid,@aid)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@bid", entity.bid));
            command.Parameters.Add(new SqlParameter("@aid", entity.aid));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public override List<Author> ListAuthor()
        {
            List<Author> authors = new List<Author>();
            try
            {
                string sql = "select * from Author";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Author s = new Author()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        name = reader["name"].ToString(),
                    };
                    authors.Add(s);
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
            return authors;
        }
    }

}
