using System.Data.SqlClient;

string connectionString = "votre connectionString";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    using (SqlCommand cmd = connection.CreateCommand())
    {
        #region Add
        //cmd.CommandText = "insert into Contact values (@nom,@prenom,@age)";
        //cmd.Parameters.AddWithValue("nom","Dupont");
        //cmd.Parameters.AddWithValue("prenom","Jean");
        //cmd.Parameters.AddWithValue("age",50);

        //int RowAffected = cmd.ExecuteNonQuery();

        //Console.WriteLine($"Ligne affectée {RowAffected}");
        #endregion

        #region GetAll
        //cmd.CommandText = "select * from Contact";
        //SqlDataReader reader = cmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    Console.WriteLine($"Id : {reader["Id"]} Prenom : {reader["Prenom"]} Nom : {reader["Age"]}");
        //}
        #endregion

        #region GetById
        //int id = int.Parse(Console.ReadLine());
        //cmd.CommandText = "select * from Contact where Id = @id";
        //cmd.Parameters.AddWithValue("id", id);

        //SqlDataReader reader = cmd.ExecuteReader();
        //if (reader.Read())
        //{
        //    Console.WriteLine($"Id : {reader["Id"]} Prenom : {reader["Prenom"]} Nom : {reader["Age"]}");
        //}
        #endregion

        #region Update
        //Console.WriteLine("Id a modifier :");
        //int id = int.Parse(Console.ReadLine());
        //Console.WriteLine("Nom");
        //string nom = Console.ReadLine();
        //Console.WriteLine("Prenom");
        //string prenom = Console.ReadLine();
        //Console.WriteLine("Age");
        //int age = int.Parse(Console.ReadLine());
        //cmd.CommandText = "update Contact set Nom = @nom,Prenom = @prenom,Age = @age where Id = @id";
        //cmd.Parameters.AddWithValue("nom",nom);
        //cmd.Parameters.AddWithValue("prenom",prenom);
        //cmd.Parameters.AddWithValue("age",age);
        //cmd.Parameters.AddWithValue("id",id);

        //cmd.ExecuteNonQuery();
        #endregion

        #region Delete
        //Console.WriteLine("Ligne(Id) à supprimer :");
        //int id = int.Parse(Console.ReadLine());
        //cmd.CommandText = "delete from Contact where id = @id";
        //cmd.Parameters.AddWithValue("id", id);

        //cmd.ExecuteNonQuery();
        #endregion
    }
}