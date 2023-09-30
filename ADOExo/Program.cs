using ADOExo.Entities;
using ADOExo.Repositories;
using System.Data.SqlClient;

string connectionString = "Data Source=DESKTOP-J2KFRML;Initial Catalog=Exo;Integrated Security=True;";
SqlConnection connection = new SqlConnection(connectionString);
ContactRepository ContactRepo = new ContactRepository(connection);


#region Add
//Contact contact = new Contact(); 
//contact.Nom = "Jean";
//contact.Prenom = "Roger";
//contact.Age = 60;
//ContactRepo.Create(contact);
#endregion

#region GetById
//Contact contact = ContactRepo.GetById(1);
//if (contact is not null)
//    Console.WriteLine($"{contact.Id} = {contact.Prenom} {contact.Nom}, {contact.Age} ans");
//else
//    Console.WriteLine("Aucun contact de cet Id n'existe.");
#endregion

#region GetAll
//IEnumerable<Contact> contacts = ContactRepo.GetAll();
//foreach(Contact contact in contacts)
//{
//    Console.WriteLine($"{contact.Id} = {contact.Prenom} {contact.Nom}, {contact.Age} ans");
//}
#endregion


#region Update
//Console.WriteLine("Entre la ligne à modifier (Id,Nom,Prenom,Age)");
//int id = int.Parse(Console.ReadLine());
//string nom = Console.ReadLine();
//string prenom = Console.ReadLine();
//int age = int.Parse(Console.ReadLine());
//ContactRepo.Update(id,nom,prenom,age);
#endregion

#region Delete
//Console.WriteLine("Ligne(Id) à supprimer :");
//int id = int.Parse(Console.ReadLine());
//ContactRepo.Delete(id);
#endregion