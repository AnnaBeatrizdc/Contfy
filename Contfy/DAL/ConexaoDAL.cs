using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contfy.DAL
{
    internal class ConexaoDAL
    {
        public static SqlConnection getConexao()
        {
            SqlConnection conexao = new SqlConnection(); // Cria um objeto SqlConnection, que é usado para estabelecer uma conexão com um banco de dados SQL Server.

            // Define a string de conexão para o banco de dados. A string de conexão contém informações sobre o servidor, o nome do banco de dados e as credenciais de autenticação necessárias para estabelecer a conexão. Neste caso, a string de conexão especifica que o servidor é "LOCALHOST", o banco de dados é "Contfy" e a autenticação integrada do Windows é usada (Integrated Security=True).
            conexao.ConnectionString =
            @"Server=LOCALHOST;
            Database=Contfy;
            Integrated Security=True";

            return conexao; // Retorna a conexão pronta para ser usada.
        }
    }
}
