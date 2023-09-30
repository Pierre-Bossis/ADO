using ADOExo.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExo.Repositories
{
    public class ContactRepository
    {
        private readonly SqlConnection _connection;
        public ContactRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Create(Contact contact)
        {
            _connection.Open();

            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "insert into Contact values (@nom,@prenom,@age)";
            cmd.Parameters.AddWithValue("nom", contact.Nom);
            cmd.Parameters.AddWithValue("prenom", contact.Prenom);
            cmd.Parameters.AddWithValue("age", contact.Age);

            int RowAffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Nouvelle ligne dans la table {nameof(contact)} {RowAffected}");

            _connection.Close(); // ou _connection.Dispose();
        }

        public Contact GetById(int id)
        {
            _connection.Open();

            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "select * from Contact where Id = @id";
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Contact c = new Contact();
                c.Id = (int)reader["Id"];
                c.Nom = (string)reader["Nom"];
                c.Prenom = (string)reader["Prenom"];
                c.Age = (int)reader["Age"];

                _connection.Close();
                return c;
            }
            return null;
        }

        public IEnumerable<Contact> GetAll()
        {
            _connection.Open();

            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "select * from Contact";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Contact c = new Contact();
                c.Id = (int)reader["Id"];
                c.Nom = (string)reader["Nom"];
                c.Prenom = (string)reader["Prenom"];
                c.Age = (int)reader["Age"];
                yield return c;
            }

            _connection.Close();
        }

        public void Update(int id,string nom,string prenom,int age)
        {
            _connection.Open();

            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "update Contact set Nom = @nom,Prenom = @prenom,Age = @age where Id = @id";
            cmd.Parameters.AddWithValue("nom", nom);
            cmd.Parameters.AddWithValue("prenom", prenom);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("id", id);

            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();

            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "delete from Contact where id = @id";
            cmd.Parameters.AddWithValue("id", id);

            cmd.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
