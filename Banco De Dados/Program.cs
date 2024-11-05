
using Microsoft.Data.SqlClient;

namespace A
{
    internal class Program
    {

        private static void Salvar(Autor autor, SqlConnection conn)
        {
            Console.WriteLine("== Salvando o Autor ==");

            var Cmd  = conn.CreateCommand();
            Cmd.CommandText = "INSERT INTO Autor (Nome) VALUES (@nome)";

            var param = new SqlParameter("nome", autor.Nome);
            Cmd.Parameters.Add(param);

            Cmd.ExecuteNonQuery();
        }

        static void Main(string[] args)
        {
            SqlConnection? sqlConnection = null;
            string URK = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"BdAutor Livro\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try { 
                sqlConnection = new(URK);
                sqlConnection.Open();
                Console.WriteLine("Conexão Termineted");

            }
            catch (Exception ex) { 
                Console.WriteLine("Conexão Fudida");
            }
            if (sqlConnection != null) { 
                Autor autor = new Autor("TeComiNa");
                Salvar(autor, sqlConnection);
            }
        }
    }
}
