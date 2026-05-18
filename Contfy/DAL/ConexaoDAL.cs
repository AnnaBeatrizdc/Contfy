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
            SqlConnection conexao = new SqlConnection();

            conexao.ConnectionString =
            @"Server=LOCALHOST;
            Database=Contfy;
            Integrated Security=True";

            return conexao;
        }
    }
}
